using Microsoft.AspNetCore.Mvc;
using QRCodeGeneratorPresentation.Models.Request;
using QRCodeGeneratorPresentation.Models.Response;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using VietNamQRPay;

namespace QRCodeGeneratorPresentation.Controllers;

/// <summary>
/// Controller xử lý các yêu cầu liên quan đến ngân hàng
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class BankController : ControllerBase
{
    /// <summary>
    /// Đường dẫn lưu trữ ảnh mã QR
    /// </summary>
    private readonly string _storagePath = Path.Combine(Directory.GetCurrentDirectory(), "QRCodeStorage");

    /// <summary>
    /// Môi trường chạy
    /// </summary>
    private readonly IWebHostEnvironment _environment;

    /// <summary>
    /// Khởi tạo controller
    /// </summary>
    /// <param name="environment"></param>
    public BankController(IWebHostEnvironment environment)
    {
        _environment = environment;
        if (!Directory.Exists(_storagePath))
        {
            Directory.CreateDirectory(_storagePath);
        }
    }

    /// <summary>
    /// Lấy danh sách ngân hàng
    /// </summary>
    /// <returns>
    /// Trả về danh sách ngân hàng
    /// </returns>
    /// <response code="200">Trả về danh sách ngân hàng</response>
    [HttpGet("get-banks")]
    public IActionResult GetBankListAsync()
    {
        return Ok(new ResponseResult
        {
            Code = 0,
            Data = BankMapping.Banks,
            Message = "Success"
        });
    }

    /// <summary>
    /// Lấy thông tin ngân hàng theo mã ngân hàng
    /// </summary>
    /// <param name="bankCode">Mã ngân hàng</param>
    /// <returns>
    /// Trả về thông tin ngân hàng theo mã ngân hàng
    /// </returns>
    /// <response code="200">Trả về thông tin ngân hàng tìm kiếm được</response>
    /// <response code="400">Trả về lỗi</response>
    [HttpGet("get-bank-by-code")]
    public IActionResult GetBankDetailByCodeAsync([FromQuery] string bankCode)
    {
        // Kiểm tra mã ngân hàng
        var find = BankMapping.Banks.FirstOrDefault(b => b.Code.Equals(bankCode.ToUpper()));
        // Nếu không tìm thấy mã ngân hàng thì trả về lỗi
        if (find is null)
        {
            return BadRequest(new ResponseResult
            {
                Code = -1,
                Message = "Bank code is invalid!"
            });
        }

        // Trả về thông tin ngân hàng
        return Ok(new ResponseResult
        {
            Code = 0,
            Data = find,
            Message = "Success"
        });
    }

    /// <summary>
    /// Lấy thông tin ngân hàng theo short name
    /// </summary>
    /// <param name="bankShortName">Short name của ngân hàng</param>
    /// <returns>
    /// Trả về thông tin ngân hàng theo short name
    /// </returns>
    /// <response code="200">Trả về thông tin ngân hàng tìm kiếm được</response>
    /// <response code="400">Trả về lỗi</response>
    [HttpGet("get-bank-by-short-name")]
    public IActionResult GetBankDetailByShortNameAsync([FromQuery] string bankShortName)
    {
        // Kiểm tra short name ngân hàng
        var find = BankMapping.Banks.FirstOrDefault(b => b.Key.ToLower().Equals(bankShortName.ToLower()));
        // Nếu không tìm thấy short name ngân hàng thì trả về lỗi
        if (find is null)
        {
            return BadRequest(new ResponseResult
            {
                Code = -1,
                Message = "Bank short name is invalid!"
            });
        }

        // Trả về thông tin ngân hàng
        return Ok(new ResponseResult
        {
            Code = 0,
            Data = find,
            Message = "Success"
        });
    }

    /// <summary>
    /// Tạo mã QR cho chuyển khoản ngân hàng
    /// </summary>
    /// <param name="request">Thông tin yêu cầu tạo mã QR</param>
    /// <remarks>
    /// Dữ liệu yêu cầu tạo mã QR cho chuyển khoản ngân hàng: <br/>
    /// Mã ngân hàng <br/>
    /// Số tài khoản ngân hàng <br/>
    /// Số tiền chuyển khoản (optional) <br/>
    /// Nội dung chuyển khoản (optional)
    /// </remarks>
    /// <returns>
    /// Trả về mã QR cho chuyển khoản ngân hàng
    /// </returns>
    /// <response code="200">Trả về mã QR dạng Base64</response>
    /// <response code="400">Nếu có lỗi xảy ra</response>
    [HttpPost("generate-qr-code")]
    public IActionResult GenerateQRCodeAsync(BankTransferDataRequest request)
    {
        try
        {
            // Kiểm tra mã ngân hàng
            var bankBinFind = BankApp.BanksObject.FirstOrDefault(b => b.Key == request.BankCode);
            // Nếu không tìm thấy mã ngân hàng thì trả về lỗi
            if (bankBinFind.Value is null)
            {
                return BadRequest(new ResponseResult
                {
                    Code = -1,
                    Message = "Bank code is invalid!"
                });
            }

            // Lấy mã bin của ngân hàng
            var bankBin = bankBinFind.Value.bin;
            QRPay? qrPayContent;

            if (!string.IsNullOrEmpty(request.Amount))
            {
                // Nếu có số tiền thì tạo mã QR với số tiền
                var content = string.IsNullOrEmpty(request.Content) ? "Chuyen tien" : request.Content;
                qrPayContent = QRPay.InitVietQR(bankBin, request.BankAccount, request.Amount, content);
            }
            else
            {
                // Nếu không có số tiền thì tạo mã QR không có số tiền
                qrPayContent = QRPay.InitVietQR(request.BankCode, request.BankAccount);
            }

            // Tạo nội dung của mã QR
            var qrCodeContent = qrPayContent.Build();

            // Nếu có nội dung mã QR thì tạo mã QR
            if (!string.IsNullOrEmpty(qrCodeContent))
            {
                using var qrGenerator = new QRCodeGenerator();
                using var qrCodeData = qrGenerator.CreateQrCode(qrCodeContent, QRCodeGenerator.ECCLevel.Q);
                using var qrCode = new PngByteQRCode(qrCodeData);
                var qrCodeBytes = qrCode.GetGraphic(20);
                var base64String = Convert.ToBase64String(qrCodeBytes);

                // Trả về thông tin mã QR
                var response = new BankTransferDataResponse
                {
                    BankInformation = BankMapping.Banks.FirstOrDefault(b => b.Key == request.BankCode),
                    BankAccount = request.BankAccount,
                    Amount = request.Amount,
                    Content = request.Content,
                    QRCodeContent = qrCodeContent,
                    QRCodeBase64 = base64String,
                    QRCodeBase64Image = $"data:image/png;base64,{base64String}",
                };

                // Nếu yêu cầu tạo file ảnh mã QR thì tạo file ảnh mã QR
                if (request.IsGenerateFile)
                {
                    // Lưu file ảnh
                    string fileName = $"{Guid.NewGuid()}.png";
                    string filePath = Path.Combine(_storagePath, fileName);

                    using var ms = new MemoryStream(qrCodeBytes);
                    using (var indexedBitmap = new Bitmap(ms))
                    {
                        using var qrBitmap = new Bitmap(indexedBitmap.Width, indexedBitmap.Height, PixelFormat.Format32bppArgb);
                        using (var graphics = Graphics.FromImage(qrBitmap))
                        {
                            graphics.DrawImage(indexedBitmap, 0, 0);
                        }

                        var logoPath = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "Resource"), "logo.png");
                        if (System.IO.File.Exists(logoPath))
                        {
                            using var logo = new Bitmap(logoPath);
                            var overlaySize = qrBitmap.Width / 5;
                            using var resizedLogo = new Bitmap(logo, new Size(overlaySize, overlaySize));
                            using var graphics = Graphics.FromImage(qrBitmap);
                            var posX = (qrBitmap.Width - overlaySize) / 2;
                            var posY = (qrBitmap.Height - overlaySize) / 2;
                            graphics.DrawImage(resizedLogo, posX, posY, overlaySize, overlaySize);
                        }

                        qrBitmap.Save(filePath, ImageFormat.Png);
                    }

                    // Lấy domain hiện tại từ HttpContext
                    var domain = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
                    var url = $"{domain}/qrcode/display-qr-code?fileName={fileName}";
                    response.FileLink = url;
                }

                return Ok(new ResponseResult
                {
                    Code = 0,
                    Data = response,
                    Message = "Success"
                });
            }

            // Nếu không tạo được mã QR thì trả về lỗi
            return BadRequest(new ResponseResult
            {
                Code = -2,
                Message = "Cannot generate QRCode!"
            });
        }
        catch (Exception ex)
        {
            // Nếu có lỗi thì trả về lỗi
            return BadRequest(new ResponseResult
            {
                Code = -99,
                Message = ex.Message
            });
        }
    }

    /// <summary>
    /// Tạo mã QR cho chuyển khoản ngân hàng
    /// </summary>
    /// <param name="request">Thông tin yêu cầu tạo mã QR</param>
    /// <remarks>
    /// Dữ liệu yêu cầu tạo mã QR cho chuyển khoản ngân hàng: <br/>
    /// Mã BIN của ngân hàng <br/>
    /// Số tài khoản ngân hàng <br/>
    /// Số tiền chuyển khoản (optional) <br/>
    /// Nội dung chuyển khoản (optional)
    /// </remarks>
    /// <returns>
    /// Trả về mã QR cho chuyển khoản ngân hàng
    /// </returns>
    /// <response code="200">Trả về mã QR dạng Base64</response>
    /// <response code="400">Nếu có lỗi xảy ra</response>
    [HttpPost("generate-qr-code-image")]
    public IActionResult GenerateQRCodeReturnFileAsync(TransferDataRequest request)
    {
        try
        {
            // Tạo nội dung của mã QR
            var qrPayContent = QRPay.InitVietQR(request.BankBin, request.BankAccount, request.Amount, request.Content);
            var qrCodeContent = qrPayContent.Build();

            using var qrGenerator = new QRCodeGenerator();
            using var qrCodeData = qrGenerator.CreateQrCode(qrCodeContent, QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new PngByteQRCode(qrCodeData);
            // Tạo QR code dưới dạng mảng byte
            var qrCodeBytes = qrCode.GetGraphic(20);

            // Chuyển đổi mảng byte thành hình ảnh
            using var qrCodeImageStream = new MemoryStream(qrCodeBytes);
            using var qrCodeImage = Image.FromStream(qrCodeImageStream);
            // Tạo một hình ảnh mới với định dạng pixel không được lập chỉ mục
            using var nonIndexedImage = new Bitmap(qrCodeImage.Width, qrCodeImage.Height, PixelFormat.Format32bppArgb);
            using (var graphics = Graphics.FromImage(nonIndexedImage))
            {
                // Vẽ QR code lên hình ảnh mới
                graphics.DrawImage(qrCodeImage, 0, 0);
            }

            // Thêm logo vào giữa QR code
            var logoPath = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "Resource"), "logo.png");
            if (System.IO.File.Exists(logoPath))
            {
                using var logo = Image.FromFile(logoPath);
                // Chuyển đổi logo sang định dạng pixel không được lập chỉ mục (nếu cần)
                using var nonIndexedLogo = new Bitmap(logo.Width, logo.Height, PixelFormat.Format32bppArgb);
                using (var logoGraphics = Graphics.FromImage(nonIndexedLogo))
                {
                    logoGraphics.DrawImage(logo, 0, 0);
                }

                // Tính toán kích thước và vị trí của logo
                var logoSize = new Size((int)(nonIndexedImage.Width * 0.2), (int)(nonIndexedImage.Height * 0.2));
                var logoPosition = new Point(
                    (nonIndexedImage.Width - logoSize.Width) / 2,
                    (nonIndexedImage.Height - logoSize.Height) / 2
                );

                // Vẽ logo lên QR code
                using (var graphics = Graphics.FromImage(nonIndexedImage))
                {
                    graphics.DrawImage(nonIndexedLogo, new Rectangle(logoPosition, logoSize));
                }
            }

            // Chuyển đổi hình ảnh thành stream
            using var outputStream = new MemoryStream();
            nonIndexedImage.Save(outputStream, ImageFormat.Png);
            outputStream.Position = 0;

            // Trả về hình ảnh dưới dạng FileResult
            return File(outputStream.ToArray(), "image/png", "qrcode.png");
        }
        catch (Exception ex)
        {
            // Nếu có lỗi thì trả về lỗi
            return BadRequest(new ResponseResult
            {
                Code = -99,
                Message = ex.Message
            });
        }
    }

    /// <summary>
    /// Hiển thị ảnh mã QR
    /// </summary>
    /// <param name="fileName">Tên file ảnh mã QR</param>
    /// <remarks>
    /// Hiển thị ảnh mã QR dưới dạng file ảnh
    /// </remarks>
    /// <returns>
    /// Trả về ảnh mã QR
    /// </returns>
    /// <response code="200">Trả về hình ảnh mã QR</response>
    /// <response code="400">Nếu có lỗi xảy ra</response>
    [HttpGet("/qrcode/display-qr-code")]
    public IActionResult DisplayImage([FromQuery] string fileName)
    {
        try
        {
            // Kiểm tra xem file có tồn tại không
            string filePath = Path.Combine(_storagePath, fileName);
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("Ảnh không tồn tại.");
            }

            // Đọc file ảnh và trả về dưới dạng FileResult
            byte[] imageBytes = System.IO.File.ReadAllBytes(filePath);
            return File(imageBytes, "image/png"); // Thay "image/png" bằng MIME type phù hợp
        }
        catch (Exception ex)
        {
            // Nếu có lỗi thì trả về lỗi
            return BadRequest(new ResponseResult
            {
                Code = -99,
                Message = ex.Message
            });
        }
    }
}
