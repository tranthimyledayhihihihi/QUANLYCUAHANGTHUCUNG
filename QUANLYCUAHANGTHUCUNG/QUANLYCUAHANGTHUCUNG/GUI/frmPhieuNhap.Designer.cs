namespace QuanLyCuaHangThuCung
{
    partial class frmPhieuNhap
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// cleanup
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboLoaiMatHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaMatHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();

            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();

            // grpThongTin
            this.grpThongTin.Controls.Add(this.label8);
            this.grpThongTin.Controls.Add(this.txtMaPhieu);
            this.grpThongTin.Controls.Add(this.cboLoaiMatHang);
            this.grpThongTin.Controls.Add(this.label6);
            this.grpThongTin.Controls.Add(this.txtMaMatHang);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Controls.Add(this.txtMaNhanVien);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.numSoLuong);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.dtNgayLap);
            this.grpThongTin.Controls.Add(this.label4);

            this.grpThongTin.Location = new System.Drawing.Point(20, 20);
            this.grpThongTin.Size = new System.Drawing.Size(600, 200);
            this.grpThongTin.Text = "Thông tin phiếu nhập";

            // txtMaPhieu
            this.txtMaPhieu.Location = new System.Drawing.Point(120, 30);
            this.txtMaPhieu.ReadOnly = true;
            this.label8.Text = "Mã Phiếu:";
            this.label8.Location = new System.Drawing.Point(20, 35);

            // cboLoaiMatHang
            this.cboLoaiMatHang.Items.AddRange(new object[] { "SP", "TC" });
            this.cboLoaiMatHang.Location = new System.Drawing.Point(420, 30);
            this.cboLoaiMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.label6.Text = "Loại mặt hàng:";
            this.label6.Location = new System.Drawing.Point(320, 35);

            // txtMaMatHang
            this.txtMaMatHang.Location = new System.Drawing.Point(120, 70);
            this.label1.Text = "Mã mặt hàng:";
            this.label1.Location = new System.Drawing.Point(20, 75);

            // txtMaNhanVien
            this.txtMaNhanVien.Location = new System.Drawing.Point(420, 70);
            this.label2.Text = "Mã nhân viên:";
            this.label2.Location = new System.Drawing.Point(320, 75);

            // numSoLuong
            this.numSoLuong.Location = new System.Drawing.Point(120, 110);
            this.numSoLuong.Minimum = 1;
            this.numSoLuong.Maximum = 99999;
            this.label3.Text = "Số lượng:";
            this.label3.Location = new System.Drawing.Point(20, 115);

            // dtNgayLap
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayLap.Location = new System.Drawing.Point(420, 110);
            this.label4.Text = "Ngày lập:";
            this.label4.Location = new System.Drawing.Point(320, 115);

            // BUTTONS
            this.btnThem.Text = "Thêm Phiếu Nhập";
            this.btnThem.Location = new System.Drawing.Point(650, 40);
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnXoa.Text = "Xóa Phiếu";
            this.btnXoa.Location = new System.Drawing.Point(650, 100);
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // dgvPhieuNhap
            this.dgvPhieuNhap.Location = new System.Drawing.Point(20, 240);
            this.dgvPhieuNhap.Size = new System.Drawing.Size(780, 300);
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.label7.Text = "Danh sách phiếu nhập";
            this.label7.Location = new System.Drawing.Point(20, 220);

            // frmPhieuNhap
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvPhieuNhap);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phiếu Nhập";

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMatHang;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboLoaiMatHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label8;
    }
}
