// File: frmDoiMatKhau.cs
using System;
using System.Windows.Forms;
using QuanLyCuaHangThuCung.Class; // Cần để gọi lớp DoiMatKhau và GlobalVariables

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        // Khai báo lớp logic
        DoiMatKhau dmkh = new DoiMatKhau();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMKCu.Text;
            string matKhauMoi = txtMKMoi.Text;
            string xacNhanMK = txtXacNhanMK.Text;

            // 1. Kiểm tra đầu vào
            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhanMK))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mật khẩu cũ và Mật khẩu mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra khớp mật khẩu mới
            if (matKhauMoi != xacNhanMK)
            {
                MessageBox.Show("Mật khẩu mới và Xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Kiểm tra Mật khẩu cũ có đúng không (sử dụng KiemTraMK từ DoiMatKhau.cs)
            if (!dmkh.KiemTraMK(matKhauCu))
            {
                MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKCu.Focus();
                return;
            }

            try
            {
                // 4. Đổi mật khẩu (sử dụng Doi từ DoiMatKhau.cs)
                dmkh.Doi(matKhauMoi);

                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật mật khẩu: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMKCu_Click(object sender, EventArgs e)
        {

        }
    }
}