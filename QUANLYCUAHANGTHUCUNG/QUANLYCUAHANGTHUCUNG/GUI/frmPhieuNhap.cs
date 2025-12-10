using System;
using System.Data;
using System.Linq;
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
        }

        private void LoadData()
        {
            dgvPhieuNhap.DataSource = Fxml.HienThi("PhieuNhap.xml");
        }

        private void TaoMaPhieuTuDong()
        {
            txtMaPhieu.Text = pnBLL.LayMaPhieuTiepTheo().ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboLoaiMatHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại mặt hàng SP hoặc TC!");
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn phiếu nhập cần xóa!");
                return;
            }

            string maPhieu = dgvPhieuNhap.SelectedRows[0].Cells["MaPhieu"].Value.ToString();

            if (!pnBLL.kiemtraMaPhieu(maPhieu))
            {
                MessageBox.Show("Mã phiếu không tồn tại!");
                return;
            }

            pnBLL.xoaPN(maPhieu);
            MessageBox.Show("Đã xóa phiếu nhập!");

            LoadData();
            TaoMaPhieuTuDong();
        }
    }
}
