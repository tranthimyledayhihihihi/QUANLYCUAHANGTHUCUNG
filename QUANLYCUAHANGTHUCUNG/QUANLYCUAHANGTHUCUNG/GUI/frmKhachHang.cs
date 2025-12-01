using System;
using System.Collections.Generic; // Để dùng List
using System.Linq; // Để dùng LINQ (tìm kiếm, xóa)
using System.Windows.Forms;
using QuanLyThuCung.Class; // Namespace chứa FileXml và Class Model

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmKhachHang : Form
    {
        // Khai báo danh sách để hứng dữ liệu từ XML
        List<KhachHang> listKH = new List<KhachHang>();

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // --- HÀM TẢI DỮ LIỆU TỪ XML ---
        private void LoadData()
        {
            try
            {
                // 1. Đọc dữ liệu từ file XML lên List
                listKH = FileXml.DocFile<KhachHang>("KhachHang.xml");

                // 2. Đổ dữ liệu vào DataGridView
                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = listKH;

                // Tùy chỉnh hiển thị cột nếu cần (Ví dụ ẩn cột nào đó)
                // if (dgvKhachHang.Columns["DiemTichLuy"] != null) dgvKhachHang.Columns["DiemTichLuy"].HeaderText = "Điểm";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // --- XỬ LÝ CELL CLICK (Đổ dữ liệu lên ô nhập) ---
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                // Lấy giá trị từ lưới đổ lên các ô nhập
                txtMaKH.Text = row.Cells["MaKhachHang"].Value?.ToString();
                txtTenKH.Text = row.Cells["TenKhachHang"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();

                // Xử lý điểm tích lũy
                if (row.Cells["DiemTichLuy"].Value != null)
                    numDiem.Value = Convert.ToInt32(row.Cells["DiemTichLuy"].Value);
                else
                    numDiem.Value = 0;

                txtMaKH.Enabled = false; // Không cho sửa Mã khi đang chọn dòng cũ
            }
        }

        // --- NÚT THÊM ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateInput() == false) return;

            // Kiểm tra trùng mã bằng LINQ
            if (listKH.Any(x => x.MaKhachHang == txtMaKH.Text.Trim()))
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại!");
                return;
            }

            try
            {
                // Tạo đối tượng mới
                KhachHang kh = new KhachHang()
                {
                    MaKhachHang = txtMaKH.Text.Trim(),
                    TenKhachHang = txtTenKH.Text.Trim(),
                    SDT = txtSDT.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    DiemTichLuy = (int)numDiem.Value
                };

                // Thêm vào danh sách và Lưu file
                listKH.Add(kh);
                FileXml.GhiFile("KhachHang.xml", listKH);

                MessageBox.Show("Thêm khách hàng thành công!");
                LoadData(); // Load lại lưới
                btnLamMoi_Click(sender, e); // Xóa trắng ô nhập
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm mới: " + ex.Message);
            }
        }

        // --- NÚT SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                return;
            }

            try
            {
                // Tìm khách hàng trong List theo Mã
                var kh = listKH.FirstOrDefault(x => x.MaKhachHang == txtMaKH.Text);

                if (kh != null)
                {
                    // Cập nhật thông tin mới
                    kh.TenKhachHang = txtTenKH.Text.Trim();
                    kh.SDT = txtSDT.Text.Trim();
                    kh.DiaChi = txtDiaChi.Text.Trim();
                    kh.DiemTichLuy = (int)numDiem.Value;

                    // Lưu lại danh sách mới vào file XML
                    FileXml.GhiFile("KhachHang.xml", listKH);

                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng để sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        // --- NÚT XÓA ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "") return;

            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // Tìm khách hàng cần xóa
                    var kh = listKH.FirstOrDefault(x => x.MaKhachHang == txtMaKH.Text);

                    if (kh != null)
                    {
                        listKH.Remove(kh); // Xóa khỏi List
                        FileXml.GhiFile("KhachHang.xml", listKH); // Ghi lại file XML

                        MessageBox.Show("Đã xóa!");
                        LoadData();
                        btnLamMoi_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng không tồn tại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        // --- NÚT LÀM MỚI ---
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true; // Mở khóa cho nhập Mã mới
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            numDiem.Value = 0;
            txtMaKH.Focus();
        }

        private bool ValidateInput()
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "")
            {
                MessageBox.Show("Mã và Tên khách hàng không được để trống!");
                return false;
            }
            return true;
        }
    }
}