namespace GenerateQRCodeTestForm
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            LblBankCode = new Label();
            TxtBankAccount = new TextBox();
            LblBankAccount = new Label();
            TxtContent = new TextBox();
            LblContent = new Label();
            TxtAmount = new TextBox();
            LblAmount = new Label();
            BtnGenerate = new Button();
            PtbQRCode = new PictureBox();
            CboBankCode = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)PtbQRCode).BeginInit();
            SuspendLayout();
            // 
            // LblBankCode
            // 
            LblBankCode.AutoSize = true;
            LblBankCode.Location = new Point(18, 25);
            LblBankCode.Name = "LblBankCode";
            LblBankCode.Size = new Size(128, 21);
            LblBankCode.TabIndex = 0;
            LblBankCode.Text = "Chọn ngân hàng:";
            // 
            // TxtBankAccount
            // 
            TxtBankAccount.Location = new Point(18, 140);
            TxtBankAccount.Name = "TxtBankAccount";
            TxtBankAccount.Size = new Size(301, 29);
            TxtBankAccount.TabIndex = 3;
            // 
            // LblBankAccount
            // 
            LblBankAccount.AutoSize = true;
            LblBankAccount.Location = new Point(18, 106);
            LblBankAccount.Name = "LblBankAccount";
            LblBankAccount.Size = new Size(99, 21);
            LblBankAccount.TabIndex = 2;
            LblBankAccount.Text = "Số tài khoản:";
            // 
            // TxtContent
            // 
            TxtContent.Location = new Point(352, 59);
            TxtContent.Multiline = true;
            TxtContent.Name = "TxtContent";
            TxtContent.Size = new Size(359, 110);
            TxtContent.TabIndex = 7;
            // 
            // LblContent
            // 
            LblContent.AutoSize = true;
            LblContent.Location = new Point(352, 25);
            LblContent.Name = "LblContent";
            LblContent.Size = new Size(78, 21);
            LblContent.TabIndex = 6;
            LblContent.Text = "Nội dung:";
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(18, 226);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(301, 29);
            TxtAmount.TabIndex = 5;
            // 
            // LblAmount
            // 
            LblAmount.AutoSize = true;
            LblAmount.Location = new Point(18, 192);
            LblAmount.Name = "LblAmount";
            LblAmount.Size = new Size(143, 21);
            LblAmount.TabIndex = 4;
            LblAmount.Text = "Số tiền cần chuyển:";
            // 
            // BtnGenerate
            // 
            BtnGenerate.Location = new Point(18, 293);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(186, 56);
            BtnGenerate.TabIndex = 8;
            BtnGenerate.Text = "Tạo mã QR";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // PtbQRCode
            // 
            PtbQRCode.Location = new Point(352, 226);
            PtbQRCode.Name = "PtbQRCode";
            PtbQRCode.Size = new Size(359, 359);
            PtbQRCode.TabIndex = 9;
            PtbQRCode.TabStop = false;
            // 
            // CboBankCode
            // 
            CboBankCode.FormattingEnabled = true;
            CboBankCode.Location = new Point(18, 59);
            CboBankCode.Name = "CboBankCode";
            CboBankCode.Size = new Size(301, 29);
            CboBankCode.TabIndex = 10;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 607);
            Controls.Add(CboBankCode);
            Controls.Add(PtbQRCode);
            Controls.Add(BtnGenerate);
            Controls.Add(TxtAmount);
            Controls.Add(LblAmount);
            Controls.Add(TxtContent);
            Controls.Add(LblContent);
            Controls.Add(TxtBankAccount);
            Controls.Add(LblBankAccount);
            Controls.Add(LblBankCode);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form test generate QR Code for bank";
            ((System.ComponentModel.ISupportInitialize)PtbQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblBankCode;
        private TextBox TxtBankAccount;
        private Label LblBankAccount;
        private TextBox TxtContent;
        private Label LblContent;
        private TextBox TxtAmount;
        private Label LblAmount;
        private Button BtnGenerate;
        private PictureBox PtbQRCode;
        private ComboBox CboBankCode;
    }
}
