namespace QRCodeGeneratorPresentation.Services;

/// <summary>
/// Service xóa các file cũ trong thư mục lưu trữ ảnh
/// </summary>
public class DeleteOldFilesService : BackgroundService
{
    /// <summary>
    /// Đường dẫn thư mục lưu trữ ảnh
    /// </summary>
    private readonly string _imageFolderPath;

    /// <summary>
    /// Khởi tạo service
    /// </summary>
    public DeleteOldFilesService()
    {
        // Đường dẫn thư mục lưu trữ ảnh
        _imageFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "QRCodeStorage");
    }

    /// <summary>
    /// Phương thức chạy nền
    /// </summary>
    /// <param name="stoppingToken"></param>
    /// <returns></returns>
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            // Xóa các file cũ hơn 30 phút
            DeleteOldFiles();

            // Chờ 30 phút trước khi chạy lại
            await Task.Delay(TimeSpan.FromMinutes(30), stoppingToken);
        }
    }

    /// <summary>
    /// Xóa các file cũ hơn 30 phút
    /// </summary>
    private void DeleteOldFiles()
    {
        try
        {
            // Kiểm tra xem thư mục có tồn tại không
            if (!Directory.Exists(_imageFolderPath))
            {
                return;
            }

            // Lấy danh sách các file trong thư mục
            var files = Directory.GetFiles(_imageFolderPath);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                // Kiểm tra nếu file cũ hơn 30 phút
                if (fileInfo.LastWriteTime < DateTime.Now.AddMinutes(-30))
                {
                    // Xóa file
                    fileInfo.Delete();
                    Console.WriteLine($"Đã xóa file: {fileInfo.Name}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi xóa file: {ex.Message}");
        }
    }
}
