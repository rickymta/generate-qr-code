namespace QRCodeGeneratorPresentation.Models.Request;

/// <summary>
/// Dữ liệu yêu cầu tạo mã QR cho chuyển khoản ngân hàng
/// </summary>
public class BankTransferDataRequest
{
    /// <summary>
    /// Mã ngân hàng <br/>
    /// Lấy được từ api danh sách ngân hàng
    /// </summary>
    public string BankCode { get; set; } = null!;

    /// <summary>
    /// Số tài khoản ngân hàng
    /// </summary>
    public string BankAccount { get; set; } = null!;

    /// <summary>
    /// Số tiền chuyển khoản
    /// </summary>
    public string? Amount { get; set; }

    /// <summary>
    /// Nội dung chuyển khoản
    /// </summary>
    public string? Content { get; set; }
}
