using System;

namespace QuanLyThuCung.Class
{
    public class PhieuNhap
    {
        // Khớp với bảng PhieuNhap trong SQL
        public int MaPhieu { get; set; } // Tự tăng trong logic xử lý
        public string MaMatHang { get; set; } // Mã của Sản phẩm hoặc Thú cưng
        public string LoaiMatHang { get; set; } // "SP" hoặc "TC"
        public string MaNhanVien { get; set; } // Người nhập
        public int SoLuongNhap { get; set; }
        public DateTime NgayLapPhieu { get; set; }

        // Constructor không tham số (Bắt buộc để Serialize XML)
        public PhieuNhap() { }

        // Constructor đầy đủ (để dễ tạo mới)
        public PhieuNhap(int ma, string maHang, string loai, string maNV, int sl, DateTime ngay)
        {
            this.MaPhieu = ma;
            this.MaMatHang = maHang;
            this.LoaiMatHang = loai;
            this.MaNhanVien = maNV;
            this.SoLuongNhap = sl;
            this.NgayLapPhieu = ngay;
        }
    }
}