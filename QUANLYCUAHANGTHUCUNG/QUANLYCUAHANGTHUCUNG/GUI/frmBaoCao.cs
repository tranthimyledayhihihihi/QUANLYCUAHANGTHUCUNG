using QuanLyCuaHangThuCung.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung
{
    public partial class frmBaoCao : Form
    {
        FileXml Fxml = new FileXml();

        SanPham spBLL = new SanPham();
        ThuCung tcBLL = new ThuCung();
        HoaDonBLL hdBLL = new HoaDonBLL();

        DataTable dtHD, dtCT, dtSP, dtTC;

        public frmBaoCao()
        {
            InitializeComponent();
            LoadAllData();
        }

        // =====================================================
        //  LOAD TẤT CẢ DATA
        // =====================================================
        private void LoadAllData()
        {
            dtSP = spBLL.LoadTable();
            dtTC = tcBLL.Load();
            dtHD = Fxml.HienThi("HoaDon.xml");
            dtCT = Fxml.HienThi("ChiTietHoaDon.xml");

            dgvSanPham.DataSource = dtSP;
            dgvThuCung.DataSource = dtTC;
            dgvHoaDon.DataSource = dtHD;
        }

        // =====================================================
        //  THỐNG KÊ THEO NGÀY
        // =====================================================
        private void btnTKNgay_Click(object sender, EventArgs e)
        {
            DateTime from = dtFrom.Value.Date;
            DateTime to = dtTo.Value.Date;

            var hdFilter = dtHD.AsEnumerable()
                .Where(r =>
                {
                    DateTime d = DateTime.Parse(r.Field<string>("NgayLap"));
                    return d >= from && d <= to;
                });

            DoThongKe(hdFilter);
        }

        // =====================================================
        //  THỐNG KÊ THEO THÁNG
        // =====================================================
        private void btnTKThang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboThang.Text) || string.IsNullOrEmpty(cboNam.Text))
            {
                MessageBox.Show("Hãy chọn tháng và năm!");
                return;
            }

            int thang = int.Parse(cboThang.Text);
            int nam = int.Parse(cboNam.Text);

            var hdFilter = dtHD.AsEnumerable()
                .Where(r =>
                {
                    DateTime d = DateTime.Parse(r.Field<string>("NgayLap"));
                    return d.Month == thang && d.Year == nam;
                });

            DoThongKe(hdFilter);
            VeBieuDoDoanhThuTheoNam(nam);
        }

        // =====================================================
        //  XỬ LÝ TÍNH TOÁN TỔNG HỢP
        // =====================================================
        private void DoThongKe(IEnumerable<DataRow> hdFilter)
        {
            lblTongHoaDon.Text = hdFilter.Count().ToString();

            lblTongDoanhThu.Text = hdFilter.Sum(r => r.Field<int>("TongTien"))
                                           .ToString("#,###");

            var listSoHD = hdFilter.Select(r => r.Field<int>("SoHoaDon")).ToList();

            var ct = dtCT.AsEnumerable()
                .Where(r => listSoHD.Contains(r.Field<int>("SoHoaDon")));

            lblSanPhamDaBan.Text = ct.Where(r => r.Field<string>("LoaiMatHang") == "SP")
                                     .Sum(r => r.Field<int>("SoLuong"))
                                     .ToString();

            lblThuCungDaBan.Text = ct.Where(r => r.Field<string>("LoaiMatHang") == "TC")
                                     .Count()
                                     .ToString();
        }

        // =====================================================
        //  VẼ BIỂU ĐỒ DOANH THU THEO NĂM
        // =====================================================
        private void VeBieuDoDoanhThuTheoNam(int nam)
        {
            chartDoanhThu.Series.Clear();
            chartDoanhThu.Titles.Clear();

            chartDoanhThu.Titles.Add("Biểu đồ doanh thu năm " + nam);

            var series = chartDoanhThu.Series.Add("Doanh Thu");
            series.ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            for (int thang = 1; thang <= 12; thang++)
            {
                var tong = dtHD.AsEnumerable()
                    .Where(r =>
                    {
                        DateTime d = DateTime.Parse(r.Field<string>("NgayLap"));
                        return d.Month == thang && d.Year == nam;
                    })
                    .Sum(r => r.Field<int>("TongTien"));

                series.Points.AddXY("T" + thang, tong);
            }
        }

        // =====================================================
        //  IN HÓA ĐƠN
        // =====================================================
        PrintDocument printHD = new PrintDocument();
        DataTable hdPrint, ctPrint;

        private void btnInHD_Click(object sender, EventArgs e)
        {
            hdPrint = dtHD;
            ctPrint = dtCT;

            printHD.PrintPage += PrintHD_PrintPage;
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = printHD;
            dlg.Width = 900;
            dlg.Height = 700;
            dlg.ShowDialog();
        }

        private void PrintHD_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 30;

            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG",
                new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 220, y);

            y += 40;
            e.Graphics.DrawString($"Ngày in: {DateTime.Now:dd/MM/yyyy}",
                new Font("Arial", 10), Brushes.Black, 50, y);

            y += 30;
            e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
            y += 20;

            foreach (DataRow hd in hdPrint.Rows)
            {
                e.Graphics.DrawString("Hóa đơn #" + hd["SoHoaDon"],
                    new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, y);
                y += 25;

                e.Graphics.DrawString($"Khách hàng: {hd["MaKhachHang"]}", new Font("Arial", 11), Brushes.Black, 50, y);
                y += 20;

                e.Graphics.DrawString($"Nhân viên: {hd["MaNhanVien"]}", new Font("Arial", 11), Brushes.Black, 50, y);
                y += 20;

                e.Graphics.DrawString($"Ngày lập: {hd["NgayLap"]}", new Font("Arial", 11), Brushes.Black, 50, y);
                y += 20;

                e.Graphics.DrawString($"Tổng tiền: {hd["TongTien"]}", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 50, y);
                y += 30;

                e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
                y += 20;
            }
        }
    }
}
