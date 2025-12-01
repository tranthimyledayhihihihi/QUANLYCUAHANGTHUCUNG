using System;

namespace QuanLyThuCung.Class
{
    public class ThuCung
    {
        public string MaThuCung { get; set; }
        public string TenThuCung { get; set; }
        public string LoaiThuCung { get; set; } // Ví dụ: Chó, Mèo
        public string Giong { get; set; }       // Ví dụ: Poodle, Husky
        public string GioiTinh { get; set; }    // Đực, Cái
        public DateTime NgaySinh { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public string MaNCC { get; set; }

        // --- ĐÂY LÀ DÒNG BẠN ĐANG THIẾU ---
        public string TrangThai { get; set; }   // "Còn hàng", "Đã bán"
        // ----------------------------------

        public int SoLuong { get; set; }        // Thường là 1
    }
}