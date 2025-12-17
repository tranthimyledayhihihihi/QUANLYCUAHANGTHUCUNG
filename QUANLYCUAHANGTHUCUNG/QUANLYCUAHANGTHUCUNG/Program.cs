using QuanLyCuaHangThuCung.GUI;
using System;
using System.Windows.Forms;

namespace QuanLyThuCung
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chạy form đăng nhập
            Application.Run(new frmDangNhap());
        }
    }
}
