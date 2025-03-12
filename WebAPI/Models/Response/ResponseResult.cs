namespace QRCodeGeneratorPresentation.Models.Response;

/// <summary>
/// Kết quả trả về
/// </summary>
public class ResponseResult
{
    /// <summary>
    /// Mã lỗi
    /// </summary>
    public int Code { get; set; }

    /// <summary>
    /// Dữ liệu trả về
    /// </summary>
    public object? Data { get; set; }

    /// <summary>
    /// Thông điệp
    /// </summary>
    public string? Message { get; set; }
}

/// <summary>
/// Kết quả trả về
/// </summary>
public class ResponseResult<T>
{
    /// <summary>
    /// Mã lỗi
    /// </summary>
    public int Code { get; set; }

    /// <summary>
    /// Dữ liệu trả về
    /// </summary>
    public T? Data { get; set; }

    /// <summary>
    /// Thông điệp
    /// </summary>
    public string? Message { get; set; }
}
