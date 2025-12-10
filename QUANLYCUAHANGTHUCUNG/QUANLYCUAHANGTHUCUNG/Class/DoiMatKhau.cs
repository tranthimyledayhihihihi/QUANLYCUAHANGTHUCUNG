using QuanLyCuaHangThuCung.GUI;
using System;

namespace QuanLyCuaHangThuCung.Class
{
    class DoiMatKhau
    {
        DangNhap dn = new DangNhap();

        /// <summary>
        /// Kiểm tra mật khẩu cũ có đúng với tài khoản đang đăng nhập hay không.
        /// </summary>
        public bool KiemTraMK(string matKhauCu)
        {
            // Đọc đúng file Data/TaiKhoan.xml
            return dn.kiemtraTTDN("TaiKhoan.xml",
                                  frmMainNew.tenDNMain,
                                  matKhauCu);
        }

        /// <summary>
        /// Đổi mật khẩu sang giá trị mới cho tài khoản hiện tại.
        /// </summary>
        public void Doi(string matKhauMoi)
        {
            dn.DoiMatKhau(frmMainNew.tenDNMain, matKhauMoi);
        }
    }
}
