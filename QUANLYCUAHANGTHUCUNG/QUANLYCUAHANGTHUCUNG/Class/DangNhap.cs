using System.Collections.Generic;
using System.Linq;

namespace QuanLyThuCung.Class
{
    public class DangNhap
    {
        // Hàm kiểm tra đăng nhập
        public bool KiemTraDangNhap(string user, string pass)
        {
            // 1. Đọc danh sách nhân viên từ XML
            List<NhanVien> listNV = FileXml.DocFile<NhanVien>("NhanVien.xml");

            // 2. Tìm người có User và Pass trùng khớp
            var nv = listNV.FirstOrDefault(x => x.MaNhanVien == user && x.MatKhau == pass);

            if (nv != null)
            {
                // 3. Lưu vào hệ thống để nhớ ai đang dùng
                HeThong.NhanVienDangNhap = nv;
                return true;
            }
            return false;
        }
    }
}