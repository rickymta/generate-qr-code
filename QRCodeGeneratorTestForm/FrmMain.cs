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
            CboBankCode.SelectedIndex = 0;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (CboBankCode.SelectedItem is not null)
            {
                var selectedBank = (dynamic)CboBankCode.SelectedItem;
                MessageBox.Show($"Mã ngân hàng: {selectedBank.Value}\nTên ngân hàng: {selectedBank.Display}");

                var bankBin = BankApp.BanksObject.FirstOrDefault(b => b.Key == selectedBank.Value).Value.bin;
                var bankAccount = TxtBankAccount.Text;
                var amount = TxtAmount.Text;
                QRPay? qrPayContent;

                if (!string.IsNullOrEmpty(amount))
                {
                    var content = TxtContent.Text;
                    content = string.IsNullOrEmpty(content) ? "Chuyen tien" : content;
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
                    var picWidth = PtbQRCode.Width;
                    var picHeight = PtbQRCode.Height;
                    var resizeQR = new Bitmap(qrBitmap, new Size(picWidth, picHeight));
                    PtbQRCode.Image = resizeQR; // Hiển thị lên PictureBox
                }
            }
        }
    }
}
