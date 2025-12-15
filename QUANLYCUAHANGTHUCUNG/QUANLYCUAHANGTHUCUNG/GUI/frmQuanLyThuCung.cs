using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmQuanLyThuCung : Form
    {
        private string xmlFilePath;
        private DataSet dsThuCung;

        public frmQuanLyThuCung()
        {
            InitializeComponent();

            xmlFilePath = Application.StartupPath + "\\ThuCung.xml";
            dsThuCung = new DataSet();

            ApplyColorTheme();
        }

        // ================================
        // GIAO DIỆN MÀU SẮC
        // ================================
        private void ApplyColorTheme()
        {
            this.BackColor = Color.White;

            groupBox1.BackColor = Color.FromArgb(253, 221, 230);
            groupBox1.ForeColor = Color.Black;

            dgvThuCung.BackgroundColor = Color.White;
            dgvThuCung.BorderStyle = BorderStyle.None;
            dgvThuCung.EnableHeadersVisualStyles = false;
            dgvThuCung.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 247, 220);
            dgvThuCung.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvThuCung.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvThuCung.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            dgvThuCung.ColumnHeadersHeight = 40;

            dgvThuCung.RowsDefaultCellStyle.BackColor = Color.White;
            dgvThuCung.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgvThuCung.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 247, 220);
            dgvThuCung.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dgvThuCung.RowTemplate.Height = 35;

            StyleButton(btnThem, Color.FromArgb(72, 201, 176));
            StyleButton(btnSua, Color.FromArgb(255, 193, 7));
            StyleButton(btnXoa, Color.FromArgb(244, 67, 54));
            StyleButton(btnLamMoi, Color.FromArgb(33, 150, 243));
        }

        private void StyleButton(Button btn, Color backColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = ControlPaint.Light(backColor, 0.2f);
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = backColor;
            };
        }

        // ================================
        // FORM LOAD
        // ================================
        private void frmQuanLyThuCung_Load(object sender, EventArgs e)
        {
            LoadThuCung();
            LoadNhaCungCap();
        }

        // ================================
        // LOAD DANH SÁCH THÚ CƯNG
        // ================================
        private void LoadThuCung()
        {
            try
            {
                if (!File.Exists(xmlFilePath))
                {
                    // Tạo file rỗng nếu mất file
                    DataSet ds = new DataSet("NewDataSet");
                    ds.Tables.Add("ThuCung");
                    ds.Tables["ThuCung"].Columns.Add("MaThuCung");
                    ds.Tables["ThuCung"].Columns.Add("TenThuCung");
                    ds.Tables["ThuCung"].Columns.Add("LoaiThuCung");
                    ds.Tables["ThuCung"].Columns.Add("Giong");
                    ds.Tables["ThuCung"].Columns.Add("GioiTinh");
                    ds.Tables["ThuCung"].Columns.Add("NgaySinh");
                    ds.Tables["ThuCung"].Columns.Add("GiaNhap");
                    ds.Tables["ThuCung"].Columns.Add("GiaBan");
                    ds.Tables["ThuCung"].Columns.Add("MaNCC");
                    ds.Tables["ThuCung"].Columns.Add("TrangThai");

                    ds.WriteXml(xmlFilePath, XmlWriteMode.WriteSchema);
                }

                dsThuCung.Clear();
                dsThuCung.ReadXml(xmlFilePath);

                dgvThuCung.DataSource = dsThuCung.Tables["ThuCung"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // ================================
        // LOAD NHÀ CUNG CẤP TỪ XML
        // ================================
        private void LoadNhaCungCap()
        {
            cboNCC.Items.Clear();

            string nccFile = Application.StartupPath + "\\NhaCungCap.xml";

            if (!File.Exists(nccFile))
                return;

            DataSet ds = new DataSet();
            ds.ReadXml(nccFile);

            if (ds.Tables.Contains("NhaCungCap"))
            {
                foreach (DataRow row in ds.Tables["NhaCungCap"].Rows)
                {
                    cboNCC.Items.Add(row["MaNCC"].ToString());
                }
            }
        }

        // ================================
        // CLICK ROW
        // ================================
        private void dgvThuCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRow row = dsThuCung.Tables["ThuCung"].Rows[e.RowIndex];

            txtMaTC.Text = row["MaThuCung"].ToString();
            txtTenTC.Text = row["TenThuCung"].ToString();
            cboLoai.Text = row["LoaiThuCung"].ToString();
            txtGiong.Text = row["Giong"].ToString();
            cboGioiTinh.Text = row["GioiTinh"].ToString();

            DateTime.TryParse(row["NgaySinh"].ToString(), out DateTime ngay);
            dtpNgaySinh.Value = ngay;

            numGiaNhap.Value = Convert.ToDecimal(row["GiaNhap"]);
            numGiaBan.Value = Convert.ToDecimal(row["GiaBan"]);

            cboNCC.Text = row["MaNCC"].ToString();
            cboTrangThai.Text = row["TrangThai"].ToString();
        }

        // ================================
        // THÊM
        // ================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTC.Text == "" || txtTenTC.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                DataRow newRow = dsThuCung.Tables["ThuCung"].NewRow();

                newRow["MaThuCung"] = txtMaTC.Text.Trim();
                newRow["TenThuCung"] = txtTenTC.Text.Trim();
                newRow["LoaiThuCung"] = cboLoai.Text;
                newRow["Giong"] = txtGiong.Text.Trim();
                newRow["GioiTinh"] = cboGioiTinh.Text;
                newRow["NgaySinh"] = dtpNgaySinh.Value.ToString("yyyy-MM-ddTHH:mm:sszzz");
                newRow["GiaNhap"] = (int)numGiaNhap.Value;
                newRow["GiaBan"] = (int)numGiaBan.Value;
                newRow["MaNCC"] = cboNCC.Text;
                newRow["TrangThai"] = cboTrangThai.Text;

                dsThuCung.Tables["ThuCung"].Rows.Add(newRow);
                dsThuCung.WriteXml(xmlFilePath);

                MessageBox.Show("Thêm thú cưng thành công!");
                LoadThuCung();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ================================
        // SỬA
        // ================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaTC.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thú cưng để sửa!");
                return;
            }

            DataRow[] rows = dsThuCung.Tables["ThuCung"].Select($"MaThuCung='{txtMaTC.Text}'");

            if (rows.Length == 0) return;

            DataRow r = rows[0];

            r["TenThuCung"] = txtTenTC.Text.Trim();
            r["LoaiThuCung"] = cboLoai.Text;
            r["Giong"] = txtGiong.Text.Trim();
            r["GioiTinh"] = cboGioiTinh.Text;
            r["NgaySinh"] = dtpNgaySinh.Value.ToString("yyyy-MM-ddTHH:mm:sszzz");
            r["GiaNhap"] = (int)numGiaNhap.Value;
            r["GiaBan"] = (int)numGiaBan.Value;
            r["MaNCC"] = cboNCC.Text;
            r["TrangThai"] = cboTrangThai.Text;

            dsThuCung.WriteXml(xmlFilePath);

            MessageBox.Show("Sửa thành công!");
            LoadThuCung();
            LamMoi();
        }

        // ================================
        // XÓA
        // ================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTC.Text == "")
            {
                MessageBox.Show("Chọn thú cưng cần xóa!");
                return;
            }

            DataRow[] rows = dsThuCung.Tables["ThuCung"].Select($"MaThuCung='{txtMaTC.Text}'");

            if (rows.Length > 0)
            {
                rows[0].Delete();
                dsThuCung.WriteXml(xmlFilePath);
                MessageBox.Show("Xóa thành công!");
                LoadThuCung();
                LamMoi();
            }
        }

        // ================================
        // LÀM MỚI
        // ================================
        private void btnLamMoi_Click(object sender, EventArgs e) => LamMoi();

        private void LamMoi()
        {
            txtMaTC.Clear();
            txtTenTC.Clear();
            txtGiong.Clear();
            cboLoai.SelectedIndex = -1;
            cboGioiTinh.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            cboNCC.SelectedIndex = -1;

            numGiaNhap.Value = 0;
            numGiaBan.Value = 0;
            dtpNgaySinh.Value = DateTime.Now;

            txtMaTC.Focus();
        }
    }
}
