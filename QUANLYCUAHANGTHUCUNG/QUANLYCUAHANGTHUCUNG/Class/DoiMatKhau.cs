using QuanLyCuaHangThuCung.GUI;

namespace QuanLyCuaHangThuCung.Class
{
    class DoiMatKhau
    {
        DangNhap dn = new DangNhap();

        // ===================================
        // KIỂM TRA MẬT KHẨU CŨ
        // ===================================
        public bool KiemTraMK(string matKhauCu)
        {
            return dn.kiemtraTTDN(
                "TaiKhoan.xml",
                frmMainNew.maNVMain,   // ✅ ĐÚNG
                matKhauCu
            );
        }

        // ===================================
        // ĐỔI MẬT KHẨU
        // ===================================
        public void Doi(string matKhauMoi)
        {
            dn.DoiMatKhau(
                frmMainNew.maNVMain,   // ✅ ĐÚNG
                matKhauMoi
            );
        }
    }
}
