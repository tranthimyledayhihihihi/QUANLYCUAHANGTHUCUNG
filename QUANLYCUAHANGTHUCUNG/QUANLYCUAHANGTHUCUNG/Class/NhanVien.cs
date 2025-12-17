using System;
using System.Data;
using System.Xml;
using System.Windows.Forms;
using QuanLyCuaHangThuCung.GUI;

namespace QuanLyCuaHangThuCung.Class
{
    class NhanVien
    {
        FileXml Fxml = new FileXml();
        DangNhap dn = new DangNhap();

        // ===================================================
        // KIỂM TRA QUYỀN QUẢN LÝ (1 = Admin, 0 = Nhân viên)
        // ===================================================
        public bool KiemTraQuyenQuanLy()
        {
            // Lấy mã nhân viên từ session đăng nhập
            if (string.IsNullOrEmpty(frmMainNew.maNVMain))
            {
                MessageBox.Show("Lỗi hệ thống: Không xác định được phiên đăng nhập!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Lấy thông tin người dùng hiện tại
            var thongTin = dn.layThongTinNguoiDung(frmMainNew.maNVMain);

            // Kiểm tra quyền: 1 = Admin (được phép), 0 = Nhân viên (không được phép)
            if (thongTin.Quyen != 1)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này!\nChỉ quản lý mới có quyền thêm/sửa/xóa nhân viên.",
                    "Từ chối truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // ===================================================
        // 1) KIỂM TRA MÃ NHÂN VIÊN
        // ===================================================
        public bool kiemtra(string MaNhanVien)
        {
            string maNV = MaNhanVien?.Trim() ?? "";
            string v = Fxml.LayGiaTri("NhanVien.xml", "MaNhanVien", maNV, "MaNhanVien");
            return !string.IsNullOrEmpty(v);
        }

        // ===================================================
        // 2) THÊM NHÂN VIÊN (CHỈ ADMIN)
        // ===================================================
        public void themNV(string MaNhanVien, string TenNhanVien, string NgaySinh,
                           string DiaChi, string SDT, string Email)
        {
            // Kiểm tra quyền trước khi thực hiện
            if (!KiemTraQuyenQuanLy())
            {
                return;
            }

            // Trim dữ liệu trước khi lưu
            string maNV = MaNhanVien?.Trim() ?? "";
            string tenNV = TenNhanVien?.Trim() ?? "";
            string ngaySinh = NgaySinh?.Trim() ?? "";
            string diaChi = DiaChi?.Trim() ?? "";
            string sdt = SDT?.Trim() ?? "";
            string email = Email?.Trim() ?? "";

            string noiDung =
                "<NhanVien>" +
                "<MaNhanVien>" + maNV + "</MaNhanVien>" +
                "<TenNhanVien>" + tenNV + "</TenNhanVien>" +
                "<NgaySinh>" + ngaySinh + "</NgaySinh>" +
                "<DiaChi>" + diaChi + "</DiaChi>" +
                "<SDT>" + sdt + "</SDT>" +
                "<Email>" + email + "</Email>" +
                "</NhanVien>";

            Fxml.Them("NhanVien.xml", noiDung);
        }

        // ===================================================
        // 3) SỬA NHÂN VIÊN (CHỈ ADMIN)
        // ===================================================
        public void suaNV(string MaNhanVien, string TenNhanVien, string NgaySinh,
                          string DiaChi, string SDT, string Email)
        {
            // Kiểm tra quyền trước khi thực hiện
            if (!KiemTraQuyenQuanLy())
            {
                return;
            }

            // Trim dữ liệu trước khi lưu
            string maNV = MaNhanVien?.Trim() ?? "";
            string tenNV = TenNhanVien?.Trim() ?? "";
            string ngaySinh = NgaySinh?.Trim() ?? "";
            string diaChi = DiaChi?.Trim() ?? "";
            string sdt = SDT?.Trim() ?? "";
            string email = Email?.Trim() ?? "";

            string noiDung =
                "<MaNhanVien>" + maNV + "</MaNhanVien>" +
                "<TenNhanVien>" + tenNV + "</TenNhanVien>" +
                "<NgaySinh>" + ngaySinh + "</NgaySinh>" +
                "<DiaChi>" + diaChi + "</DiaChi>" +
                "<SDT>" + sdt + "</SDT>" +
                "<Email>" + email + "</Email>";

            Fxml.Sua("NhanVien.xml", "NhanVien", "MaNhanVien", maNV, noiDung);
        }

        // ===================================================
        // 4) XÓA NHÂN VIÊN (CHỈ ADMIN)
        // ===================================================
        public void xoaNV(string MaNhanVien)
        {
            // Kiểm tra quyền trước khi thực hiện
            if (!KiemTraQuyenQuanLy())
            {
                return;
            }

            string maNV = MaNhanVien?.Trim() ?? "";
            Fxml.Xoa("NhanVien.xml", "NhanVien", "MaNhanVien", maNV);
        }

        // ===================================================
        // 5) LOAD TOÀN BỘ NHÂN VIÊN (TẤT CẢ QUYỀN ĐỀU XEM ĐƯỢC)
        // ===================================================
        public DataTable LoadTable()
        {
            return Fxml.HienThi("NhanVien.xml");
        }

        // ===================================================
        // 6) KIỂM TRA QUYỀN CỦA NGƯỜI DÙNG HIỆN TẠI
        // Trả về: 1 = Admin, 0 = Nhân viên
        // ===================================================
        public int LayQuyenHienTai()
        {
            if (string.IsNullOrEmpty(frmMainNew.maNVMain))
            {
                return 0; // Mặc định là nhân viên nếu không xác định được
            }

            var thongTin = dn.layThongTinNguoiDung(frmMainNew.maNVMain);
            return thongTin.Quyen;
        }
    }
}