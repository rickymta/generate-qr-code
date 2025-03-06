using VietNamQRPay;
using QRCoder;

namespace GenerateQRCodeTestForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            // Chuyển Dictionary thành danh sách phù hợp cho ComboBox
            var bankList = BankNameMapping.Mapping.Select(b => new { Value = b.Key, Display = b.Value }).ToList();

            // Gán danh sách vào ComboBox
            CboBankCode.DataSource = bankList;
            CboBankCode.DisplayMember = "Display";
            CboBankCode.ValueMember = "Value";
            CboBankCode.SelectedIndex = 44;
            TxtBankAccount.Text = "19034125504011";
            TxtAmount.Text = "50000";
            TxtContent.Text = "QuanDH chuyen tien";
        }

        /// <summary>
        /// Xử lý sự kiện click nút tạo mã QR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnGenerate_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu số tài khoản ngân hàng nhập vào
            if (string.IsNullOrEmpty(TxtBankAccount.Text))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản ngân hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra dữ liệu số tiền nhập vào
            if (string.IsNullOrEmpty(TxtAmount.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra dữ liệu nội dung nhập vào
            if (string.IsNullOrEmpty(TxtContent.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CboBankCode.SelectedItem is not null)
            {
                var selectedBank = (dynamic)CboBankCode.SelectedItem;
                var bankFind = BankMapping.Banks.FirstOrDefault(b => b.Code == selectedBank.Value);

                if (bankFind != null)
                {
                    var bankBin = bankFind.Bin;
                    var bankAccount = TxtBankAccount.Text;
                    var amount = TxtAmount.Text;
                    QRPay? qrPayContent;

                    if (!string.IsNullOrEmpty(amount))
                    {
                        var content = TxtContent.Text;
                        qrPayContent = QRPay.InitVietQR(bankBin, bankAccount, amount, content);
                    }
                    else
                    {
                        qrPayContent = QRPay.InitVietQR(selectedBank.Value, bankAccount);
                    }

                    var qrCodeContent = qrPayContent.Build();

                    if (!string.IsNullOrEmpty(qrCodeContent))
                    {
                        using var qrGenerator = new QRCodeGenerator();
                        using var qrData = qrGenerator.CreateQrCode(qrCodeContent, QRCodeGenerator.ECCLevel.Q);
                        using var qrCode = new QRCode(qrData);
                        var qrBitmap = qrCode.GetGraphic(10); // Độ phân giải

                        var checkbox = ChkUseLocalLogo.Checked;
                        if (checkbox)
                        {
                            // Chèn logo
                            var logoPath = AppDomain.CurrentDomain.BaseDirectory + "logo.png"; // Đường dẫn logo
                            if (File.Exists(logoPath))
                            {
                                using var logo = new Bitmap(logoPath);
                                qrBitmap = AddLogoToQrCode(qrBitmap, logo);
                            }
                        }
                        else
                        {
                            var logoUrl = bankFind.BankLogo;
                            var logoBitmap = await DownloadImageFromUrl(logoUrl);
                            if (logoBitmap != null)
                            {
                                qrBitmap = AddLogoToQrCode(qrBitmap, logoBitmap);
                            }
                        }

                        // Resize và hiển thị QR Code
                        var picWidth = PtbQRCode.Width;
                        var picHeight = PtbQRCode.Height;
                        var resizeQR = new Bitmap(qrBitmap, new Size(picWidth, picHeight));
                        PtbQRCode.Image = resizeQR;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ngân hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Thêm logo vào giữa mã QR
        /// </summary>
        private static Bitmap AddLogoToQrCode(Bitmap qrBitmap, Bitmap logo)
        {
            int qrSize = qrBitmap.Width;
            int logoSize = qrSize / 5; // Kích thước logo bằng 1/5 mã QR

            using var graphics = Graphics.FromImage(qrBitmap);
            int x = (qrSize - logoSize) / 2;
            int y = (qrSize - logoSize) / 2;

            using var resizedLogo = new Bitmap(logo, new Size(logoSize, logoSize));
            graphics.DrawImage(resizedLogo, x, y, logoSize, logoSize);

            return qrBitmap;
        }

        /// <summary>
        /// Tải ảnh từ URL về Bitmap
        /// </summary>
        private static async Task<Bitmap?> DownloadImageFromUrl(string url)
        {
            try
            {
                using var client = new HttpClient();
                var imageBytes = await client.GetByteArrayAsync(url);
                using var ms = new MemoryStream(imageBytes);
                return new Bitmap(ms);
            }
            catch
            {
                MessageBox.Show("Không thể tải logo từ URL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
