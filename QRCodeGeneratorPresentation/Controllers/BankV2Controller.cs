using Microsoft.AspNetCore.Mvc;
using QRCodeGeneratorPresentation.Models.Request;
using QRCodeGeneratorPresentation.Models.Response;
using QRCoder;
using System.Drawing.Imaging;
using System.Drawing;
using VietNamQRPay;

namespace QRCodeGeneratorPresentation.Controllers;

[Route("api/v2/bank")]
[ApiController]
public class BankV2Controller : ControllerBase
{
    /// <summary>
    /// Đường dẫn lưu trữ ảnh mã QR
    /// </summary>
    private readonly string _storagePath = Path.Combine(Directory.GetCurrentDirectory(), "QRCodeStorage");

    public BankV2Controller()
    {
        if (!Directory.Exists(_storagePath))
        {
            Directory.CreateDirectory(_storagePath);
        }
    }

    /// <summary>
    /// Tạo mã QR cho chuyển khoản ngân hàng
    /// </summary>
    /// <param name="bankBin">Mã BIN của ngân hàng (lấy từ api danh sách ngân hàng)</param>
    /// <param name="bankAccount">Số tài khoản ngân hàng</param>
    /// <param name="amount">Số tiền chuyển khoản</param>
    /// <param name="content">Nội dung chuyển khoản</param>
    /// <remarks>
    /// Dữ liệu yêu cầu tạo mã QR cho chuyển khoản ngân hàng: <br/>
    /// Mã BIN của ngân hàng <br/>
    /// Số tài khoản ngân hàng <br/>
    /// Số tiền chuyển khoản <br/>
    /// Nội dung chuyển khoản
    /// </remarks>
    /// <returns>
    /// Trả về mã QR cho chuyển khoản ngân hàng
    /// </returns>
    /// <response code="200">Trả về mã QR dạng Base64</response>
    /// <response code="400">Nếu có lỗi xảy ra</response>
    [HttpGet("generate-qr-code-image")]
    public IActionResult GenerateQRCodeReturnFileAsync([FromQuery] string bankBin, [FromQuery] string bankAccount, [FromQuery] string amount, [FromQuery] string content)
    {
        try
        {
            // Tạo nội dung của mã QR
            var qrPayContent = QRPay.InitVietQR(bankBin, bankAccount, amount, content);
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
}
