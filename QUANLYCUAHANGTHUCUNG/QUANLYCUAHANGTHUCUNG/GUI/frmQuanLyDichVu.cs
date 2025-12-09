using System;
using System.Collections.Generic;
using System.Linq; // Để dùng LINQ (tìm kiếm, xóa)
using System.Windows.Forms;
using QuanLyThuCung.Class; // Namespace chứa FileXml và Model DichVu
using System.Drawing; // Vẫn giữ vì có thể liên quan đến giao diện

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmQuanLyDichVu : Form
    {
        // Khai báo List để chứa dữ liệu XML
        List<DichVu> listDV = new List<DichVu>();

        public frmQuanLyDichVu()
        {
            InitializeComponent();
        }

        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // --- TẢI DỮ LIỆU TỪ XML ---
        private void LoadData()
        {
            try
            {
                // 1. Đọc dữ liệu từ file XML lên List
                listDV = FileXml.DocFile<DichVu>("DichVu.xml");

                // 2. Đổ vào DataGridView
                dgvDichVu.DataSource = null;
                dgvDichVu.DataSource = listDV;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // --- HIỂN THỊ LÊN TEXTBOX KHI CLICK ---
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];

                txtMaDV.Text = row.Cells["MaDV"].Value?.ToString();
                txtTenDV.Text = row.Cells["TenDV"].Value?.ToString();

                // Chuyển đổi giá trị sang Decimal cho NumericUpDown
                if (row.Cells["GiaDV"].Value != null)
                    numGiaDV.Value = Convert.ToDecimal(row.Cells["GiaDV"].Value);

                // Chuyển đổi giá trị sang Int cho Thời gian thực hiện
                if (row.Cells["ThoiGianThucHien"].Value != null)
                    numThoiGian.Value = Convert.ToInt32(row.Cells["ThoiGianThucHien"].Value);
                else
                    numThoiGian.Value = 0;

                txtMaDV.Enabled = false; // Khóa mã khi đang chọn
            }
        }

        // --- THÊM DỊCH VỤ (INSERT XML) ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "" || txtTenDV.Text == "") return;

            // Kiểm tra trùng mã
            if (listDV.Any(x => x.MaDV == txtMaDV.Text.Trim()))
            {
                MessageBox.Show("Mã dịch vụ đã tồn tại!");
                return;
            }

            try
            {
                // Tạo đối tượng mới
                DichVu dv = new DichVu()
                {
                    MaDV = txtMaDV.Text.Trim(),
                    TenDV = txtTenDV.Text.Trim(),
                    GiaDV = (int)numGiaDV.Value, // Giả định GiaDV là INT
                    ThoiGianThucHien = (int)numThoiGian.Value
                };

                // Thêm vào List và Ghi File
                listDV.Add(dv);
                FileXml.GhiFile("DichVu.xml", listDV);

                MessageBox.Show("Thêm dịch vụ thành công!");
                LoadData();
                btnLamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // --- SỬA DỊCH VỤ (UPDATE XML) ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "") return;

            try
            {
                // Tìm dịch vụ trong List
                var dv = listDV.FirstOrDefault(x => x.MaDV == txtMaDV.Text);

                if (dv != null)
                {
                    // Cập nhật thông tin
                    dv.TenDV = txtTenDV.Text.Trim();
                    dv.GiaDV = (int)numGiaDV.Value;
                    dv.ThoiGianThucHien = (int)numThoiGian.Value;

                    // Lưu lại File
                    FileXml.GhiFile("DichVu.xml", listDV);

                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                    btnLamMoi_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // --- XÓA DỊCH VỤ (DELETE XML) ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "") return;

            if (MessageBox.Show("Bạn có chắc muốn xóa dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var dv = listDV.FirstOrDefault(x => x.MaDV == txtMaDV.Text);

                    if (dv != null)
                    {
                        listDV.Remove(dv);
                        FileXml.GhiFile("DichVu.xml", listDV);

                        MessageBox.Show("Đã xóa!");
                        LoadData();
                        btnLamMoi_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa (Dịch vụ đang được sử dụng): " + ex.Message);
                }
            }
        }

        // --- LÀM MỚI ---
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDV.Enabled = true;
            txtMaDV.Clear();
            txtTenDV.Clear();
            numGiaDV.Value = 0;
            numThoiGian.Value = 0;
            txtMaDV.Focus();
        }
    }
}