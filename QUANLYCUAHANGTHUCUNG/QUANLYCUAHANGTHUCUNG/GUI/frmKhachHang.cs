// File: frmKhachHang.cs
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangThuCung.Class; // Cần đảm bảo có đủ các using cho các lớp BLL

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmKhachHang : Form
    {
        // Khai báo BLL
        KhachHangBLL khBLL = new KhachHangBLL();

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
        }

        // Hàm load dữ liệu lên DataGridView
        private void HienThiDanhSachKhachHang()
        {
            DataTable dt = khBLL.LoadTable();
            dgvKhachHang.DataSource = dt;
            LamMoiControls();
        }

        // Hàm xóa nội dung các TextBox
        private void LamMoiControls()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtDiemTL.Text = "0"; // Luôn hiển thị điểm tích lũy là 0 khi làm mới
            txtMaKH.Focus();
            txtMaKH.ReadOnly = false;
        }

        // ========== HÀM THAO TÁC CRUD ==========

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên Khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (khBLL.kiemtraMaKhachHang(maKH))
            {
                MessageBox.Show("Mã Khách hàng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Thêm KH mới, Điểm Tích Lũy mặc định là 0
                khBLL.themKH(maKH, tenKH, sdt, diaChi);
                MessageBox.Show("Thêm Khách hàng thành công.", "Thông báo");
                HienThiDanhSachKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            int diemTL;

            // Lấy Điểm Tích Lũy hiện tại (được hiển thị trong TextBox) để sửa
            if (!int.TryParse(txtDiemTL.Text, out diemTL))
            {
                MessageBox.Show("Điểm Tích Lũy không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!khBLL.kiemtraMaKhachHang(maKH))
            {
                MessageBox.Show("Mã Khách hàng không tồn tại để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Sửa Khách hàng
                khBLL.suaKH(maKH, tenKH, sdt, diaChi, diemTL);
                MessageBox.Show("Cập nhật Khách hàng thành công.", "Thông báo");
                HienThiDanhSachKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();

            if (!khBLL.kiemtraMaKhachHang(maKH))
            {
                MessageBox.Show("Vui lòng chọn Khách hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng {maKH}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    khBLL.xoaKH(maKH);
                    MessageBox.Show("Xóa Khách hàng thành công.", "Thông báo");
                    HienThiDanhSachKhachHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiControls();
        }

        // ========== XỬ LÝ SỰ KIỆN DATAGRIDVIEW ==========
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDiemTL.Text = row.Cells["DiemTichLuy"].Value.ToString();

                // Khóa Mã KH khi sửa
                txtMaKH.ReadOnly = true;
            }
        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}