using System;
using System.Collections.Generic; // Để dùng List

namespace QuanLyThuCung.Class
{
    public class HoaDon
    {
        // Khớp với bảng HoaDon trong SQL
        public int SoHoaDon { get; set; }
        public string MaNhanVien { get; set; }
        public string MaKhachHang { get; set; }
        public DateTime NgayLap { get; set; }
        public int TongTien { get; set; }

        // Mở rộng: Một hóa đơn thường đi kèm danh sách chi tiết (mua những gì)
        // Trong XML, ta có thể lồng danh sách chi tiết vào trong Hóa đơn luôn cho tiện
        public List<ChiTietHoaDon> DanhSachChiTiet { get; set; } = new List<ChiTietHoaDon>();

        public HoaDon() { }
    }

    // Class phụ hỗ trợ cho Hóa Đơn (bạn có thể để chung file HoaDon.cs hoặc tách ra)
    public class ChiTietHoaDon
    {
        public string MaMatHang { get; set; } // Mã SP, TC, DV
        public string LoaiMatHang { get; set; } // "SP", "TC", "DV"
        public string TenMatHang { get; set; } // Lưu thêm tên để hiển thị cho dễ
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien => SoLuong * DonGia; // Tự tính toán
    }
}