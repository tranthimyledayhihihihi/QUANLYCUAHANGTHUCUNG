namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmLichHen
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.DataGridView dgvLichHen;
        private System.Windows.Forms.Label lblTieuDe;

        // Controls nhập liệu
        private System.Windows.Forms.Label lblMaLichHen;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label lblMaDichVu;
        private System.Windows.Forms.Label lblNgayHen;
        private System.Windows.Forms.Label lblGioHen;
        private System.Windows.Forms.Label lblTrangThai;

        private System.Windows.Forms.TextBox txtMaLichHen;
        private System.Windows.Forms.ComboBox cboMaKhachHang;
        private System.Windows.Forms.ComboBox cboMaDichVu;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.ComboBox cboGioHen;
        private System.Windows.Forms.ComboBox cboTrangThai;

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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblMaLichHen = new System.Windows.Forms.Label();
            this.txtMaLichHen = new System.Windows.Forms.TextBox();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.cboMaKhachHang = new System.Windows.Forms.ComboBox();
            this.lblMaDichVu = new System.Windows.Forms.Label();
            this.cboMaDichVu = new System.Windows.Forms.ComboBox();
            this.lblNgayHen = new System.Windows.Forms.Label();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.lblGioHen = new System.Windows.Forms.Label();
            this.cboGioHen = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvLichHen = new System.Windows.Forms.DataGridView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.pnlControls.Controls.Add(this.lblMaLichHen);
            this.pnlControls.Controls.Add(this.txtMaLichHen);
            this.pnlControls.Controls.Add(this.lblMaKhachHang);
            this.pnlControls.Controls.Add(this.cboMaKhachHang);
            this.pnlControls.Controls.Add(this.lblMaDichVu);
            this.pnlControls.Controls.Add(this.cboMaDichVu);
            this.pnlControls.Controls.Add(this.lblNgayHen);
            this.pnlControls.Controls.Add(this.dtpNgayHen);
            this.pnlControls.Controls.Add(this.lblGioHen);
            this.pnlControls.Controls.Add(this.cboGioHen);
            this.pnlControls.Controls.Add(this.lblTrangThai);
            this.pnlControls.Controls.Add(this.cboTrangThai);
            this.pnlControls.Controls.Add(this.btnThem);
            this.pnlControls.Controls.Add(this.btnSua);
            this.pnlControls.Controls.Add(this.btnXoa);
            this.pnlControls.Controls.Add(this.btnLamMoi);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 75);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1125, 275);
            this.pnlControls.TabIndex = 1;
            this.pnlControls.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControls_Paint);
            // 
            // lblMaLichHen
            // 
            this.lblMaLichHen.AutoSize = true;
            this.lblMaLichHen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaLichHen.Location = new System.Drawing.Point(34, 38);
            this.lblMaLichHen.Name = "lblMaLichHen";
            this.lblMaLichHen.Size = new System.Drawing.Size(116, 25);
            this.lblMaLichHen.TabIndex = 0;
            this.lblMaLichHen.Text = "Mã lịch hẹn:";
            // 
            // txtMaLichHen
            // 
            this.txtMaLichHen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtMaLichHen.Location = new System.Drawing.Point(169, 38);
            this.txtMaLichHen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLichHen.Name = "txtMaLichHen";
            this.txtMaLichHen.ReadOnly = true;
            this.txtMaLichHen.Size = new System.Drawing.Size(168, 26);
            this.txtMaLichHen.TabIndex = 1;
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaKhachHang.Location = new System.Drawing.Point(394, 38);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(118, 25);
            this.lblMaKhachHang.TabIndex = 2;
            this.lblMaKhachHang.Text = "Khách hàng:";
            // 
            // cboMaKhachHang
            // 
            this.cboMaKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKhachHang.FormattingEnabled = true;
            this.cboMaKhachHang.Location = new System.Drawing.Point(529, 38);
            this.cboMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaKhachHang.Name = "cboMaKhachHang";
            this.cboMaKhachHang.Size = new System.Drawing.Size(281, 28);
            this.cboMaKhachHang.TabIndex = 3;
            this.cboMaKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboMaKhachHang_SelectedIndexChanged);
            // 
            // lblMaDichVu
            // 
            this.lblMaDichVu.AutoSize = true;
            this.lblMaDichVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaDichVu.Location = new System.Drawing.Point(34, 88);
            this.lblMaDichVu.Name = "lblMaDichVu";
            this.lblMaDichVu.Size = new System.Drawing.Size(81, 25);
            this.lblMaDichVu.TabIndex = 4;
            this.lblMaDichVu.Text = "Dịch vụ:";
            // 
            // cboMaDichVu
            // 
            this.cboMaDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaDichVu.FormattingEnabled = true;
            this.cboMaDichVu.Location = new System.Drawing.Point(169, 88);
            this.cboMaDichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaDichVu.Name = "cboMaDichVu";
            this.cboMaDichVu.Size = new System.Drawing.Size(281, 28);
            this.cboMaDichVu.TabIndex = 5;
            // 
            // lblNgayHen
            // 
            this.lblNgayHen.AutoSize = true;
            this.lblNgayHen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNgayHen.Location = new System.Drawing.Point(529, 88);
            this.lblNgayHen.Name = "lblNgayHen";
            this.lblNgayHen.Size = new System.Drawing.Size(99, 25);
            this.lblNgayHen.TabIndex = 6;
            this.lblNgayHen.Text = "Ngày hẹn:";
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHen.Location = new System.Drawing.Point(641, 88);
            this.dtpNgayHen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(168, 26);
            this.dtpNgayHen.TabIndex = 7;
            // 
            // lblGioHen
            // 
            this.lblGioHen.AutoSize = true;
            this.lblGioHen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGioHen.Location = new System.Drawing.Point(34, 138);
            this.lblGioHen.Name = "lblGioHen";
            this.lblGioHen.Size = new System.Drawing.Size(83, 25);
            this.lblGioHen.TabIndex = 8;
            this.lblGioHen.Text = "Giờ hẹn:";
            // 
            // cboGioHen
            // 
            this.cboGioHen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioHen.FormattingEnabled = true;
            this.cboGioHen.Location = new System.Drawing.Point(169, 138);
            this.cboGioHen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGioHen.Name = "cboGioHen";
            this.cboGioHen.Size = new System.Drawing.Size(168, 28);
            this.cboGioHen.TabIndex = 9;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.Location = new System.Drawing.Point(394, 138);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(104, 25);
            this.lblTrangThai.TabIndex = 10;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(529, 138);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(224, 28);
            this.cboTrangThai.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(45, 206);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 50);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(202, 206);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 50);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(360, 206);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 50);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(518, 206);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(135, 50);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "🔄 Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvLichHen
            // 
            this.dgvLichHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichHen.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHen.Location = new System.Drawing.Point(0, 350);
            this.dgvLichHen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvLichHen.Name = "dgvLichHen";
            this.dgvLichHen.ReadOnly = true;
            this.dgvLichHen.RowHeadersWidth = 51;
            this.dgvLichHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichHen.Size = new System.Drawing.Size(1125, 462);
            this.dgvLichHen.TabIndex = 2;
            this.dgvLichHen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichHen_CellClick);
            this.dgvLichHen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichHen_CellContentClick);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblTieuDe.Size = new System.Drawing.Size(1125, 75);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "📅 QUẢN LÝ LỊCH HẸN DỊCH VỤ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 812);
            this.Controls.Add(this.dgvLichHen);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.lblTieuDe);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLichHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Lịch Hẹn";
            this.Load += new System.EventHandler(this.frmLichHen_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}