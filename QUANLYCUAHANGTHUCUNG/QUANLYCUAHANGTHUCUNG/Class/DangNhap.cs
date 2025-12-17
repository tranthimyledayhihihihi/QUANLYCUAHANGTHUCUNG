using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace QuanLyCuaHangThuCung.Class
{
    class DangNhap
    {
        FileXml Fxml = new FileXml();

        // Đường dẫn đến file dữ liệu tài khoản
        private string TaiKhoanPath => Application.StartupPath + "\\Data\\TaiKhoan.xml";

        // ==========================================================
        // 1) KIỂM TRA ĐĂNG NHẬP (Kết quả: Đúng/Sai)
        // ==========================================================
        public bool kiemtraDangNhap(string MaNhanVien, string MatKhau)
        {
            DataTable dt = Fxml.HienThi("TaiKhoan.xml");

            if (dt == null || dt.Columns.Count == 0)
            {
                return false;
            }

            // Trim input trước khi kiểm tra (xử lý khoảng trắng từ TextBox)
            string maNV = MaNhanVien?.Trim() ?? "";
            string matKhau = MatKhau?.Trim() ?? "";

            // SỬ DỤNG LINQ để so sánh
            var result = dt.AsEnumerable().FirstOrDefault(row =>
            {
                string maNVXml = row["MaNhanVien"]?.ToString()?.Trim() ?? "";
                string matKhauXml = row["MatKhau"]?.ToString()?.Trim() ?? "";

                return maNVXml == maNV && matKhauXml == matKhau;
            });

            return result != null;
        }

        // ==========================================================
        // 2) LẤY THÔNG TIN NGƯỜI DÙNG (Để phân quyền GUI)
        // Trả về: Mã NV, Tên NV, và Quyền (1 hoặc 0)
        // ==========================================================
        public (string MaNhanVien, string TenNhanVien, int Quyen) layThongTinNguoiDung(string user)
        {
            DataTable dtNV = Fxml.HienThi("NhanVien.xml");
            DataTable dtTK = Fxml.HienThi("TaiKhoan.xml");

            if (dtNV == null || dtTK == null) return ("", "", 0);

            string maNV = user?.Trim() ?? "";

            // Tìm thông tin tài khoản để lấy Quyền
            DataRow tk = dtTK.AsEnumerable().FirstOrDefault(r =>
                (r["MaNhanVien"]?.ToString()?.Trim() ?? "") == maNV);
            if (tk == null) return ("", "", 0);

            int quyen = 0;
            int.TryParse(tk["Quyen"].ToString(), out quyen);

            // Tìm thông tin nhân viên để lấy Tên hiển thị
            DataRow nv = dtNV.AsEnumerable().FirstOrDefault(r =>
                (r["MaNhanVien"]?.ToString()?.Trim() ?? "") == maNV);
            string tenNV = nv != null ? (nv["TenNhanVien"]?.ToString()?.Trim() ?? "N/A") : "N/A";

            return (maNV, tenNV, quyen);
        }

        // ==========================================================
        // 3) QUẢN LÝ TÀI KHOẢN (Chỉ dành cho Admin gọi)
        // ==========================================================

        // Thêm tài khoản mới
        public void dangkiTaiKhoan(string MaNhanVien, string MatKhau, int Quyen)
        {
            // QUAN TRỌNG: Trim trước khi lưu vào XML
            string maNV = MaNhanVien?.Trim() ?? "";
            string matKhau = MatKhau?.Trim() ?? "";

            string noiDung =
                "<TaiKhoan>" +
                    "<MaNhanVien>" + maNV + "</MaNhanVien>" +
                    "<MatKhau>" + matKhau + "</MatKhau>" +
                    "<Quyen>" + Quyen + "</Quyen>" +
                "</TaiKhoan>";

            Fxml.Them("TaiKhoan.xml", noiDung);
        }

        // Xóa tài khoản
        public void xoaTK(string MaNhanVien)
        {
            string maNV = MaNhanVien?.Trim() ?? "";
            Fxml.Xoa("TaiKhoan.xml", "TaiKhoan", "MaNhanVien", maNV);
        }

        // Đổi mật khẩu
        public void DoiMatKhau(string nguoiDung, string matKhauMoi)
        {
            if (!File.Exists(TaiKhoanPath)) return;

            // QUAN TRỌNG: Trim trước khi lưu vào XML
            string maNV = nguoiDung?.Trim() ?? "";
            string matKhau = matKhauMoi?.Trim() ?? "";

            XmlDocument doc = new XmlDocument();
            doc.Load(TaiKhoanPath);

            // Tìm node với trim để đảm bảo tìm đúng
            XmlNodeList nodes = doc.SelectNodes("NewDataSet/TaiKhoan");
            foreach (XmlNode node in nodes)
            {
                string maNVNode = node["MaNhanVien"]?.InnerText?.Trim() ?? "";
                if (maNVNode == maNV)
                {
                    node["MatKhau"].InnerText = matKhau;
                    doc.Save(TaiKhoanPath);
                    break;
                }
            }
        }

        // Kiểm tra tài khoản đã tồn tại chưa
        public bool kiemtraTonTaiTK(string MaNhanVien)
        {
            if (!File.Exists(TaiKhoanPath)) return false;

            string maNV = MaNhanVien?.Trim() ?? "";

            XmlDocument doc = new XmlDocument();
            doc.Load(TaiKhoanPath);

            XmlNodeList nodes = doc.SelectNodes("NewDataSet/TaiKhoan");
            foreach (XmlNode node in nodes)
            {
                string maNVNode = node["MaNhanVien"]?.InnerText?.Trim() ?? "";
                if (maNVNode == maNV)
                {
                    return true;
                }
            }

            return false;
        }

        // ==========================================================
        // 4) QUÊN MẬT KHẨU: LẤY MẬT KHẨU KHI NGƯỜI DÙNG QUÊN
        // ==========================================================
        public string LayMatKhau(string MaNhanVien)
        {
            if (!File.Exists(TaiKhoanPath)) return "";

            string maNV = MaNhanVien?.Trim() ?? "";

            XmlDocument doc = new XmlDocument();
            doc.Load(TaiKhoanPath);

            XmlNodeList nodes = doc.SelectNodes("NewDataSet/TaiKhoan");
            foreach (XmlNode node in nodes)
            {
                string maNVNode = node["MaNhanVien"]?.InnerText?.Trim() ?? "";
                if (maNVNode == maNV)
                {
                    return node["MatKhau"]?.InnerText?.Trim() ?? "";
                }
            }

            return "";
        }

        // ==========================================================
        // 5) ĐỔI MẬT KHẨU KHI NGƯỜI DÙNG QUÊN MẬT KHẨU
        // ==========================================================
        public void DoiMatKhauKhiQuen(string MaNhanVien, string MatKhauMoi)
        {
            string maNV = MaNhanVien?.Trim() ?? "";
            string matKhau = MatKhauMoi?.Trim() ?? "";

            // Kiểm tra xem tài khoản có tồn tại không
            if (!kiemtraTonTaiTK(maNV))
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Đổi mật khẩu mới
            DoiMatKhau(maNV, matKhau);
        }
    }
}