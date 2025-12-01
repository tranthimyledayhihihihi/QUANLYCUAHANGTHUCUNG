using System;

namespace QuanLyCuaHangThuCung.Class // <--- Đảm bảo Namespace phải là TÊN PROJECT.Class
{
    public class LichHen
    {
        public int MaLichHen { get; set; } // Phải là public
        public string MaKhachHang { get; set; }
        public string MaDichVu { get; set; }
        public DateTime NgayHen { get; set; }
        public TimeSpan GioHen { get; set; } // Thời gian cần là TimeSpan
        public string TrangThai { get; set; }
    }
}