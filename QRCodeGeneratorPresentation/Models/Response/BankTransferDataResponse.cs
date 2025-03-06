using VietNamQRPay;

namespace QRCodeGeneratorPresentation.Models.Response;

/// <summary>
/// Dữ liệu trả về sau khi tạo mã QR cho chuyển khoản ngân hàng
/// </summary>
public class BankTransferDataResponse
{
    /// <summary>
    /// Đường dẫn file ảnh mã QR
    /// </summary>
    public string FileLink { get; set; } = null!;

    /// <summary>
    /// Thông tin ngân hàng
    /// </summary>
    public BankInformation? BankInformation { get; set; }

    /// <summary>
    /// Số tài khoản ngân hàng
    /// </summary>
    public string BankAccount { get; set; } = null!;

    /// <summary>
    /// Số tiền chuyển khoản
    /// </summary>
    public string Amount { get; set; } = null!;

    /// <summary>
    /// Nội dung chuyển khoản
    /// </summary>
    public string Content { get; set; } = null!;
    
    /// <summary>
    /// Nội dung mã QR
    /// </summary>
    public string QRCodeContent { get; set; } = null!;

    /// <summary>
    /// Hình ảnh mã QR dạng base64
    /// </summary>
    public string QRCodeBase64 { get; set; } = null!;

    /// <summary>
    /// Hình ảnh mã QR dạng base64 đầy đủ
    /// </summary>
    public string QRCodeBase64Image { get; set; } = null!;
}
