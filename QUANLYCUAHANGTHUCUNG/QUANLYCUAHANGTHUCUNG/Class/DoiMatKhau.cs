using System.Collections.Generic;
using System.Linq;

namespace QuanLyThuCung.Class
{
    public class DoiMatKhau
    {
        public bool LuuMatKhauMoi(string maNV, string matKhauMoi)
        {
            List<NhanVien> listNV = FileXml.DocFile<NhanVien>("NhanVien.xml");

            var nv = listNV.FirstOrDefault(x => x.MaNhanVien == maNV);
            if (nv != null)
            {
                nv.MatKhau = matKhauMoi;
                // Ghi đè lại file XML
                FileXml.GhiFile("NhanVien.xml", listNV);
                return true;
            }
            return false;
        }
    }
}