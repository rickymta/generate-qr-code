namespace QRCodeGeneratorPresentation.Models.Request;

public class TransferDataRequest
{
    /// <summary>
    /// Bin của ngân hàng
    /// </summary>
    public string BankBin { get; set; } = null!;

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
}
