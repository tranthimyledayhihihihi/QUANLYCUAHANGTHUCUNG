using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangThuCung.Class;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmBanHang : Form
    {
        FileXml Fxml = new FileXml();     // ĐÃ CÓ TRONG DỰ ÁN CỦA BẠN

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

            setupGioHang();
        }

        // ================================
        //       LOAD COMBOBOX
        // ================================
        private void loadNhanVien()
        {
            DataTable dt = Fxml.HienThi("NhanVien.xml");

            cboNhanVien.DataSource = dt;
            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "MaNhanVien";
        }

        private void loadKhachHang()
        {
            DataTable dt = Fxml.HienThi("KhachHang.xml");

            cboKhachHang.DataSource = dt;
            cboKhachHang.DisplayMember = "TenKhachHang";
            cboKhachHang.ValueMember = "MaKhachHang";
        }

        // ================================
        //       LOAD DỮ LIỆU TABCONTROL
        // ================================
        private void loadSanPham()
        {
            DataTable dt = Fxml.HienThi("SanPham.xml");

            dgvSanPham.DataSource = dt;
        }

        private void loadThuCung()
        {
            DataTable dt = Fxml.HienThi("ThuCung.xml");

            dgvThuCung.DataSource = dt;
        }

        private void loadDichVu()
        {
            DataTable dt = Fxml.HienThi("DichVu.xml");

            dgvDichVu.DataSource = dt;
        }

        // ================================
        //     TẠO GIỎ HÀNG MẶC ĐỊNH
        // ================================
        private void setupGioHang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHang");
            dt.Columns.Add("TenHang");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("ThanhTien");

            dgvGioHang.DataSource = dt;
        }

        //=========================================================
        //   NÚT "THÊM VÀO GIỎ" → tự động lấy item đúng tab đang chọn
        //=========================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataGridView dgv = null;

            if (tabMatHang.SelectedTab == tabSanPham)
                dgv = dgvSanPham;
            else if (tabMatHang.SelectedTab == tabThuCung)
                dgv = dgvThuCung;
            else
                dgv = dgvDichVu;

            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng!");
                return;
            }

            string ma = dgv.CurrentRow.Cells[0].Value.ToString();
            string ten = dgv.CurrentRow.Cells[1].Value.ToString();
            int soluong = 1;
            double dongia = Convert.ToDouble(dgv.CurrentRow.Cells["Gia"].Value);
            double thanhtien = soluong * dongia;

            DataTable cart = (DataTable)dgvGioHang.DataSource;

            cart.Rows.Add(ma, ten, soluong, dongia, thanhtien);

            tinhTongTien();
        }

        //=========================================================
        //                      XÓA GIỎ
        //=========================================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null)
            {
                dgvGioHang.Rows.Remove(dgvGioHang.CurrentRow);
                tinhTongTien();
            }
        }

        //=========================================================
        //                  TÍNH TỔNG TIỀN
        //=========================================================
        private void tinhTongTien()
        {
            double tong = 0;

            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                    tong += Convert.ToDouble(row.Cells["ThanhTien"].Value);
            }

            txtTongTien.Text = tong.ToString("N0");
        }

        //=========================================================
        //                  NÚT THANH TOÁN
        //=========================================================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }

            MessageBox.Show("Thanh toán thành công!", "Hoàn tất");

            // Reset giỏ hàng
            setupGioHang();
            txtTongTien.Text = "0";
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
