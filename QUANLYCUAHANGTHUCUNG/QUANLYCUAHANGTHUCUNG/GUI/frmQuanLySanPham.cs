using System;
using System.Collections.Generic; // Để dùng List
using System.Linq; // Để dùng LINQ (tìm kiếm, xóa)
using System.Windows.Forms;
using QuanLyThuCung.Class; // Namespace chứa FileXml và Models (SanPham, NhaCungCap)

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmQuanLySanPham : Form
    {
        // Khai báo List để chứa dữ liệu XML
        List<SanPham> listSP = new List<SanPham>();
        List<NhaCungCap> listNCC = new List<NhaCungCap>();

        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            LoadData();
            cboLoaiSP.SelectedIndex = 0; // Giả định ComboBox Loại SP đã được thêm sẵn item
        }

        // 1. TẢI DỮ LIỆU CHÍNH
        private void LoadData()
        {
            try
            {
                // Đọc file XML Sản phẩm
                listSP = FileXml.DocFile<SanPham>("SanPham.xml");

                // Đổ vào DataGridView
                dgvSanPham.DataSource = null;
                dgvSanPham.DataSource = listSP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu sản phẩm: " + ex.Message);
            }
        }

        // 2. TẢI DANH MỤC NHÀ CUNG CẤP (XML)
        private void LoadNhaCungCap()
        {
            try
            {
                // Đọc file XML Nhà Cung Cấp
                listNCC = FileXml.DocFile<NhaCungCap>("NhaCungCap.xml");

                cboNCC.DataSource = listNCC;
                cboNCC.DisplayMember = "TenNCC";
                cboNCC.ValueMember = "MaNCC";
            }
            catch { }
        }

        // 3. HIỂN THỊ LÊN Ô NHẬP KHI CLICK
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value?.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value?.ToString();

                // Lấy giá trị LoaiSP (string)
                if (row.Cells["LoaiSP"].Value != null)
                    cboLoaiSP.Text = row.Cells["LoaiSP"].Value.ToString();

                txtDVT.Text = row.Cells["DonViTinh"].Value?.ToString();

                // Chuyển đổi giá trị số
                if (row.Cells["DonGiaBan"].Value != null)
                    numGiaBan.Value = Convert.ToDecimal(row.Cells["DonGiaBan"].Value);

                if (row.Cells["SoLuongTon"].Value != null)
                    numSoLuong.Value = Convert.ToDecimal(row.Cells["SoLuongTon"].Value); // Dùng decimal cho an toàn

                // Set MaNCC cho ComboBox (Sử dụng ValueMember)
                if (row.Cells["MaNCC"].Value != null)
                    cboNCC.SelectedValue = row.Cells["MaNCC"].Value.ToString();

                txtMaSP.Enabled = false;
            }
        }

        // 4. THÊM (INSERT XML)
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "" || txtTenSP.Text == "" || cboNCC.SelectedValue == null) return;

            // Kiểm tra trùng mã
            if (listSP.Any(x => x.MaSP == txtMaSP.Text.Trim()))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
                return;
            }

            try
            {
                SanPham sp = new SanPham()
                {
                    MaSP = txtMaSP.Text.Trim(),
                    TenSP = txtTenSP.Text.Trim(),
                    LoaiSP = cboLoaiSP.Text,
                    DonViTinh = txtDVT.Text.Trim(),
                    DonGia = (int)numGiaBan.Value,
                    SoLuongTon = (int)numSoLuong.Value,
                    MaNCC = cboNCC.SelectedValue.ToString()
                };

                // Thêm vào List và Ghi File
                listSP.Add(sp);
                FileXml.GhiFile("SanPham.xml", listSP);

                MessageBox.Show("Thêm thành công!");
                LoadData();
                btnLamMoi_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm: " + ex.Message); }
        }

        // 5. SỬA (UPDATE XML)
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "") return;

            try
            {
                // Tìm sản phẩm trong List
                var sp = listSP.FirstOrDefault(x => x.MaSP == txtMaSP.Text);

                if (sp != null)
                {
                    // Cập nhật thông tin
                    sp.TenSP = txtTenSP.Text.Trim();
                    sp.LoaiSP = cboLoaiSP.Text;
                    sp.DonViTinh = txtDVT.Text.Trim();
                    sp.DonGia = (int)numGiaBan.Value;
                    sp.SoLuongTon = (int)numSoLuong.Value;
                    sp.MaNCC = cboNCC.SelectedValue?.ToString();

                    // Lưu lại File
                    FileXml.GhiFile("SanPham.xml", listSP);

                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                    btnLamMoi_Click(sender, e);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 6. XÓA (DELETE XML)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "") return;

            if (MessageBox.Show("Xóa sản phẩm này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var sp = listSP.FirstOrDefault(x => x.MaSP == txtMaSP.Text);

                    if (sp != null)
                    {
                        listSP.Remove(sp);
                        FileXml.GhiFile("SanPham.xml", listSP);

                        MessageBox.Show("Đã xóa!");
                        LoadData();
                        btnLamMoi_Click(sender, e);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Enabled = true;
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDVT.Clear();
            numGiaBan.Value = 0;
            numSoLuong.Value = 0;

            if (cboLoaiSP.Items.Count > 0) cboLoaiSP.SelectedIndex = 0;
            // Nếu có dữ liệu NCC thì chọn lại NCC đầu tiên
            if (cboNCC.Items.Count > 0) cboNCC.SelectedIndex = 0;

            txtMaSP.Focus();
        }
    }
}