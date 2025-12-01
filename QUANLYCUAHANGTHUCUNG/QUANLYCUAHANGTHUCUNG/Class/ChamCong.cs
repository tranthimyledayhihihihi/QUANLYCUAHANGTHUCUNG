using System;

namespace QuanLyThuCung.Class
{
    public class ChamCong
    {
        public int Id { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime Ngay { get; set; }
        public string TrangThai { get; set; } // VD: Có mặt, Vắng, Đi trễ
    }
}