namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmQuanLySanPham
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label lblTieuDe;

        // Controls nhập liệu
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.Label lblMaNCC;

        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.ComboBox cboMaNCC;

        // Controls chức năng
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

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
            // ===============================================
            // KHỞI TẠO TẤT CẢ CONTROLS
            // ===============================================
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();

            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblDonGiaBan = new System.Windows.Forms.Label();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();

            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();

            // ===============================================
            // LABEL TIÊU ĐỀ
            // ===============================================
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Padding = new System.Windows.Forms.Padding(10);
            this.lblTieuDe.Size = new System.Drawing.Size(1000, 60);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "📦 QUẢN LÝ DANH MỤC SẢN PHẨM";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ===============================================
            // PANEL CONTROLS
            // ===============================================
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 60);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1000, 220);
            this.pnlControls.TabIndex = 1;

            // ===============================================
            // LABELS - DÒNG 1
            // ===============================================
            // lblMaSP
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaSP.Location = new System.Drawing.Point(30, 20);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(50, 20);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã SP:";

            // lblLoaiSP
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoaiSP.Location = new System.Drawing.Point(380, 20);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(60, 20);
            this.lblLoaiSP.TabIndex = 1;
            this.lblLoaiSP.Text = "Loại SP:";

            // lblDonGiaBan
            this.lblDonGiaBan.AutoSize = true;
            this.lblDonGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDonGiaBan.Location = new System.Drawing.Point(680, 20);
            this.lblDonGiaBan.Name = "lblDonGiaBan";
            this.lblDonGiaBan.Size = new System.Drawing.Size(95, 20);
            this.lblDonGiaBan.TabIndex = 2;
            this.lblDonGiaBan.Text = "Đơn Giá Bán:";

            // ===============================================
            // LABELS - DÒNG 2
            // ===============================================
            // lblTenSP
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenSP.Location = new System.Drawing.Point(30, 55);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(55, 20);
            this.lblTenSP.TabIndex = 3;
            this.lblTenSP.Text = "Tên SP:";

            // lblDonViTinh
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDonViTinh.Location = new System.Drawing.Point(380, 55);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(85, 20);
            this.lblDonViTinh.TabIndex = 4;
            this.lblDonViTinh.Text = "Đơn vị tính:";

            // lblSoLuongTon
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongTon.Location = new System.Drawing.Point(680, 55);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(105, 20);
            this.lblSoLuongTon.TabIndex = 5;
            this.lblSoLuongTon.Text = "Số Lượng Tồn:";

            // ===============================================
            // LABELS - DÒNG 3
            // ===============================================
            // lblMaNCC
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaNCC.Location = new System.Drawing.Point(30, 90);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(65, 20);
            this.lblMaNCC.TabIndex = 6;
            this.lblMaNCC.Text = "Mã NCC:";

            // ===============================================
            // TEXTBOXES - DÒNG 1
            // ===============================================
            // txtMaSP
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSP.Location = new System.Drawing.Point(160, 17);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(180, 27);
            this.txtMaSP.TabIndex = 7;

            // txtDonGiaBan
            this.txtDonGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonGiaBan.Location = new System.Drawing.Point(790, 17);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(150, 27);
            this.txtDonGiaBan.TabIndex = 9;
            this.txtDonGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // ===============================================
            // TEXTBOXES - DÒNG 2
            // ===============================================
            // txtTenSP
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenSP.Location = new System.Drawing.Point(160, 52);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(180, 27);
            this.txtTenSP.TabIndex = 10;

            // txtDonViTinh
            this.txtDonViTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonViTinh.Location = new System.Drawing.Point(520, 52);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(150, 27);
            this.txtDonViTinh.TabIndex = 11;

            // txtSoLuongTon
            this.txtSoLuongTon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuongTon.Location = new System.Drawing.Point(790, 52);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(150, 27);
            this.txtSoLuongTon.TabIndex = 12;
            this.txtSoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // ===============================================
            // COMBOBOXES
            // ===============================================
            // cboLoaiSP
            this.cboLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Items.AddRange(new object[] {
                "Thức ăn",
                "Đồ chơi",
                "Thuốc",
                "Phụ kiện",
                "Khác"
            });
            this.cboLoaiSP.Location = new System.Drawing.Point(520, 17);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(150, 28);
            this.cboLoaiSP.TabIndex = 8;

            // cboMaNCC
            this.cboMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(160, 87);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(180, 28);
            this.cboMaNCC.TabIndex = 13;

            // ===============================================
            // BUTTONS
            // ===============================================
            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.Teal;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(30, 150);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.BackColor = System.Drawing.Color.Teal;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(140, 150);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.Salmon;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(250, 150);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(247)))), ((int)(((byte)(220)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(360, 150);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 17;
            this.btnLamMoi.Text = "🔄 Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // ===============================================
            // THÊM CONTROLS VÀO PANEL
            // ===============================================
            this.pnlControls.Controls.Add(this.lblMaSP);
            this.pnlControls.Controls.Add(this.lblTenSP);
            this.pnlControls.Controls.Add(this.lblLoaiSP);
            this.pnlControls.Controls.Add(this.lblDonViTinh);
            this.pnlControls.Controls.Add(this.lblDonGiaBan);
            this.pnlControls.Controls.Add(this.lblSoLuongTon);
            this.pnlControls.Controls.Add(this.lblMaNCC);
            this.pnlControls.Controls.Add(this.txtMaSP);
            this.pnlControls.Controls.Add(this.txtTenSP);
            this.pnlControls.Controls.Add(this.cboLoaiSP);
            this.pnlControls.Controls.Add(this.txtDonViTinh);
            this.pnlControls.Controls.Add(this.txtDonGiaBan);
            this.pnlControls.Controls.Add(this.txtSoLuongTon);
            this.pnlControls.Controls.Add(this.cboMaNCC);
            this.pnlControls.Controls.Add(this.btnThem);
            this.pnlControls.Controls.Add(this.btnSua);
            this.pnlControls.Controls.Add(this.btnXoa);
            this.pnlControls.Controls.Add(this.btnLamMoi);

            // ===============================================
            // DATAGRIDVIEW
            // ===============================================
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 280);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1000, 370);
            this.dgvSanPham.TabIndex = 2;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);

            // ===============================================
            // FORM
            // ===============================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sản phẩm - Cửa hàng Thú Cưng";
            this.Load += new System.EventHandler(this.frmQuanLySanPham_Load);

            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}