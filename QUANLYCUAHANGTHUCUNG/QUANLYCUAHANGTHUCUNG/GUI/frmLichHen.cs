using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangThuCung.Class;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmLichHen : Form
    {
        LichHenBLL lichHenBLL = new LichHenBLL();
        FileXml Fxml = new FileXml();

        public frmLichHen()
        {
            InitializeComponent();
        }

        private void frmLichHen_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxes();
            LoadGioHen();
            LoadTrangThai();
            txtMaLichHen.Text = "Tự động";
        }

        // Load dữ liệu lên DataGridView
        private void LoadData()
        {
            try
            {
                DataTable dt = Fxml.HienThi("LichHen.xml");

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Tạo DataTable mới với thông tin đầy đủ
                    DataTable dtDisplay = new DataTable();
                    dtDisplay.Columns.Add("Mã LH", typeof(int));
                    dtDisplay.Columns.Add("Mã KH", typeof(string));
                    dtDisplay.Columns.Add("Tên KH", typeof(string));
                    dtDisplay.Columns.Add("Mã DV", typeof(string));
                    dtDisplay.Columns.Add("Tên DV", typeof(string));
                    dtDisplay.Columns.Add("Ngày hẹn", typeof(string));
                    dtDisplay.Columns.Add("Giờ hẹn", typeof(string));
                    dtDisplay.Columns.Add("Trạng thái", typeof(string));

                    // Load dữ liệu Khách hàng và Dịch vụ
                    DataTable dtKH = Fxml.HienThi("KhachHang.xml");
                    DataTable dtDV = Fxml.HienThi("DichVu.xml");

                    foreach (DataRow row in dt.Rows)
                    {
                        DataRow newRow = dtDisplay.NewRow();
                        newRow["Mã LH"] = row["MaLichHen"];
                        newRow["Mã KH"] = row["MaKhachHang"];
                        newRow["Mã DV"] = row["MaDichVu"];
                        newRow["Ngày hẹn"] = row["NgayHen"];
                        newRow["Giờ hẹn"] = row["GioHen"];
                        newRow["Trạng thái"] = row["TrangThai"];

                        // Tìm tên khách hàng
                        if (dtKH != null)
                        {
                            DataRow[] khRows = dtKH.Select($"MaKH = '{row["MaKhachHang"]}'");
                            if (khRows.Length > 0)
                            {
                                newRow["Tên KH"] = khRows[0]["TenKH"];
                            }
                        }

                        // Tìm tên dịch vụ
                        if (dtDV != null)
                        {
                            DataRow[] dvRows = dtDV.Select($"MaDV = '{row["MaDichVu"]}'");
                            if (dvRows.Length > 0)
                            {
                                newRow["Tên DV"] = dvRows[0]["TenDV"];
                            }
                        }

                        dtDisplay.Rows.Add(newRow);
                    }

                    dgvLichHen.DataSource = dtDisplay;

                    // Định dạng hiển thị
                    dgvLichHen.Columns["Mã LH"].Width = 70;
                    dgvLichHen.Columns["Mã KH"].Width = 80;
                    dgvLichHen.Columns["Tên KH"].Width = 150;
                    dgvLichHen.Columns["Mã DV"].Width = 80;
                    dgvLichHen.Columns["Tên DV"].Width = 150;
                    dgvLichHen.Columns["Ngày hẹn"].Width = 100;
                    dgvLichHen.Columns["Giờ hẹn"].Width = 80;
                }
                else
                {
                    dgvLichHen.DataSource = null;
                    MessageBox.Show("Chưa có lịch hẹn nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load ComboBox Khách hàng
        private void LoadComboBoxes()
        {
            try
            {
                // Load Khách hàng
                DataTable dtKH = Fxml.HienThi("KhachHang.xml");
                if (dtKH != null && dtKH.Rows.Count > 0)
                {
                    cboMaKhachHang.DisplayMember = "Display";
                    cboMaKhachHang.ValueMember = "MaKH";

                    DataTable dtKHDisplay = new DataTable();
                    dtKHDisplay.Columns.Add("MaKH", typeof(string));
                    dtKHDisplay.Columns.Add("Display", typeof(string));

                    foreach (DataRow row in dtKH.Rows)
                    {
                        DataRow newRow = dtKHDisplay.NewRow();
                        newRow["MaKH"] = row["MaKH"];
                        newRow["Display"] = $"{row["MaKH"]} - {row["TenKH"]}";
                        dtKHDisplay.Rows.Add(newRow);
                    }

                    cboMaKhachHang.DataSource = dtKHDisplay;
                }

                // Load Dịch vụ
                DataTable dtDV = Fxml.HienThi("DichVu.xml");
                if (dtDV != null && dtDV.Rows.Count > 0)
                {
                    cboMaDichVu.DisplayMember = "Display";
                    cboMaDichVu.ValueMember = "MaDV";

                    DataTable dtDVDisplay = new DataTable();
                    dtDVDisplay.Columns.Add("MaDV", typeof(string));
                    dtDVDisplay.Columns.Add("Display", typeof(string));

                    foreach (DataRow row in dtDV.Rows)
                    {
                        DataRow newRow = dtDVDisplay.NewRow();
                        newRow["MaDV"] = row["MaDV"];
                        newRow["Display"] = $"{row["MaDV"]} - {row["TenDV"]} ({row["GiaDV"]:N0} VNĐ)";
                        dtDVDisplay.Rows.Add(newRow);
                    }

                    cboMaDichVu.DataSource = dtDVDisplay;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load ComboBox: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load giờ hẹn (8h-18h)
        private void LoadGioHen()
        {
            cboGioHen.Items.Clear();
            for (int h = 8; h <= 18; h++)
            {
                cboGioHen.Items.Add($"{h:D2}:00");
                if (h < 18)
                    cboGioHen.Items.Add($"{h:D2}:30");
            }
            cboGioHen.SelectedIndex = 0;
        }

        // Load trạng thái
        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Chờ xác nhận");
            cboTrangThai.Items.Add("Đã xác nhận");
            cboTrangThai.Items.Add("Đang thực hiện");
            cboTrangThai.Items.Add("Hoàn thành");
            cboTrangThai.Items.Add("Đã hủy");
            cboTrangThai.SelectedIndex = 0;
        }

        // Sự kiện Click vào DataGridView
        private void dgvLichHen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvLichHen.Rows[e.RowIndex];

                    txtMaLichHen.Text = row.Cells["Mã LH"].Value.ToString();

                    // Set ComboBox Khách hàng
                    string maKH = row.Cells["Mã KH"].Value.ToString();
                    for (int i = 0; i < cboMaKhachHang.Items.Count; i++)
                    {
                        DataRowView item = (DataRowView)cboMaKhachHang.Items[i];
                        if (item["MaKH"].ToString() == maKH)
                        {
                            cboMaKhachHang.SelectedIndex = i;
                            break;
                        }
                    }

                    // Set ComboBox Dịch vụ
                    string maDV = row.Cells["Mã DV"].Value.ToString();
                    for (int i = 0; i < cboMaDichVu.Items.Count; i++)
                    {
                        DataRowView item = (DataRowView)cboMaDichVu.Items[i];
                        if (item["MaDV"].ToString() == maDV)
                        {
                            cboMaDichVu.SelectedIndex = i;
                            break;
                        }
                    }

                    dtpNgayHen.Value = DateTime.Parse(row.Cells["Ngày hẹn"].Value.ToString());
                    cboGioHen.Text = row.Cells["Giờ hẹn"].Value.ToString();
                    cboTrangThai.Text = row.Cells["Trạng thái"].Value.ToString();
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
                if (cboMaKhachHang.SelectedValue == null || cboMaDichVu.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maKH = cboMaKhachHang.SelectedValue.ToString();
                string maDV = cboMaDichVu.SelectedValue.ToString();
                string ngayHen = dtpNgayHen.Value.ToString("yyyy-MM-dd");
                string gioHen = cboGioHen.Text;
                string trangThai = cboTrangThai.Text;

                // Kiểm tra ngày hẹn không được trong quá khứ
                DateTime ngayHenDate = DateTime.Parse(ngayHen);
                if (ngayHenDate.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày hẹn không được trong quá khứ!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lichHenBLL.themLH(maKH, maDV, ngayHen, gioHen, trangThai);

                MessageBox.Show("Thêm lịch hẹn thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lịch hẹn: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaLichHen.Text) || txtMaLichHen.Text == "Tự động")
                {
                    MessageBox.Show("Vui lòng chọn lịch hẹn cần sửa!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboMaKhachHang.SelectedValue == null || cboMaDichVu.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maLH = txtMaLichHen.Text;
                string maKH = cboMaKhachHang.SelectedValue.ToString();
                string maDV = cboMaDichVu.SelectedValue.ToString();
                string ngayHen = dtpNgayHen.Value.ToString("yyyy-MM-dd");
                string gioHen = cboGioHen.Text;
                string trangThai = cboTrangThai.Text;

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn sửa lịch hẹn này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lichHenBLL.suaLH(maLH, maKH, maDV, ngayHen, gioHen, trangThai);

                    MessageBox.Show("Sửa lịch hẹn thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa lịch hẹn: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaLichHen.Text) || txtMaLichHen.Text == "Tự động")
                {
                    MessageBox.Show("Vui lòng chọn lịch hẹn cần xóa!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maLH = txtMaLichHen.Text;

                if (!lichHenBLL.kiemtraMaLichHen(maLH))
                {
                    MessageBox.Show("Lịch hẹn không tồn tại!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa lịch hẹn này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    lichHenBLL.xoaLH(maLH);

                    MessageBox.Show("Xóa lịch hẹn thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lịch hẹn: " + ex.Message, "Lỗi",
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
            txtMaLichHen.Text = "Tự động";

            if (cboMaKhachHang.Items.Count > 0)
                cboMaKhachHang.SelectedIndex = 0;

            if (cboMaDichVu.Items.Count > 0)
                cboMaDichVu.SelectedIndex = 0;

            dtpNgayHen.Value = DateTime.Now;

            if (cboGioHen.Items.Count > 0)
                cboGioHen.SelectedIndex = 0;

            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;
        }

        private void dgvLichHen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}