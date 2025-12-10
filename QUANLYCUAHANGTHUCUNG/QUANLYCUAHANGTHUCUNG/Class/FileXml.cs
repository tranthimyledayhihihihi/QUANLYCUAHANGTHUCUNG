using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyCuaHangThuCung.Class
{
    class FileXml
    {
        // ====== CHUỖI KẾT NỐI DATABASE ====== 
        string Conn = @"Data Source=DESKTOP-7F1S7RF\SQLEXPRESS02;Initial Catalog=QuanLyCuaHangThuCung;Integrated Security=True";

        // ====== ĐƯỜNG DẪN THƯ MỤC DATA XML ======
        private string DataPath => Application.StartupPath + "\\Data\\";

        // ================================================================
        // 1. HIỂN THỊ XML (TRẢ VỀ DATATABLE)
        // ================================================================
        public DataTable HienThi(string file)
        {
            string filePath = DataPath + file;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File XML '" + file + "' không tồn tại!");
                return new DataTable();
            }

            DataSet ds = new DataSet();
            ds.ReadXml(filePath);

            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("File XML '" + file + "' rỗng hoặc sai cấu trúc!");
                return new DataTable();
            }

            return ds.Tables[0];
        }

        // ================================================================
        // 2. TẠO XML TỪ DATABASE
        // ================================================================
        public void TaoXML(string bang)
        {
            SqlConnection con = new SqlConnection(Conn);
            con.Open();

            string sql = "SELECT * FROM " + bang;
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable(bang);

            ad.Fill(dt);

            dt.WriteXml(DataPath + bang + ".xml", XmlWriteMode.WriteSchema);

            con.Close();
        }

        // ================================================================
        // 3. THÊM NODE VÀO XML
        // ================================================================
        public void Them(string file, string noiDung)
        {
            string filePath = DataPath + file;

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlDocumentFragment frag = doc.CreateDocumentFragment();
            frag.InnerXml = noiDung;

            XmlNode root = doc.DocumentElement;
            root.AppendChild(frag);

            doc.Save(filePath);
        }

        // ================================================================
        // 4. XÓA NODE XML
        // ================================================================
        public void Xoa(string file, string tenNode, string xoaTheoTruong, string giaTri)
        {
            string filePath = DataPath + file;

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode node = doc.SelectSingleNode($"NewDataSet/{tenNode}[{xoaTheoTruong}='{giaTri}']");

            if (node != null)
            {
                doc.DocumentElement.RemoveChild(node);
                doc.Save(filePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy node để xóa!");
            }
        }

        // ================================================================
        // 5. SỬA NODE XML
        // ================================================================
        public void Sua(string file, string tenNode, string suaTheoTruong, string giaTri, string noiDung)
        {
            string filePath = DataPath + file;

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode oldNode = doc.SelectSingleNode($"NewDataSet/{tenNode}[{suaTheoTruong}='{giaTri}']");

            if (oldNode != null)
            {
                XmlElement newNode = doc.CreateElement(tenNode);
                newNode.InnerXml = noiDung;

                doc.DocumentElement.ReplaceChild(newNode, oldNode);
                doc.Save(filePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy node để sửa!");
            }
        }

        // ================================================================
        // 6. LẤY GIÁ TRỊ TRường B TỪ TRường A
        // ================================================================
        public string LayGiaTri(string file, string truongA, string giaTriA, string truongB)
        {
            DataTable dt = HienThi(file);

            foreach (DataRow r in dt.Rows)
            {
                if (r[truongA].ToString().Trim() == giaTriA)
                {
                    return r[truongB].ToString();
                }
            }

            return "";
        }

        // ================================================================
        // 7. ĐỔI MẬT KHẨU TRONG XML
        // ================================================================
        public void DoiMatKhau(string maNhanVien, string matKhau)
        {
            string filePath = DataPath + "TaiKhoan.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode node = doc.SelectSingleNode($"NewDataSet/TaiKhoan[MaNhanVien='{maNhanVien}']");

            if (node != null)
            {
                node["MatKhau"].InnerText = matKhau;
                doc.Save(filePath);
            }
        }


        // ****************************************************************
        // 8. TỰ ĐỘNG LOẠI BỎ CÁC CỘT IDENTITY
        // ****************************************************************
        private string RemoveIdentityColumns(string sql)
        {
            string[] identityCols =
            {
                "SoHoaDon",  // Hóa đơn
                "Id",        // Chi tiết hóa đơn
                "MaPhieu",   // Phiếu nhập
                "MaLichHen"  // Lịch hẹn
            };

            foreach (string col in identityCols)
            {
                // Nếu INSERT đang cố chèn identity
                if (sql.Contains(col))
                {
                    // Xóa đoạn "col, "
                    sql = System.Text.RegularExpressions.Regex.Replace(
                        sql,
                        $@"\b{col}\b\s*,?", "",
                        System.Text.RegularExpressions.RegexOptions.IgnoreCase
                    );

                    // Xóa luôn giá trị tương ứng trong VALUES
                    sql = System.Text.RegularExpressions.Regex.Replace(
                        sql,
                        @"\(\s*([^\)]*)\)",
                        m =>
                        {
                            var parts = m.Groups[1].Value.Split(',');
                            if (parts.Length > 0)
                            {
                                // bỏ phần tử đầu (tương ứng identity)
                                return "(" + string.Join(",", parts.Skip(1)) + ")";
                            }
                            return m.Value;
                        });
                }
            }

            return sql;
        }

        // ****************************************************************
        // 9. THỰC THI LỆNH SQL (CÓ LOẠI BỎ IDENTITY)
        // ****************************************************************
        public void InsertOrUpDateSQL(string sql)
        {
            // Auto xử lý bỏ identity
            sql = RemoveIdentityColumns(sql);

            SqlConnection con = new SqlConnection(Conn);
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message + "\n\nLệnh chạy:\n" + sql);
            }

            con.Close();
        }

        // ================================================================
        // 10. KIỂM TRA KẾT NỐI SQL
        // ================================================================
        public bool KiemTraKetNoi()
        {
            try
            {
                SqlConnection con = new SqlConnection(Conn);
                con.Open();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối database: " + ex.Message);
                return false;
            }
        }

        // ================================================================
        // 11. LẤY DATA TỪ SQL
        // ================================================================
        public DataTable LayDuLieuSQL(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection con = new SqlConnection(Conn);
                con.Open();

                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                ad.Fill(dt);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }

            return dt;
        }
    }
}
