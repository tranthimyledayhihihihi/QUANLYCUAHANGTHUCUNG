// File: frmQuanLySanPham.cs
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangThuCung.Class;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmQuanLySanPham : Form
    {
        // Khai báo BLL
        // Lưu ý: Lớp SanPham của bạn đang đặt tên là SanPham (chứ không phải SanPhamBLL)
        SanPham spBLL = new SanPham();
        NhaCungCap nccBLL = new NhaCungCap(); // Để load ComboBox NCC

        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            HienThiDanhSachSanPham();
            LoadComboBoxes();
            LamMoiControls();
        }

        // Hàm load dữ liệu NCC cho ComboBox
        private void LoadComboBoxes()
        {
            // 1. Load Nhà Cung Cấp
            DataTable dtNCC = nccBLL.LoadMaNCC(); // Sử dụng hàm LoadMaNCC để lấy danh sách NCC
            cboMaNCC.DataSource = dtNCC;
            cboMaNCC.DisplayMember = "TenNCC"; // Hiển thị tên NCC
            cboMaNCC.ValueMember = "MaNCC";    // Lấy mã NCC

            if (cboMaNCC.Items.Count > 0) cboMaNCC.SelectedIndex = 0;
            if (cboLoaiSP.Items.Count > 0) cboLoaiSP.SelectedIndex = 0;
        }


        // Hàm load dữ liệu lên DataGridView
        private void HienThiDanhSachSanPham()
        {
            DataTable dt = spBLL.LoadTable();
            dgvSanPham.DataSource = dt;
        }

        // Hàm xóa nội dung các Controls
        private void LamMoiControls()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonViTinh.Clear();
            txtDonGiaBan.Clear();
            txtSoLuongTon.Text = "0";
            cboLoaiSP.SelectedIndex = -1;
            cboMaNCC.SelectedIndex = -1;
            txtMaSP.Focus();
            txtMaSP.ReadOnly = false;
        }

        // ========== HÀM THAO TÁC CRUD ==========

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();
            string loaiSP = cboLoaiSP.Text;
            string dvt = txtDonViTinh.Text.Trim();
            string maNCC = cboMaNCC.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show("Vui lòng nhập Mã SP, Tên SP và chọn Nhà Cung Cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int donGiaBan, soLuongTon;
            if (!int.TryParse(txtDonGiaBan.Text, out donGiaBan) || !int.TryParse(txtSoLuongTon.Text, out soLuongTon))
            {
                MessageBox.Show("Đơn giá bán và Số lượng tồn phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (spBLL.kiemtraMaSP(maSP))
            {
                MessageBox.Show("Mã Sản phẩm đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                spBLL.themSP(maSP, tenSP, loaiSP, dvt, donGiaBan, soLuongTon, maNCC);
                MessageBox.Show("Thêm Sản phẩm thành công.", "Thông báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();
            string loaiSP = cboLoaiSP.Text;
            string dvt = txtDonViTinh.Text.Trim();
            string maNCC = cboMaNCC.SelectedValue?.ToString();

            int donGiaBan, soLuongTon;
            if (!int.TryParse(txtDonGiaBan.Text, out donGiaBan) || !int.TryParse(txtSoLuongTon.Text, out soLuongTon))
            {
                MessageBox.Show("Đơn giá bán và Số lượng tồn phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!spBLL.kiemtraMaSP(maSP))
            {
                MessageBox.Show("Mã Sản phẩm không tồn tại để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                spBLL.suaSP(maSP, tenSP, loaiSP, dvt, donGiaBan, soLuongTon, maNCC);
                MessageBox.Show("Cập nhật Sản phẩm thành công.", "Thông báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();

            if (!spBLL.kiemtraMaSP(maSP))
            {
                MessageBox.Show("Vui lòng chọn Sản phẩm để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {maSP}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    spBLL.xoaSP(maSP);
                    MessageBox.Show("Xóa Sản phẩm thành công.", "Thông báo");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiControls();
        }

        // ========== XỬ LÝ SỰ KIỆN DATAGRIDVIEW ==========
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                cboLoaiSP.Text = row.Cells["LoaiSP"].Value.ToString();
                txtDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                txtDonGiaBan.Text = row.Cells["DonGiaBan"].Value.ToString();
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value.ToString();

                // Chọn Nhà Cung Cấp
                string maNCC = row.Cells["MaNCC"].Value.ToString();
                cboMaNCC.SelectedValue = maNCC; // Dùng SelectedValue để chọn theo ValueMember (MaNCC)

                // Khóa Mã SP khi sửa
                txtMaSP.ReadOnly = true;
            }
        }

        private void cboMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}