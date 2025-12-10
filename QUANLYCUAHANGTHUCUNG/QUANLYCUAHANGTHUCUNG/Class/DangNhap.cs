using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyCuaHangThuCung.Class
{
    class DangNhap
    {
        FileXml Fxml = new FileXml();

        // ===== ĐƯỜNG DẪN FILE XML =====
        private string TaiKhoanPath => Application.StartupPath + "\\Data\\TaiKhoan.xml";


        // =============================
        // LẤY MÃ QUYỀN (CHƯA DÙNG)
        // =============================
        public void layMaQuyen()
        {
            if (!System.IO.File.Exists(TaiKhoanPath))
            {
                MessageBox.Show("Không tìm thấy TaiKhoan.xml");
                return;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(TaiKhoanPath);

            XmlNode nodeMQ = doc.SelectSingleNode("NewDataSet/TaiKhoan/Quyen");
        }


        // ==================================
        // KIỂM TRA ĐĂNG NHẬP (gọi từ Form)
        // ==================================
        public bool kiemtraDangNhap(string MaNhanVien, string MatKhau)
        {
            return kiemtraTTDN("TaiKhoan.xml", MaNhanVien, MatKhau);
        }


        // ==========================================================
        // LẤY THÔNG TIN NGƯỜI DÙNG (Mã NV + Quyền)
        // ==========================================================
        public (string MaNhanVien, int Quyen) layThongTinNguoiDung(string maNV)
        {
            if (!System.IO.File.Exists(TaiKhoanPath))
            {
                MessageBox.Show("Không tìm thấy file TaiKhoan.xml");
                return ("", 0);
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(TaiKhoanPath);

            XmlNode node = doc.SelectSingleNode($"NewDataSet/TaiKhoan[MaNhanVien='{maNV}']");

            if (node == null)
                return ("", 0);

            string manv = node["MaNhanVien"]?.InnerText ?? "";
            int quyen = int.TryParse(node["Quyen"]?.InnerText, out int q) ? q : 0;

            return (manv, quyen);
        }


        // ================================
        // ĐĂNG KÝ TÀI KHOẢN
        // ================================
        public void dangkiTaiKhoan(string MaNhanVien, string MatKhau, int Quyen)
        {
            string noiDung =
                "<TaiKhoan>" +
                    "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>" +
                    "<MatKhau>" + MatKhau + "</MatKhau>" +
                    "<Quyen>" + Quyen + "</Quyen>" +
                "</TaiKhoan>";

            Fxml.Them("TaiKhoan.xml", noiDung);
        }


        // ================================
        // XÓA TÀI KHOẢN
        // ================================
        public void xoaTK(string MaNhanVien)
        {
            Fxml.Xoa("TaiKhoan.xml", "TaiKhoan", "MaNhanVien", MaNhanVien);
        }


        // ================================
        // KIỂM TRA TỒN TẠI TÀI KHOẢN
        // ================================
        public bool kiemtraTTTK(string MaNhanVien)
        {
            if (!System.IO.File.Exists(TaiKhoanPath))
                return false;

            XmlDocument doc = new XmlDocument();
            doc.Load(TaiKhoanPath);

            XmlNode node = doc.SelectSingleNode($"NewDataSet/TaiKhoan[MaNhanVien='{MaNhanVien}']");
            return node != null;
        }


        // ================================
        // ĐỔI MẬT KHẨU
        // ================================
        public void DoiMatKhau(string nguoiDung, string matKhau)
        {
            if (!System.IO.File.Exists(TaiKhoanPath))
            {
                MessageBox.Show("Không tìm thấy TaiKhoan.xml");
                return;
            }

            XmlDocument doc1 = new XmlDocument();
            doc1.Load(TaiKhoanPath);

            XmlNode node1 = doc1.SelectSingleNode($"NewDataSet/TaiKhoan[MaNhanVien='{nguoiDung}']");

            if (node1 != null)
            {
                node1["MatKhau"].InnerText = matKhau;
                doc1.Save(TaiKhoanPath);
            }
        }


        // ======================================================
        // KIỂM TRA THÔNG TIN ĐĂNG NHẬP (MaNV + MatKhau)
        // ======================================================
        public bool kiemtraTTDN(string fileXML, string MaNhanVien, string MatKhau)
        {
            DataTable dt = Fxml.HienThi(fileXML);

            // ⚠ KIỂM TRA TRƯỚC KHI LỌC
            if (dt == null || dt.Columns.Count == 0)
            {
                MessageBox.Show("File " + fileXML + " rỗng hoặc sai cấu trúc!");
                return false;
            }

            // ⚠ Tên cột phải đúng như XML
            if (!dt.Columns.Contains("MaNhanVien") || !dt.Columns.Contains("MatKhau"))
            {
                MessageBox.Show("Cấu trúc XML không có cột MaNhanVien hoặc MatKhau!");
                return false;
            }

            // Lọc đúng cách
            dt.DefaultView.RowFilter =
                $"MaNhanVien = '{MaNhanVien}' AND MatKhau = '{MatKhau}'";

            return dt.DefaultView.Count > 0;
        }
    }
}
