namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmQuanLyThuCung
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
            this.dgvThuCung = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            this.SuspendLayout();

            // dgvThuCung
            this.dgvThuCung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuCung.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvThuCung.Location = new System.Drawing.Point(0, 0);
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.ReadOnly = true;
            this.dgvThuCung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuCung.Size = new System.Drawing.Size(600, 500);
            this.dgvThuCung.TabIndex = 0;
            this.dgvThuCung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuCung_CellClick);

            // groupBox1
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cboNCC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numGiaBan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGiong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboLoai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(600, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thú cưng";

            // Controls
            this.label1.Location = new System.Drawing.Point(20, 40); this.label1.Text = "Mã:";
            this.txtMaTC.Location = new System.Drawing.Point(100, 37); this.txtMaTC.Size = new System.Drawing.Size(200, 22);

            this.label2.Location = new System.Drawing.Point(20, 80); this.label2.Text = "Tên:";
            this.txtTenTC.Location = new System.Drawing.Point(100, 77); this.txtTenTC.Size = new System.Drawing.Size(200, 22);

            this.label3.Location = new System.Drawing.Point(20, 120); this.label3.Text = "Loại:";
            this.cboLoai.Items.AddRange(new object[] { "Chó", "Mèo", "Khác" });
            this.cboLoai.Location = new System.Drawing.Point(100, 117); this.cboLoai.Size = new System.Drawing.Size(200, 24);

            this.label4.Location = new System.Drawing.Point(20, 160); this.label4.Text = "Giống:";
            this.txtGiong.Location = new System.Drawing.Point(100, 157); this.txtGiong.Size = new System.Drawing.Size(200, 22);

            this.label5.Location = new System.Drawing.Point(20, 200); this.label5.Text = "Giá bán:";
            this.numGiaBan.Location = new System.Drawing.Point(100, 197); this.numGiaBan.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 }); this.numGiaBan.Size = new System.Drawing.Size(200, 22);

            this.label6.Location = new System.Drawing.Point(20, 240); this.label6.Text = "Trạng thái:";
            this.cboTrangThai.Items.AddRange(new object[] { "Còn hàng", "Đã bán", "Đang ốm" });
            this.cboTrangThai.Location = new System.Drawing.Point(100, 237); this.cboTrangThai.Size = new System.Drawing.Size(200, 24);

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
            this.Controls.Add(this.dgvThuCung);
            this.Name = "frmQuanLyThuCung";
            this.Text = "Quản Lý Kho Thú Cưng";
            this.Load += new System.EventHandler(this.frmQuanLyThuCung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThuCung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTC;
        private System.Windows.Forms.Label label1;
    }
}