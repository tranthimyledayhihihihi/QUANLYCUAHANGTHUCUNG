
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;
    using System.Windows.Forms; // Để dùng Application.StartupPath

    namespace QuanLyThuCung.Class // Đổi namespace theo tên project của bạn
    {
        public class FileXml
        {
            // Hàm ghi dữ liệu vào file XML (Generic - dùng cho mọi đối tượng)
            public static void GhiFile<T>(string tenFile, List<T> danhSach)
            {
                try
                {
                    string path = Application.StartupPath + @"\Data\"; // Lưu vào thư mục Data trong bin/Debug
                    if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                    string filePath = path + tenFile;
                    XmlSerializer xml = new XmlSerializer(typeof(List<T>));
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        xml.Serialize(sw, danhSach);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            // Hàm đọc dữ liệu từ file XML
            public static List<T> DocFile<T>(string tenFile)
            {
                List<T> list = new List<T>();
                try
                {
                    string path = Application.StartupPath + @"\Data\" + tenFile;
                    if (File.Exists(path))
                    {
                        XmlSerializer xml = new XmlSerializer(typeof(List<T>));
                        using (StreamReader sr = new StreamReader(path))
                        {
                            list = (List<T>)xml.Deserialize(sr);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Nếu file lỗi hoặc chưa có, trả về list rỗng
                    return new List<T>();
                }
                return list;
            }
        }
    }
