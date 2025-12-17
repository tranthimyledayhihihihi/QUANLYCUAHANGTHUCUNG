namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmDoiMatKhau
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMKCu;
        private System.Windows.Forms.Label lblMKMoi;
        private System.Windows.Forms.Label lblXacNhanMK;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel pnlContent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.lblXacNhanMK = new System.Windows.Forms.Label();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.lblMKMoi = new System.Windows.Forms.Label();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.lblMKCu = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Padding = new System.Windows.Forms.Padding(0, 16, 0, 8);
            this.lblTieuDe.Size = new System.Drawing.Size(838, 56);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "🔑 ĐỔI MẬT KHẨU TÀI KHOẢN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.pnlContent.Controls.Add(this.btnHuy);
            this.pnlContent.Controls.Add(this.btnXacNhan);
            this.pnlContent.Controls.Add(this.txtXacNhanMK);
            this.pnlContent.Controls.Add(this.lblXacNhanMK);
            this.pnlContent.Controls.Add(this.txtMKMoi);
            this.pnlContent.Controls.Add(this.lblMKMoi);
            this.pnlContent.Controls.Add(this.txtMKCu);
            this.pnlContent.Controls.Add(this.lblMKCu);
            this.pnlContent.Location = new System.Drawing.Point(144, 113);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(566, 240);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(247)))), ((int)(((byte)(220)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(326, 176);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 36);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Teal;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(114, 176);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(160, 36);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Location = new System.Drawing.Point(291, 120);
            this.txtXacNhanMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.PasswordChar = '•';
            this.txtXacNhanMK.Size = new System.Drawing.Size(143, 22);
            this.txtXacNhanMK.TabIndex = 2;
            // 
            // lblXacNhanMK
            // 
            this.lblXacNhanMK.AutoSize = true;
            this.lblXacNhanMK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblXacNhanMK.Location = new System.Drawing.Point(109, 120);
            this.lblXacNhanMK.Name = "lblXacNhanMK";
            this.lblXacNhanMK.Size = new System.Drawing.Size(115, 23);
            this.lblXacNhanMK.TabIndex = 5;
            this.lblXacNhanMK.Text = "Xác nhận MK:";
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(291, 80);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '•';
            this.txtMKMoi.Size = new System.Drawing.Size(143, 22);
            this.txtMKMoi.TabIndex = 1;
            // 
            // lblMKMoi
            // 
            this.lblMKMoi.AutoSize = true;
            this.lblMKMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMKMoi.Location = new System.Drawing.Point(109, 80);
            this.lblMKMoi.Name = "lblMKMoi";
            this.lblMKMoi.Size = new System.Drawing.Size(120, 23);
            this.lblMKMoi.TabIndex = 3;
            this.lblMKMoi.Text = "Mật khẩu mới:";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(291, 43);
            this.txtMKCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '•';
            this.txtMKCu.Size = new System.Drawing.Size(143, 22);
            this.txtMKCu.TabIndex = 0;
            // 
            // lblMKCu
            // 
            this.lblMKCu.AutoSize = true;
            this.lblMKCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMKCu.Location = new System.Drawing.Point(109, 43);
            this.lblMKCu.Name = "lblMKCu";
            this.lblMKCu.Size = new System.Drawing.Size(109, 23);
            this.lblMKCu.TabIndex = 1;
            this.lblMKCu.Text = "Mật khẩu cũ:";
            this.lblMKCu.Click += new System.EventHandler(this.lblMKCu_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(247)))), ((int)(((byte)(220)))));
            this.BackgroundImage = global::QUANLYCUAHANGTHUCUNG.Properties.Resources.download__5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 488);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}