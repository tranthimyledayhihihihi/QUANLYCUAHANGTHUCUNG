using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangThuCung.Class;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmQuanLyDichVu : Form
    {
        DichVuBLL dichVuBLL = new DichVuBLL();

        public frmQuanLyDichVu()
        {
            InitializeComponent();
        }

        // ===============================================
        // FORM LOAD - Tải dữ liệu lần đầu
        // ===============================================
        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            CustomizeDataGridView();
        }

        // ===============================================
        // LOAD DỮ LIỆU TỪ XML
        // ===============================================
        private void LoadDuLieu()
        {
            try
            {
                DataTable dt = dichVuBLL.LoadTable();
                dgvDichVu.DataSource = dt;

                // Đặt tiêu đề cột
                if (dgvDichVu.Columns.Count > 0)
                {
                    dgvDichVu.Columns["MaDV"].HeaderText = "Mã Dịch Vụ";
                    dgvDichVu.Columns["TenDV"].HeaderText = "Tên Dịch Vụ";
                    dgvDichVu.Columns["GiaDV"].HeaderText = "Giá Dịch Vụ (VNĐ)";
                    dgvDichVu.Columns["ThoiGianThucHien"].HeaderText = "Thời Gian (phút)";

                    // Căn phải cho cột số
                    dgvDichVu.Columns["GiaDV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvDichVu.Columns["ThoiGianThucHien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    // Format số tiền
                    dgvDichVu.Columns["GiaDV"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================================
        // TÙY CHỈNH DATAGRIDVIEW
        // ===============================================
        private void CustomizeDataGridView()
        {
            // Màu sắc cho header
            dgvDichVu.EnableHeadersVisualStyles = false;
            dgvDichVu.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            dgvDichVu.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvDichVu.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dgvDichVu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDichVu.ColumnHeadersHeight = 35;

            // Màu sắc cho dòng
            dgvDichVu.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            dgvDichVu.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvDichVu.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            dgvDichVu.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        }

        // ===============================================
        // CLICK CELL DATAGRIDVIEW - Hiển thị dữ liệu lên form
        // ===============================================
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];

                    txtMaDV.Text = row.Cells["MaDV"].Value?.ToString() ?? "";
                    txtTenDV.Text = row.Cells["TenDV"].Value?.ToString() ?? "";
                    txtGiaDV.Text = row.Cells["GiaDV"].Value?.ToString() ?? "";
                    txtThoiGian.Text = row.Cells["ThoiGianThucHien"].Value?.ToString() ?? "";

                    // Disable txtMaDV khi chọn để tránh sửa mã
                    txtMaDV.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ===============================================
        // VALIDATE DỮ LIỆU NHẬP
        // ===============================================
        private bool ValidateInput()
        {
            // Kiểm tra mã dịch vụ
            if (string.IsNullOrWhiteSpace(txtMaDV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Dịch Vụ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDV.Focus();
                return false;
            }

            // Kiểm tra tên dịch vụ
            if (string.IsNullOrWhiteSpace(txtTenDV.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Dịch Vụ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDV.Focus();
                return false;
            }

            // Kiểm tra giá dịch vụ
            if (string.IsNullOrWhiteSpace(txtGiaDV.Text))
            {
                MessageBox.Show("Vui lòng nhập Giá Dịch Vụ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaDV.Focus();
                return false;
            }

            int giaDV;
            if (!int.TryParse(txtGiaDV.Text, out giaDV) || giaDV <= 0)
            {
                MessageBox.Show("Giá Dịch Vụ phải là số nguyên dương!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaDV.Focus();
                return false;
            }

            // Kiểm tra thời gian
            if (string.IsNullOrWhiteSpace(txtThoiGian.Text))
            {
                MessageBox.Show("Vui lòng nhập Thời Gian Thực Hiện!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThoiGian.Focus();
                return false;
            }

            int thoiGian;
            if (!int.TryParse(txtThoiGian.Text, out thoiGian) || thoiGian <= 0)
            {
                MessageBox.Show("Thời Gian phải là số nguyên dương (phút)!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThoiGian.Focus();
                return false;
            }

            return true;
        }

        // ===============================================
        // NÚT THÊM DỊCH VỤ
        // ===============================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate dữ liệu
                if (!ValidateInput())
                    return;

                string maDV = txtMaDV.Text.Trim().ToUpper();
                string tenDV = txtTenDV.Text.Trim();
                int giaDV = int.Parse(txtGiaDV.Text.Trim());
                int thoiGian = int.Parse(txtThoiGian.Text.Trim());

                // Kiểm tra trùng mã
                if (dichVuBLL.kiemtraMaDV(maDV))
                {
                    MessageBox.Show("Mã Dịch Vụ đã tồn tại!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaDV.Focus();
                    return;
                }

                // Xác nhận thêm
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn thêm dịch vụ '{tenDV}' không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Thêm vào XML
                    dichVuBLL.themDV(maDV, tenDV, giaDV, thoiGian);

                    MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload dữ liệu và làm mới form
                    LoadDuLieu();
                    LamMoiForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dịch vụ: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================================
        // NÚT SỬA DỊCH VỤ
        // ===============================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn dịch vụ chưa
                if (string.IsNullOrWhiteSpace(txtMaDV.Text))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần sửa từ bảng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate dữ liệu
                if (!ValidateInput())
                    return;

                string maDV = txtMaDV.Text.Trim().ToUpper();
                string tenDV = txtTenDV.Text.Trim();
                int giaDV = int.Parse(txtGiaDV.Text.Trim());
                int thoiGian = int.Parse(txtThoiGian.Text.Trim());

                // Xác nhận sửa
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn sửa thông tin dịch vụ '{maDV}' không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Sửa trong XML
                    dichVuBLL.suaDV(maDV, tenDV, giaDV, thoiGian);

                    MessageBox.Show("Sửa thông tin dịch vụ thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload dữ liệu và làm mới form
                    LoadDuLieu();
                    LamMoiForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dịch vụ: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================================
        // NÚT XÓA DỊCH VỤ
        // ===============================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn dịch vụ chưa
                if (string.IsNullOrWhiteSpace(txtMaDV.Text))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa từ bảng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maDV = txtMaDV.Text.Trim().ToUpper();
                string tenDV = txtTenDV.Text.Trim();

                // Xác nhận xóa
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa dịch vụ '{tenDV}' ({maDV}) không?\n\nThao tác này không thể hoàn tác!",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Xóa khỏi XML
                    dichVuBLL.xoaDV(maDV);

                    MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload dữ liệu và làm mới form
                    LoadDuLieu();
                    LamMoiForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dịch vụ: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===============================================
        // NÚT LÀM MỚI
        // ===============================================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        // ===============================================
        // HÀM LÀM MỚI FORM
        // ===============================================
        private void LamMoiForm()
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtGiaDV.Clear();
            txtThoiGian.Clear();

            txtMaDV.Enabled = true;
            txtMaDV.Focus();

            // Bỏ chọn dòng trong DataGridView
            dgvDichVu.ClearSelection();
        }

        // ===============================================
        // CHỈ CHO PHÉP NHẬP SỐ VÀO TEXTBOX GIÁ
        // ===============================================
        private void txtGiaDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép số và phím điều khiển (Backspace, Delete...)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ===============================================
        // CHỈ CHO PHÉP NHẬP SỐ VÀO TEXTBOX THỜI GIAN
        // ===============================================
        private void txtThoiGian_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép số và phím điều khiển (Backspace, Delete...)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}