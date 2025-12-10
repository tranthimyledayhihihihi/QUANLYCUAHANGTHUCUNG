using System.Data;
using System.Linq;
using System.Xml;

namespace QuanLyCuaHangThuCung.Class
{
    class NhaCungCap
    {
        FileXml Fxml = new FileXml();

        // 1. Kiểm tra Mã NCC có tồn tại không
        public bool kiemtraMaNCC(string MaNCC)
        {
            // Dùng luôn LayGiaTri (nó đã gọi HienThi("NhaCungCap.xml") => Data\NhaCungCap.xml)
            string giaTri = Fxml.LayGiaTri("NhaCungCap.xml", "MaNCC", MaNCC, "MaNCC");
            return !string.IsNullOrEmpty(giaTri);
        }

        // 2. Thêm NCC
        public void themNCC(string MaNCC, string TenNCC, string DiaChi, string SDT, string Email, string MoTa)
        {
            string noiDung =
                "<NhaCungCap>" +
                    "<MaNCC>" + MaNCC + "</MaNCC>" +
                    "<TenNCC>" + TenNCC + "</TenNCC>" +
                    "<DiaChi>" + DiaChi + "</DiaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>" +
                    "<MoTa>" + MoTa + "</MoTa>" +
                "</NhaCungCap>";

            // Them() hiện đang nhận đường dẫn *thô*, nên truyền luôn kèm Data\
            Fxml.Them("Data\\NhaCungCap.xml", noiDung);
        }

        // 3. Sửa NCC
        public void suaNCC(string MaNCC, string TenNCC, string DiaChi, string SDT, string Email, string MoTa)
        {
            string noiDung =
                "<MaNCC>" + MaNCC + "</MaNCC>" +
                "<TenNCC>" + TenNCC + "</TenNCC>" +
                "<DiaChi>" + DiaChi + "</DiaChi>" +
                "<SDT>" + SDT + "</SDT>" +
                "<Email>" + Email + "</Email>" +
                "<MoTa>" + MoTa + "</MoTa>";

            // Sua() cũng đang dùng đường dẫn trực tiếp
            Fxml.Sua("Data\\NhaCungCap.xml", "NhaCungCap", "MaNCC", MaNCC, noiDung);
        }

        // 4. Xóa NCC
        public void xoaNCC(string MaNCC)
        {
            // Xoa() bên FileXml đã tự thêm Application.StartupPath + "\\Data\\"
            Fxml.Xoa("NhaCungCap.xml", "NhaCungCap", "MaNCC", MaNCC);
        }

        // 5. Load danh sách NCC (để bind combobox, grid...)
        public DataTable LoadMaNCC()
        {
            return Fxml.HienThi("NhaCungCap.xml");
        }

        // 6. Load bảng NCC, thay MaNCC bằng TenNCC nếu cần hiển thị tên
        public DataTable LoadTable()
        {
            DataTable dt = Fxml.HienThi("NhaCungCap.xml");
            DataTable dtNCC = LoadMaNCC();

            int soDong = dtNCC.Rows.Count;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < soDong; j++)
                {
                    if (dt.Rows[i]["MaNCC"].ToString() == dtNCC.Rows[j]["MaNCC"].ToString())
                    {
                        dt.Rows[i]["MaNCC"] = dtNCC.Rows[j]["TenNCC"];
                        break;
                    }
                }
            }

            return dt;
        }
    }
}
