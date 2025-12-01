namespace QuanLyThuCung.Class
{
    public class HeThong
    {
        // Biến static để lưu nhân viên đang đăng nhập, truy cập từ mọi Form
        public static NhanVien NhanVienDangNhap { get; set; } = null;
    }
}