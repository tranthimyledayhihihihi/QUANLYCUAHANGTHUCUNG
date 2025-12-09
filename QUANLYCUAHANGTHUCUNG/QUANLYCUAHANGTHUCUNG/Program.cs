using QuanLyCuaHangThuCung.GUI;
using QuanLyThuCung.Class; // Nhớ đảm bảo namespace này đúng với project của bạn
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuCung
{
    static class Program
    {
        public static object HeThong { get; internal set; }
        public static object MaNhanVienHienTai { get; internal set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // TaoDuLieuMau();  <-- Comment dòng này lại (thêm // ở đầu)

            // Mở dòng này ra để chạy Form Đăng Nhập
            Application.Run(new frmDangNhap());
        }
    }
}