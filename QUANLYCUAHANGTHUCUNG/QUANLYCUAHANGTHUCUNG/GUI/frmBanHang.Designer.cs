using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmBanHang
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;

        private System.Windows.Forms.TabControl tabMatHang;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.TabPage tabThuCung;
        private System.Windows.Forms.TabPage tabDichVu;

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridView dgvThuCung;
        private System.Windows.Forms.DataGridView dgvDichVu;

        private System.Windows.Forms.DataGridView dgvGioHang;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThanhToan;

        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.tabMatHang = new System.Windows.Forms.TabControl();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.tabThuCung = new System.Windows.Forms.TabPage();
            this.dgvThuCung = new System.Windows.Forms.DataGridView();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tabMatHang.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tabThuCung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            this.tabDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 60);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁN HÀNG";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.cboKhachHang);
            this.pnlMain.Controls.Add(this.cboNhanVien);
            this.pnlMain.Controls.Add(this.dtpNgayBan);
            this.pnlMain.Controls.Add(this.tabMatHang);
            this.pnlMain.Controls.Add(this.dgvGioHang);
            this.pnlMain.Controls.Add(this.btnThem);
            this.pnlMain.Controls.Add(this.btnXoa);
            this.pnlMain.Controls.Add(this.btnThanhToan);
            this.pnlMain.Controls.Add(this.lblTongTien);
            this.pnlMain.Controls.Add(this.txtTongTien);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(1100, 640);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.Location = new System.Drawing.Point(20, 20);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(250, 24);
            this.cboKhachHang.TabIndex = 0;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Location = new System.Drawing.Point(300, 20);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(250, 24);
            this.cboNhanVien.TabIndex = 1;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Location = new System.Drawing.Point(580, 20);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayBan.TabIndex = 2;
            // 
            // tabMatHang
            // 
            this.tabMatHang.Controls.Add(this.tabSanPham);
            this.tabMatHang.Controls.Add(this.tabThuCung);
            this.tabMatHang.Controls.Add(this.tabDichVu);
            this.tabMatHang.Location = new System.Drawing.Point(20, 70);
            this.tabMatHang.Name = "tabMatHang";
            this.tabMatHang.SelectedIndex = 0;
            this.tabMatHang.Size = new System.Drawing.Size(480, 500);
            this.tabMatHang.TabIndex = 3;
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.dgvSanPham);
            this.tabSanPham.Location = new System.Drawing.Point(4, 25);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Size = new System.Drawing.Size(472, 471);
            this.tabSanPham.TabIndex = 0;
            this.tabSanPham.Text = "Sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeight = 34;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.Size = new System.Drawing.Size(472, 471);
            this.dgvSanPham.TabIndex = 0;
            // 
            // tabThuCung
            // 
            this.tabThuCung.Controls.Add(this.dgvThuCung);
            this.tabThuCung.Location = new System.Drawing.Point(4, 25);
            this.tabThuCung.Name = "tabThuCung";
            this.tabThuCung.Size = new System.Drawing.Size(472, 471);
            this.tabThuCung.TabIndex = 1;
            this.tabThuCung.Text = "Thú cưng";
            // 
            // dgvThuCung
            // 
            this.dgvThuCung.ColumnHeadersHeight = 34;
            this.dgvThuCung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuCung.Location = new System.Drawing.Point(0, 0);
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.RowHeadersWidth = 62;
            this.dgvThuCung.Size = new System.Drawing.Size(472, 471);
            this.dgvThuCung.TabIndex = 0;
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.dgvDichVu);
            this.tabDichVu.Location = new System.Drawing.Point(4, 25);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Size = new System.Drawing.Size(472, 471);
            this.tabDichVu.TabIndex = 2;
            this.tabDichVu.Text = "Dịch vụ";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeight = 34;
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVu.Location = new System.Drawing.Point(0, 0);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 62;
            this.dgvDichVu.Size = new System.Drawing.Size(472, 471);
            this.dgvDichVu.TabIndex = 0;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.ColumnHeadersHeight = 34;
            this.dgvGioHang.Location = new System.Drawing.Point(527, 95);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 62;
            this.dgvGioHang.Size = new System.Drawing.Size(550, 400);
            this.dgvGioHang.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(527, 505);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm vào giỏ";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(697, 505);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa khỏi giỏ";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(867, 505);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(150, 40);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(527, 560);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(104, 22);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.MistyRose;
            this.txtTongTien.Location = new System.Drawing.Point(637, 560);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(250, 22);
            this.txtTongTien.TabIndex = 9;
            // 
            // frmBanHang
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(247)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmBanHang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load_1);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tabMatHang.ResumeLayout(false);
            this.tabSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tabThuCung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            this.tabDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);

        }

    }
}
