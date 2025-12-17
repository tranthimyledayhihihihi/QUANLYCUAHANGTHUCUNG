using QuanLyCuaHangThuCung.Class;
using QuanLyCuaHangThuCung.GUI;
using System;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.Class
{
    class DoiMatKhau
    {
        // Khởi tạo thực thể lớp Đăng nhập để tái sử dụng logic kiểm tra
        DangNhap dn = new DangNhap();

        // ===================================================
        // 1) KIỂM TRA MẬT KHẨU CŨ
        // ===================================================
        public bool KiemTraMK(string matKhauCu)
        {
            // Kiểm tra xem mã nhân viên đã được gán tại Form Main chưa
            if (string.IsNullOrEmpty(frmMainNew.maNVMain))
            {
                MessageBox.Show("Lỗi hệ thống: Không xác định được phiên đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Trim để loại bỏ khoảng trắng thừa từ TextBox
            string maNV = frmMainNew.maNVMain.Trim();
            string mkCu = matKhauCu.Trim();

            return dn.kiemtraDangNhap(maNV, mkCu);
        }

        // ===================================================
        // 2) THỰC HIỆN ĐỔI MẬT KHẨU
        // ===================================================
        public void Doi(string matKhauMoi)
        {
            // Trim trước khi validate
            string matKhau = matKhauMoi?.Trim() ?? "";

            // Kiểm tra nếu mật khẩu mới không rỗng
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Mật khẩu mới không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mã nhân viên
            if (string.IsNullOrEmpty(frmMainNew.maNVMain))
            {
                MessageBox.Show("Lỗi hệ thống: Không xác định được phiên đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maNV = frmMainNew.maNVMain.Trim();

            // Cập nhật mật khẩu mới (đã được trim)
            dn.DoiMatKhau(maNV, matKhau);

            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ===================================================
        // 3) ĐỔI MẬT KHẨU KHI QUÊN
        // ===================================================
        public void DoiMatKhauKhiQuen(string MaNhanVien, string MatKhauMoi)
        {
            // Trim để loại bỏ khoảng trắng
            string maNV = MaNhanVien?.Trim() ?? "";
            string matKhau = MatKhauMoi?.Trim() ?? "";

            // Kiểm tra xem tài khoản có tồn tại không
            if (!dn.kiemtraTonTaiTK(maNV))
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mật khẩu mới không trống
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Mật khẩu mới không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đổi mật khẩu mới
            dn.DoiMatKhau(maNV, matKhau);

            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}