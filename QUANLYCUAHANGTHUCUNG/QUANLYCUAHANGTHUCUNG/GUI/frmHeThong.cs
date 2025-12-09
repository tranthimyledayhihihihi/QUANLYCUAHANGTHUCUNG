using System;
using System.IO; // Thư viện quan trọng để xử lý File và Thư mục
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmHeThong : Form
    {
        // Đường dẫn thư mục chứa dữ liệu hiện tại (bin/Debug/Data)
        string dataPath = Application.StartupPath + @"\Data";

        public frmHeThong()
        {
            InitializeComponent();
        }

        // --- 1. CHỨC NĂNG SAO LƯU (BACKUP) ---
        // Logic: Copy toàn bộ file .xml trong thư mục Data ra một thư mục do người dùng chọn
        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem thư mục Data có tồn tại không
            if (!Directory.Exists(dataPath))
            {
                MessageBox.Show("Không tìm thấy thư mục dữ liệu nguồn!");
                return;
            }

            // Cho người dùng chọn thư mục để lưu backup
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Chọn thư mục để lưu bản Sao lưu";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Tạo thư mục con có tên theo ngày giờ: VD "Backup_20231025_120000"
                    string folderName = "Backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string destPath = Path.Combine(fbd.SelectedPath, folderName);

                    // Tạo thư mục đích
                    Directory.CreateDirectory(destPath);

                    // Lấy tất cả file .xml trong thư mục nguồn
                    string[] files = Directory.GetFiles(dataPath, "*.xml");

                    foreach (string file in files)
                    {
                        // Tên file + đuôi (VD: NhanVien.xml)
                        string name = Path.GetFileName(file);
                        // Đường dẫn đích
                        string dest = Path.Combine(destPath, name);
                        // Copy file
                        File.Copy(file, dest, true);
                    }

                    MessageBox.Show($"Sao lưu thành công!\nDữ liệu đã được lưu tại:\n{destPath}", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sao lưu: " + ex.Message);
                }
            }
        }

        // --- 2. CHỨC NĂNG PHỤC HỒI (RESTORE) ---
        // Logic: Người dùng chọn thư mục chứa backup, phần mềm sẽ copy đè vào thư mục Data
        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Chọn thư mục chứa bản Backup (Thư mục có chứa các file .xml)";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sourceBackupPath = fbd.SelectedPath;

                // Kiểm tra sơ bộ xem thư mục này có đúng là backup không (có file NhanVien.xml không?)
                if (!File.Exists(Path.Combine(sourceBackupPath, "NhanVien.xml")))
                {
                    MessageBox.Show("Thư mục đã chọn không chứa dữ liệu hợp lệ (Thiếu file NhanVien.xml)!", "Cảnh báo");
                    return;
                }

                if (MessageBox.Show("Cảnh báo: Dữ liệu hiện tại sẽ bị ghi đè và mất vĩnh viễn.\nBạn có chắc muốn phục hồi?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        // Tạo thư mục Data nếu lỡ bị xóa
                        if (!Directory.Exists(dataPath)) Directory.CreateDirectory(dataPath);

                        // Lấy các file xml từ thư mục backup
                        string[] files = Directory.GetFiles(sourceBackupPath, "*.xml");

                        foreach (string file in files)
                        {
                            string name = Path.GetFileName(file);
                            string dest = Path.Combine(dataPath, name);
                            // Copy đè (overwrite = true)
                            File.Copy(file, dest, true);
                        }

                        MessageBox.Show("Phục hồi dữ liệu thành công! Ứng dụng sẽ khởi động lại.", "Thông báo");
                        Application.Restart(); // Khởi động lại app để nạp dữ liệu mới
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi phục hồi: " + ex.Message);
                    }
                }
            }
        }
    }
}