namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlHangHoa = new System.Windows.Forms.TabControl();
            this.tabThuCung = new System.Windows.Forms.TabPage();
            this.dgvThuCung = new System.Windows.Forms.DataGridView();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.colMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlThanhToan = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoaGioHang = new System.Windows.Forms.Button();
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlHangHoa.SuspendLayout();
            this.tabThuCung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            this.tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tabDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnlThanhToan.SuspendLayout();
            this.grpKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlHangHoa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvGioHang);
            this.splitContainer1.Panel2.Controls.Add(this.pnlThanhToan);
            this.splitContainer1.Panel2.Controls.Add(this.grpKhachHang);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 700);
            this.splitContainer1.SplitterDistance = 700;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControlHangHoa
            // 
            this.tabControlHangHoa.Controls.Add(this.tabThuCung);
            this.tabControlHangHoa.Controls.Add(this.tabSanPham);
            this.tabControlHangHoa.Controls.Add(this.tabDichVu);
            this.tabControlHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControlHangHoa.Location = new System.Drawing.Point(0, 0);
            this.tabControlHangHoa.Name = "tabControlHangHoa";
            this.tabControlHangHoa.SelectedIndex = 0;
            this.tabControlHangHoa.Size = new System.Drawing.Size(700, 700);
            this.tabControlHangHoa.TabIndex = 0;
            // 
            // tabThuCung
            // 
            this.tabThuCung.Controls.Add(this.dgvThuCung);
            this.tabThuCung.Location = new System.Drawing.Point(4, 29);
            this.tabThuCung.Name = "tabThuCung";
            this.tabThuCung.Padding = new System.Windows.Forms.Padding(3);
            this.tabThuCung.Size = new System.Drawing.Size(692, 667);
            this.tabThuCung.Text = "Thú Cưng";
            this.tabThuCung.UseVisualStyleBackColor = true;
            // 
            // dgvThuCung
            // 
            this.dgvThuCung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuCung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.ReadOnly = true;
            this.dgvThuCung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuCung.TabIndex = 0;
            this.dgvThuCung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuCung_CellClick);
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.dgvSanPham);
            this.tabSanPham.Location = new System.Drawing.Point(4, 29);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanPham.Size = new System.Drawing.Size(692, 667);
            this.tabSanPham.Text = "Sản Phẩm";
            this.tabSanPham.UseVisualStyleBackColor = true;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.dgvDichVu);
            this.tabDichVu.Location = new System.Drawing.Point(4, 29);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDichVu.Size = new System.Drawing.Size(692, 667);
            this.tabDichVu.Text = "Dịch Vụ";
            this.tabDichVu.UseVisualStyleBackColor = true;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.TabIndex = 0;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHang,
            this.colTenHang,
            this.colLoaiHang,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.Location = new System.Drawing.Point(0, 100);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(496, 450);
            this.dgvGioHang.TabIndex = 1;
            // 
            // colMaHang
            // 
            this.colMaHang.HeaderText = "Mã";
            this.colMaHang.Name = "colMaHang";
            this.colMaHang.Visible = false;
            // 
            // colTenHang
            // 
            this.colTenHang.HeaderText = "Tên Hàng";
            this.colTenHang.Name = "colTenHang";
            // 
            // colLoaiHang
            // 
            this.colLoaiHang.HeaderText = "Loại";
            this.colLoaiHang.Name = "colLoaiHang";
            this.colLoaiHang.Visible = false;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FillWeight = 40F;
            this.colSoLuong.HeaderText = "SL";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            // 
            // pnlThanhToan
            // 
            this.pnlThanhToan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlThanhToan.Controls.Add(this.lblTongTien);
            this.pnlThanhToan.Controls.Add(this.labelTotal);
            this.pnlThanhToan.Controls.Add(this.btnThanhToan);
            this.pnlThanhToan.Controls.Add(this.btnXoaGioHang);
            this.pnlThanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThanhToan.Location = new System.Drawing.Point(0, 550);
            this.pnlThanhToan.Name = "pnlThanhToan";
            this.pnlThanhToan.Size = new System.Drawing.Size(496, 150);
            this.pnlThanhToan.TabIndex = 2;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(160, 15);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(103, 31);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotal.Location = new System.Drawing.Point(20, 20);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(133, 25);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "TỔNG TIỀN:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(25, 70);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(300, 50);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoaGioHang
            // 
            this.btnXoaGioHang.Location = new System.Drawing.Point(340, 70);
            this.btnXoaGioHang.Name = "btnXoaGioHang";
            this.btnXoaGioHang.Size = new System.Drawing.Size(120, 50);
            this.btnXoaGioHang.TabIndex = 1;
            this.btnXoaGioHang.Text = "Xóa dòng";
            this.btnXoaGioHang.UseVisualStyleBackColor = true;
            this.btnXoaGioHang.Click += new System.EventHandler(this.btnXoaGioHang_Click);
            // 
            // grpKhachHang
            // 
            this.grpKhachHang.Controls.Add(this.txtMaKhach);
            this.grpKhachHang.Controls.Add(this.txtTenKhach);
            this.grpKhachHang.Controls.Add(this.btnTimKH);
            this.grpKhachHang.Controls.Add(this.txtSDT);
            this.grpKhachHang.Controls.Add(this.label1);
            this.grpKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpKhachHang.Location = new System.Drawing.Point(0, 0);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.Size = new System.Drawing.Size(496, 100);
            this.grpKhachHang.TabIndex = 0;
            this.grpKhachHang.TabStop = false;
            this.grpKhachHang.Text = "Thông tin khách hàng";
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(320, 65);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.ReadOnly = true;
            this.txtMaKhach.Size = new System.Drawing.Size(50, 26);
            this.txtMaKhach.TabIndex = 4;
            this.txtMaKhach.Visible = false;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(70, 65);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.ReadOnly = true;
            this.txtTenKhach.Size = new System.Drawing.Size(240, 26);
            this.txtTenKhach.TabIndex = 3;
            this.txtTenKhach.Text = "Khách vãng lai";
            // 
            // btnTimKH
            // 
            this.btnTimKH.Location = new System.Drawing.Point(230, 25);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(80, 30);
            this.btnTimKH.TabIndex = 2;
            this.btnTimKH.Text = "Tìm";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(70, 27);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(150, 26);
            this.txtSDT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.Text = "SĐT:";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmBanHang";
            this.Text = "Quản Lý Bán Hàng & Dịch Vụ";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControlHangHoa.ResumeLayout(false);
            this.tabThuCung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            this.tabSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tabDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.pnlThanhToan.ResumeLayout(false);
            this.pnlThanhToan.PerformLayout();
            this.grpKhachHang.ResumeLayout(false);
            this.grpKhachHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlHangHoa;
        private System.Windows.Forms.TabPage tabThuCung;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.TabPage tabDichVu;
        private System.Windows.Forms.DataGridView dgvThuCung;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Panel pnlThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoaGioHang;
        private System.Windows.Forms.GroupBox grpKhachHang;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
    }
}