namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmQuanLySanPham
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            this.SuspendLayout();

            // dgvSanPham
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(600, 500);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);

            // groupBox1
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cboNCC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numSoLuong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numGiaBan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDVT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboLoaiSP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(600, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";

            // Controls
            this.label1.Location = new System.Drawing.Point(20, 40); this.label1.Text = "Mã SP:";
            this.txtMaSP.Location = new System.Drawing.Point(100, 37); this.txtMaSP.Size = new System.Drawing.Size(200, 22);

            this.label2.Location = new System.Drawing.Point(20, 80); this.label2.Text = "Tên SP:";
            this.txtTenSP.Location = new System.Drawing.Point(100, 77); this.txtTenSP.Size = new System.Drawing.Size(200, 22);

            this.label3.Location = new System.Drawing.Point(20, 120); this.label3.Text = "Loại:";
            this.cboLoaiSP.Items.AddRange(new object[] { "Thức ăn", "Đồ chơi", "Thuốc", "Phụ kiện" });
            this.cboLoaiSP.Location = new System.Drawing.Point(100, 117); this.cboLoaiSP.Size = new System.Drawing.Size(200, 24);

            this.label4.Location = new System.Drawing.Point(20, 160); this.label4.Text = "Đơn vị:";
            this.txtDVT.Location = new System.Drawing.Point(100, 157); this.txtDVT.Size = new System.Drawing.Size(200, 22);

            this.label5.Location = new System.Drawing.Point(20, 200); this.label5.Text = "Giá bán:";
            this.numGiaBan.Location = new System.Drawing.Point(100, 197); this.numGiaBan.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 }); this.numGiaBan.Size = new System.Drawing.Size(200, 22);

            this.label6.Location = new System.Drawing.Point(20, 240); this.label6.Text = "Tồn kho:";
            this.numSoLuong.Location = new System.Drawing.Point(100, 237); this.numSoLuong.Maximum = new decimal(new int[] { 10000, 0, 0, 0 }); this.numSoLuong.Size = new System.Drawing.Size(200, 22);

            this.label7.Location = new System.Drawing.Point(20, 280); this.label7.Text = "NCC:";
            this.cboNCC.Location = new System.Drawing.Point(100, 277); this.cboNCC.Size = new System.Drawing.Size(200, 24);
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Buttons
            this.btnThem.Text = "Thêm"; this.btnThem.Location = new System.Drawing.Point(20, 330); this.btnThem.Size = new System.Drawing.Size(70, 40);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Text = "Sửa"; this.btnSua.Location = new System.Drawing.Point(100, 330); this.btnSua.Size = new System.Drawing.Size(70, 40);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Text = "Xóa"; this.btnXoa.Location = new System.Drawing.Point(180, 330); this.btnXoa.Size = new System.Drawing.Size(70, 40);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.Text = "Mới"; this.btnLamMoi.Location = new System.Drawing.Point(260, 330); this.btnLamMoi.Size = new System.Drawing.Size(70, 40);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSanPham);
            this.Name = "frmQuanLySanPham";
            this.Text = "Quản Lý Kho Sản Phẩm";
            this.Load += new System.EventHandler(this.frmQuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label1;
    }
}