using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QuanLyCuaHangThuCung.Class;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmNhanVien : Form
    {
        NhanVien nvBLL = new NhanVien();
        FileXml Fxml = new FileXml();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            dtpNgaySinh.Value = DateTime.Now.AddYears(-18); // Mặc định 18 tuổi
        }

        // Load dữ liệu lên DataGridView
        private void LoadData()
        {
            try
            {
                DataTable dt = Fxml.HienThi("NhanVien.xml");

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Tạo bảng hiển thị với tên cột tiếng Việt
                    DataTable dtDisplay = new DataTable();
                    dtDisplay.Columns.Add("Mã NV", typeof(string));
                    dtDisplay.Columns.Add("Tên nhân viên", typeof(string));
                    dtDisplay.Columns.Add("Ngày sinh", typeof(string));
                    dtDisplay.Columns.Add("Tuổi", typeof(int));
                    dtDisplay.Columns.Add("Địa chỉ", typeof(string));
                    dtDisplay.Columns.Add("SĐT", typeof(string));
                    dtDisplay.Columns.Add("Email", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        DataRow newRow = dtDisplay.NewRow();
                        newRow["Mã NV"] = row["MaNhanVien"];
                        newRow["Tên nhân viên"] = row["TenNhanVien"];
                        newRow["Ngày sinh"] = row["NgaySinh"];

                        // Tính tuổi
                        if (DateTime.TryParse(row["NgaySinh"].ToString(), out DateTime ngaySinh))
                        {
                            int tuoi = DateTime.Now.Year - ngaySinh.Year;
                            if (DateTime.Now < ngaySinh.AddYears(tuoi))
                                tuoi--;
                            newRow["Tuổi"] = tuoi;
                        }
                        else
                        {
                            newRow["Tuổi"] = 0;
                        }

                        newRow["Địa chỉ"] = row["DiaChi"];
                        newRow["SĐT"] = row["SDT"];
                        newRow["Email"] = row["Email"];

                        dtDisplay.Rows.Add(newRow);
                    }

                    dgvNhanVien.DataSource = dtDisplay;

                    // Định dạng cột
                    dgvNhanVien.Columns["Mã NV"].Width = 80;
                    dgvNhanVien.Columns["Tên nhân viên"].Width = 180;
                    dgvNhanVien.Columns["Ngày sinh"].Width = 100;
                    dgvNhanVien.Columns["Tuổi"].Width = 60;
                    dgvNhanVien.Columns["Địa chỉ"].Width = 150;
                    dgvNhanVien.Columns["SĐT"].Width = 100;
                    dgvNhanVien.Columns["Email"].Width = 180;
                }
                else
                {
                    dgvNhanVien.DataSource = null;
                    MessageBox.Show("Chưa có nhân viên nào trong hệ thống!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện Click vào DataGridView
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                    txtMaNV.Text = row.Cells["Mã NV"].Value.ToString();
                    txtTenNV.Text = row.Cells["Tên nhân viên"].Value.ToString();

                    if (DateTime.TryParse(row.Cells["Ngày sinh"].Value.ToString(), out DateTime ngaySinh))
                    {
                        dtpNgaySinh.Value = ngaySinh;
                    }

                    txtDiaChi.Text = row.Cells["Địa chỉ"].Value.ToString();
                    txtSDT.Text = row.Cells["SĐT"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn dữ liệu: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate dữ liệu
                if (!ValidateInput())
                    return;

                string maNV = txtMaNV.Text.Trim();
                string tenNV = txtTenNV.Text.Trim();
                string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                string diaChi = txtDiaChi.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();

                // Kiểm tra mã nhân viên đã tồn tại
                if (nvBLL.kiemtra(maNV))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNV.Focus();
                    return;
                }

                // Kiểm tra tuổi (phải từ 18 tuổi trở lên)
                int tuoi = DateTime.Now.Year - dtpNgaySinh.Value.Year;
                if (DateTime.Now < dtpNgaySinh.Value.AddYears(tuoi))
                    tuoi--;

                if (tuoi < 18)
                {
                    MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm nhân viên
                nvBLL.themNV(maNV, tenNV, ngaySinh, diaChi, sdt, email);

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate dữ liệu
                if (!ValidateInput())
                    return;

                string maNV = txtMaNV.Text.Trim();
                string tenNV = txtTenNV.Text.Trim();
                string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                string diaChi = txtDiaChi.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();

                // Kiểm tra mã nhân viên có tồn tại không
                if (!nvBLL.kiemtra(maNV))
                {
                    MessageBox.Show("Mã nhân viên không tồn tại!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra tuổi
                int tuoi = DateTime.Now.Year - dtpNgaySinh.Value.Year;
                if (DateTime.Now < dtpNgaySinh.Value.AddYears(tuoi))
                    tuoi--;

                if (tuoi < 18)
                {
                    MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn sửa thông tin nhân viên này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    nvBLL.suaNV(maNV, tenNV, ngaySinh, diaChi, sdt, email);

                    MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maNV = txtMaNV.Text.Trim();

                if (!nvBLL.kiemtra(maNV))
                {
                    MessageBox.Show("Mã nhân viên không tồn tại!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa nhân viên này?\nLưu ý: Dữ liệu chấm công liên quan sẽ không bị xóa.",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    nvBLL.xoaNV(maNV);

                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        // Hàm làm mới form
        private void LamMoi()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            dtpNgaySinh.Value = DateTime.Now.AddYears(-18);
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtMaNV.Focus();
        }

        // Hàm validate dữ liệu
        private bool ValidateInput()
        {
            // Kiểm tra mã nhân viên
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return false;
            }

            // Kiểm tra tên nhân viên
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return false;
            }

            // Kiểm tra địa chỉ
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }

            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            // Validate format số điện thoại (10-11 số, bắt đầu bằng 0)
            string sdtPattern = @"^0\d{9,10}$";
            if (!Regex.IsMatch(txtSDT.Text.Trim(), sdtPattern))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!\nVui lòng nhập 10-11 số, bắt đầu bằng 0.",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            // Kiểm tra email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Validate format email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text.Trim(), emailPattern))
            {
                MessageBox.Show("Email không hợp lệ!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }
    }
}