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
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            dtpNgayChamCong.ValueChanged += dtpNgayChamCong_ValueChanged;

            LoadNhanVien();
            LoadChamCong();
        }

        public frmChamCong()
        {
            InitializeComponent();
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
            DataTable dt = Fxml.HienThi("ChamCong.xml");

            DateTime ngayChon = dtpNgayChamCong.Value;

            dt.DefaultView.RowFilter =
                $"Ngay = {ngayChon.Day} AND Thang = {ngayChon.Month} AND Nam = {ngayChon.Year}";

            DataTable dtView = dt.DefaultView.ToTable();

            if (!dtView.Columns.Contains("TrangThai"))
                dtView.Columns.Add("TrangThai");

            foreach (DataRow row in dtView.Rows)
            {
                if (row["GioChamCong"] != DBNull.Value)
                {
                    TimeSpan gioCham = TimeSpan.Parse(row["GioChamCong"].ToString());
                    TimeSpan gioQD = new TimeSpan(8, 0, 0);

                    row["TrangThai"] = gioCham > gioQD ? "Trễ" : "Đúng giờ";
                }
            }

            dgvChamCong.DataSource = dtView;

            // 🔴 Tô đỏ nhân viên chấm công trễ
            foreach (DataGridViewRow row in dgvChamCong.Rows)
            {
                if (row.Cells["TrangThai"].Value?.ToString() == "Trễ")
                {
                    row.Cells["MaNhanVien"].Style.ForeColor = Color.Red;
                    row.Cells["TrangThai"].Style.ForeColor = Color.Red;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadChamCong();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            string maNV = cboNhanVien.SelectedValue.ToString();
            DateTime ngayCham = dtpNgayChamCong.Value.Date;
            DateTime homNay = DateTime.Today;

            // ❌ Không cho chấm công ngày quá khứ
            if (ngayCham < homNay)
            {
                MessageBox.Show(
                    $"Không thể chấm công ngày {ngayCham:dd/MM/yyyy}",
                    "Lỗi chấm công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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

            if (cc.kiemtraNgayThang(maNV, ngayCham.Day, ngayCham.Month, ngayCham.Year))
            {
                MessageBox.Show("Nhân viên đã chấm công ngày này!");
                return;
            }

            cc.XacNhanDiLam(maNV, ngayCham.Day, ngayCham.Month, ngayCham.Year);

            LoadChamCong();
            MessageBox.Show("Chấm công thành công!");
        }

        private void dtpNgayChamCong_ValueChanged(object sender, EventArgs e)
        {
            LoadChamCong();
        }

    }
}
