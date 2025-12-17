using QuanLyCuaHangThuCung.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmChamCong : Form
    {
        FileXml Fxml = new FileXml();

        public frmChamCong()
        {
            InitializeComponent();
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            dtpNgayChamCong.ValueChanged += dtpNgayChamCong_ValueChanged;

            LoadNhanVien();
            LoadChamCong();
        }

        void LoadNhanVien()
        {
            DataTable dt = Fxml.HienThi("NhanVien.xml");
            cboNhanVien.DataSource = dt;
            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "MaNhanVien";
        }

        void LoadChamCong()
        {
            // Lấy toàn bộ dữ liệu từ XML
            DataTable dt = Fxml.HienThi("ChamCong.xml");

            // Lấy ngày đang chọn trên giao diện
            DateTime ngayChon = dtpNgayChamCong.Value;

            // Lọc dữ liệu theo Ngày, Tháng, Năm (Khớp với cấu trúc SQL)
            dt.DefaultView.RowFilter =
                $"Ngay = {ngayChon.Day} AND Thang = {ngayChon.Month} AND Nam = {ngayChon.Year}";

            // Hiển thị kết quả lên GridView
            dgvChamCong.DataSource = dt.DefaultView.ToTable();

            // Tùy chỉnh hiển thị cột nếu cần (ẩn cột ID tự tăng nếu muốn scannable hơn)
            if (dgvChamCong.Columns.Contains("Id"))
                dgvChamCong.Columns["Id"].Visible = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadChamCong();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null) return;

            string maNV = cboNhanVien.SelectedValue.ToString();
            DateTime ngayCham = dtpNgayChamCong.Value.Date;
            DateTime homNay = DateTime.Today;

            if (ngayCham > homNay)
            {
                MessageBox.Show("Không thể chấm công ngày trong tương lai!");
                return;
            }

            // ❌ Không cho chấm công ngày tương lai
            if (ngayCham > homNay)
            {
                MessageBox.Show(
                    "Không thể chấm công ngày trong tương lai!",
                    "Lỗi chấm công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ChamCong cc = new ChamCong();

            // Kiểm tra trùng lặp
            if (cc.kiemtraNgayThang(maNV, ngayCham.Day, ngayCham.Month, ngayCham.Year))
            {
                MessageBox.Show("Nhân viên này đã được xác nhận đi làm ngày hôm nay!");
                return;
            }

            // Xác nhận đi làm (Hàm này đã được bỏ GioChamCong ở bước trước)
            cc.XacNhanDiLam(maNV, ngayCham.Day, ngayCham.Month, ngayCham.Year);

            LoadChamCong();
            MessageBox.Show("Xác nhận đi làm thành công!");
        }

        private void dtpNgayChamCong_ValueChanged(object sender, EventArgs e)
        {
            LoadChamCong();
        }
    }
}