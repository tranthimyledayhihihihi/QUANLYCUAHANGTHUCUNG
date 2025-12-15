using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangThuCung.Class;

namespace QuanLyCuaHangThuCung
{
    public partial class frmPhieuNhap : Form
    {
        PhieuNhap pnBLL = new PhieuNhap();
        FileXml Fxml = new FileXml();

        public frmPhieuNhap()
        {
            InitializeComponent();

            LoadData();
            TaoMaPhieuTuDong();

            // ⭐ BẮT BUỘC: gán CellClick
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
        }

        // ============================
        // LOAD DỮ LIỆU
        // ============================
        private void LoadData()
        {
            DataTable dt = Fxml.HienThi("PhieuNhap.xml");
            dgvPhieuNhap.DataSource = dt;

            dgvPhieuNhap.ClearSelection();
        }

        // ============================
        // TẠO MÃ PHIẾU TỰ ĐỘNG
        // ============================
        private void TaoMaPhieuTuDong()
        {
            txtMaPhieu.Text = pnBLL.LayMaPhieuTiepTheo().ToString();
        }

        // ============================
        // CLICK DÒNG → ĐỔ DỮ LIỆU
        // ============================
        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];

            txtMaPhieu.Text = row.Cells["MaPhieu"].Value.ToString();
            txtMaMatHang.Text = row.Cells["MaMatHang"].Value.ToString();
            cboLoaiMatHang.Text = row.Cells["LoaiMatHang"].Value.ToString();
            txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();

            numSoLuong.Value = Convert.ToInt32(row.Cells["SoLuongNhap"].Value);

            DateTime ngayLap;
            if (DateTime.TryParse(row.Cells["NgayLapPhieu"].Value.ToString(), out ngayLap))
                dtNgayLap.Value = ngayLap;
            else
                dtNgayLap.Value = DateTime.Now;
        }

        // ============================
        // THÊM PHIẾU NHẬP
        // ============================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboLoaiMatHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại mặt hàng!");
                return;
            }

            if (txtMaMatHang.Text == "" || txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã mặt hàng và mã nhân viên!");
                return;
            }

            pnBLL.themPN(
                txtMaMatHang.Text,
                cboLoaiMatHang.Text,
                txtMaNhanVien.Text,
                (int)numSoLuong.Value,
                dtNgayLap.Value.ToString("yyyy-MM-dd")
            );

            MessageBox.Show("Thêm phiếu nhập thành công!");

            LoadData();
            TaoMaPhieuTuDong();
            LamMoi();
        }

        // ============================
        // XÓA PHIẾU NHẬP
        // ============================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn phiếu nhập cần xóa!");
                return;
            }

            string maPhieu =
                dgvPhieuNhap.SelectedRows[0].Cells["MaPhieu"].Value.ToString();

            if (!pnBLL.kiemtraMaPhieu(maPhieu))
            {
                MessageBox.Show("Mã phiếu không tồn tại!");
                return;
            }

            pnBLL.xoaPN(maPhieu);
            MessageBox.Show("Đã xóa phiếu nhập!");

            LoadData();
            TaoMaPhieuTuDong();
            LamMoi();
        }

        // ============================
        // LÀM MỚI FORM
        // ============================
        private void LamMoi()
        {
            txtMaMatHang.Clear();
            txtMaNhanVien.Clear();
            cboLoaiMatHang.SelectedIndex = -1;
            numSoLuong.Value = 1;
            dtNgayLap.Value = DateTime.Now;
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
