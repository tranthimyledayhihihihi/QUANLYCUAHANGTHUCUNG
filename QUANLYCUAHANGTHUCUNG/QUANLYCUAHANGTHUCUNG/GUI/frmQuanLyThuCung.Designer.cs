// frmQuanLyThuCung.Designer.cs
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).BeginInit();
            this.SuspendLayout();

            // dgvThuCung
            this.dgvThuCung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuCung.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvThuCung.Location = new System.Drawing.Point(0, 0);
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.ReadOnly = true;
            this.dgvThuCung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuCung.Size = new System.Drawing.Size(700, 700);
            this.dgvThuCung.TabIndex = 0;
            this.dgvThuCung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuCung_CellClick);

            // groupBox1
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cboNCC);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numGiaBan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numGiaNhap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGiong);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboLoai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(700, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 700);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "Thông tin thú cưng";

            // btnLamMoi
            this.btnLamMoi.Location = new System.Drawing.Point(292, 620);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(79, 50);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(202, 620);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 50);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnSua
            this.btnSua.Location = new System.Drawing.Point(112, 620);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 50);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(22, 620);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 50);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // cboNCC
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.Location = new System.Drawing.Point(140, 560);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(230, 28);

            // label9
            this.label9.Location = new System.Drawing.Point(22, 564);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 29);
            this.label9.Text = "NCC:";

            // cboTrangThai
            this.cboTrangThai.Location = new System.Drawing.Point(140, 510);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(230, 28);

            // label8
            this.label8.Location = new System.Drawing.Point(22, 514);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 29);
            this.label8.Text = "Trạng thái:";

            // numGiaBan
            this.numGiaBan.Location = new System.Drawing.Point(140, 460);
            this.numGiaBan.Maximum = 100000000;
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(231, 26);

            // label7
            this.label7.Location = new System.Drawing.Point(22, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 29);
            this.label7.Text = "Giá bán:";

            // numGiaNhap
            this.numGiaNhap.Location = new System.Drawing.Point(140, 410);
            this.numGiaNhap.Maximum = 100000000;
            this.numGiaNhap.Name = "numGiaNhap";
            this.numGiaNhap.Size = new System.Drawing.Size(231, 26);

            // label6
            this.label6.Location = new System.Drawing.Point(22, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 29);
            this.label6.Text = "Giá nhập:";

            // dtpNgaySinh
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(140, 360);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(230, 26);

            // label5
            this.label5.Location = new System.Drawing.Point(22, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.Text = "Ngày sinh:";

            // cboGioiTinh
            this.cboGioiTinh.Location = new System.Drawing.Point(140, 310);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(230, 28);

            // label4
            this.label4.Location = new System.Drawing.Point(22, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.Text = "Giới tính:";

            // txtGiong
            this.txtGiong.Location = new System.Drawing.Point(140, 260);
            this.txtGiong.Name = "txtGiong";
            this.txtGiong.Size = new System.Drawing.Size(230, 26);

            // label10
            this.label10.Location = new System.Drawing.Point(22, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 29);
            this.label10.Text = "Giống:";

            // cboLoai
            this.cboLoai.Location = new System.Drawing.Point(140, 210);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(230, 28);

            // label3
            this.label3.Location = new System.Drawing.Point(22, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.Text = "Loại:";

            // txtTenTC
            this.txtTenTC.Location = new System.Drawing.Point(140, 110);
            this.txtTenTC.Multiline = true;
            this.txtTenTC.Size = new System.Drawing.Size(230, 80);

            // label2
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.Text = "Tên:";

            // txtMaTC
            this.txtMaTC.Location = new System.Drawing.Point(140, 60);
            this.txtMaTC.Name = "txtMaTC";
            this.txtMaTC.Size = new System.Drawing.Size(230, 26);

            // label1
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.Text = "Mã:";

            // frmQuanLyThuCung
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThuCung);
            this.Name = "frmQuanLyThuCung";
            this.Text = "Quản Lý Kho Thú Cưng";
            this.Load += new System.EventHandler(this.frmQuanLyThuCung_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTC;
        private System.Windows.Forms.Label label1;
    }
}
