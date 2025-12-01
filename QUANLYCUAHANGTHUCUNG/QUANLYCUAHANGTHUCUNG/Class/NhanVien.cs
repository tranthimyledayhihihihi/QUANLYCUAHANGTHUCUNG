using System;

namespace QuanLyThuCung.Class
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        // Thêm thông tin tài khoản vào đây luôn cho tiện quản lý XML (Hoặc tách riêng tùy bạn)
        public string MatKhau { get; set; }
        public int Quyen { get; set; } // 1: Quản lý, 0: Nhân viên
    }
}