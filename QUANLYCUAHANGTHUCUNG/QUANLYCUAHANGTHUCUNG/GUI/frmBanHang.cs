using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangThuCung.Class;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmBanHang : Form
    {
        FileXml Fxml = new FileXml();
        HoaDonBLL hdBLL = new HoaDonBLL();

        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load_1(object sender, EventArgs e)
        {
            loadNhanVien();
            loadKhachHang();

            loadSanPham();
            loadThuCung();
            loadDichVu();

            setupChiTietHoaDon();

            dtpNgayBan.Value = DateTime.Now;
            txtTongTien.Text = "0";
        }

        // ================================
        // LOAD COMBOBOX
        // ================================
        private void loadNhanVien()
        {
            cboNhanVien.DataSource = Fxml.HienThi("NhanVien.xml");
            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "MaNhanVien";
        }

        private void loadKhachHang()
        {
            cboKhachHang.DataSource = Fxml.HienThi("KhachHang.xml");
            cboKhachHang.DisplayMember = "TenKhachHang";
            cboKhachHang.ValueMember = "MaKhachHang";
        }

        // ================================
        // LOAD TAB DỮ LIỆU
        // ================================
        private void loadSanPham()
        {
            dgvSanPham.DataSource = Fxml.HienThi("SanPham.xml");
        }

        private void loadThuCung()
        {
            DataTable dt = Fxml.HienThi("ThuCung.xml");
            dt.DefaultView.RowFilter = "TrangThai = 'Còn hàng'";
            dgvThuCung.DataSource = dt;
        }

        private void loadDichVu()
        {
            dgvDichVu.DataSource = Fxml.HienThi("DichVu.xml");
        }

        // ================================
        // CHI TIẾT HÓA ĐƠN
        // ================================
        private void setupChiTietHoaDon()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaMatHang");
            dt.Columns.Add("LoaiMatHang");
            dt.Columns.Add("TenMatHang");
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("DonGia", typeof(decimal));
            dt.Columns.Add("ThanhTien", typeof(decimal));

            dgvGioHang.DataSource = dt;
        }

        // ================================
        // THÊM MẶT HÀNG
        // ================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataGridView dgv;
            string loai;

            if (tabMatHang.SelectedTab == tabSanPham)
            {
                dgv = dgvSanPham;
                loai = "SP";
            }
            else if (tabMatHang.SelectedTab == tabThuCung)
            {
                dgv = dgvThuCung;
                loai = "TC";
            }
            else
            {
                dgv = dgvDichVu;
                loai = "DV";
            }

            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Nhân viên chưa chọn mặt hàng!");
                return;
            }

            string ma = dgv.CurrentRow.Cells[0].Value.ToString();
            string ten = dgv.CurrentRow.Cells[1].Value.ToString();

            int soLuong = (loai == "SP") ? 1 : 1;

            decimal donGia =
                loai == "SP" ? Convert.ToDecimal(dgv.CurrentRow.Cells["DonGiaBan"].Value) :
                loai == "TC" ? Convert.ToDecimal(dgv.CurrentRow.Cells["GiaBan"].Value) :
                               Convert.ToDecimal(dgv.CurrentRow.Cells["GiaDV"].Value);

            DataTable cthd = (DataTable)dgvGioHang.DataSource;
            cthd.Rows.Add(ma, loai, ten, soLuong, donGia, soLuong * donGia);

            tinhTongTien();
        }

        // ================================
        // XÓA DÒNG
        // ================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null)
            {
                dgvGioHang.Rows.Remove(dgvGioHang.CurrentRow);
                tinhTongTien();
            }
        }

        // ================================
        // TÍNH TỔNG TIỀN
        // ================================
        private void tinhTongTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                    tong += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
            }
            txtTongTien.Text = tong.ToString("N0");
        }

        // ================================
        // LẬP HÓA ĐƠN
        // ================================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có mặt hàng!");
                return;
            }

            int soHD = hdBLL.ThemHD(
                cboNhanVien.SelectedValue.ToString(),
                cboKhachHang.SelectedValue.ToString(),
                dtpNgayBan.Value.ToString("yyyy-MM-dd"),
                decimal.Parse(txtTongTien.Text.Replace(",", ""))
            );

            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                // ⚠️ BẮT BUỘC – BỎ QUA DÒNG RỖNG CUỐI
                if (row.IsNewRow) continue;

                // ⚠️ AN TOÀN THÊM
                if (row.Cells["MaMatHang"].Value == null) continue;

                hdBLL.ThemCTHD(
                    soHD,
                    row.Cells["MaMatHang"].Value.ToString(),
                    row.Cells["LoaiMatHang"].Value.ToString(),
                    Convert.ToInt32(row.Cells["SoLuong"].Value),
                    Convert.ToDecimal(row.Cells["DonGia"].Value)
                );
            }


            MessageBox.Show($"Lập hóa đơn thành công!\nSố HĐ: {soHD}", "Hoàn tất");

            setupChiTietHoaDon();
            txtTongTien.Text = "0";

            loadSanPham();
            loadThuCung();
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
