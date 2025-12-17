using iTextSharp.text;
using iTextSharp.text.pdf;
using QuanLyCuaHangThuCung.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace QuanLyCuaHangThuCung
{
    public partial class frmBaoCao : Form
    {
        FileXml Fxml = new FileXml();
        DataTable dtHD, dtCT;

        public frmBaoCao()
        {
            InitializeComponent();
            LoadData();
            LoadComboThangNam();
            KhoiTaoChart();
        }

        // ================= LOAD DATA =================
        private void LoadData()
        {
            dtHD = Fxml.HienThi("HoaDon.xml");
            dtCT = Fxml.HienThi("ChiTietHoaDon.xml");
            dgvHoaDon.DataSource = dtHD;
        }

        private void LoadComboThangNam()
        {
            cboThang.Items.Clear();
            for (int i = 1; i <= 12; i++) cboThang.Items.Add(i);

            cboNam.Items.Clear();
            for (int i = DateTime.Now.Year - 5; i <= DateTime.Now.Year; i++)
                cboNam.Items.Add(i);

            cboThang.SelectedIndex = 0;
            cboNam.SelectedIndex = cboNam.Items.Count - 1;
        }

        // ================= CHART INIT =================
        private void KhoiTaoChart()
        {
            chartBaoCao.ChartAreas.Clear();
            ChartArea area = new ChartArea("MainArea");
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartBaoCao.ChartAreas.Add(area);
        }

        // ================= THỐNG KÊ NGÀY =================
        private void btnTKNgay_Click(object sender, EventArgs e)
        {
            DateTime from = dtFrom.Value.Date;
            DateTime to = dtTo.Value.Date;

            var list = dtHD.AsEnumerable()
                .Where(r =>
                {
                    DateTime d = DateTime.Parse(r["NgayLap"].ToString());
                    return d >= from && d <= to;
                });

            DoThongKe(list);
            VeBieuDoSoSanh_SP_TC();
        }

        // ================= THỐNG KÊ THÁNG =================
        private void btnTKThang_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cboThang.Text);
            int nam = int.Parse(cboNam.Text);

            var list = dtHD.AsEnumerable()
                .Where(r =>
                {
                    DateTime d = DateTime.Parse(r["NgayLap"].ToString());
                    return d.Month == thang && d.Year == nam;
                });

            DoThongKe(list);
            VeBieuDoDuong_DoanhThuTheoNam(nam);
        }

        // ================= TÍNH TOÁN =================
        private void DoThongKe(IEnumerable<DataRow> list)
        {
            lblTongHoaDon.Text = $"🧾 Tổng hóa đơn: {list.Count()}";

            int tong = list.Sum(r => Convert.ToInt32(r["TongTien"]));
            lblTongDoanhThu.Text = $"💰 Tổng doanh thu: {tong:#,###} VNĐ";

            var soHD = list.Select(r => Convert.ToInt32(r["SoHoaDon"])).ToList();

            var ct = dtCT.AsEnumerable()
                .Where(r => soHD.Contains(Convert.ToInt32(r["SoHoaDon"])));

            lblSanPhamDaBan.Text =
                $"📦 Sản phẩm đã bán: {ct.Where(r => r["LoaiMatHang"].ToString() == "SP").Sum(r => Convert.ToInt32(r["SoLuong"]))}";

            lblThuCungDaBan.Text =
                $"🐾 Thú cưng đã bán: {ct.Where(r => r["LoaiMatHang"].ToString() == "TC").Count()}";
        }

        // ================= 📈 BIỂU ĐỒ ĐƯỜNG =================
        private void VeBieuDoDuong_DoanhThuTheoNam(int nam)
        {
            chartBaoCao.Series.Clear();
            chartBaoCao.Titles.Clear();

            chartBaoCao.Titles.Add($"📈 Doanh thu theo tháng năm {nam}");

            Series s = new Series("Doanh thu");
            s.ChartType = SeriesChartType.Line;
            s.BorderWidth = 3;
            s.MarkerStyle = MarkerStyle.Circle;
            s.MarkerSize = 8;
            s.IsValueShownAsLabel = true;
            s.ChartArea = "MainArea";

            for (int i = 1; i <= 12; i++)
            {
                int tong = dtHD.AsEnumerable()
                    .Where(r =>
                    {
                        DateTime d = DateTime.Parse(r["NgayLap"].ToString());
                        return d.Month == i && d.Year == nam;
                    })
                    .Sum(r => Convert.ToInt32(r["TongTien"]));

                s.Points.AddXY("T" + i, tong);
            }

            chartBaoCao.Series.Add(s);
        }

        // ================= 📊 SO SÁNH SP vs TC =================
        private void VeBieuDoSoSanh_SP_TC()
        {
            chartBaoCao.Series.Clear();
            chartBaoCao.Titles.Clear();

            chartBaoCao.Titles.Add("📊 So sánh Sản phẩm & Thú cưng");

            Series s = new Series("Số lượng");
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;
            s.ChartArea = "MainArea";

            int sp = dtCT.AsEnumerable()
                .Where(r => r["LoaiMatHang"].ToString() == "SP")
                .Sum(r => Convert.ToInt32(r["SoLuong"]));

            int tc = dtCT.AsEnumerable()
                .Where(r => r["LoaiMatHang"].ToString() == "TC")
                .Count();

            s.Points.AddXY("Sản phẩm", sp);
            s.Points.AddXY("Thú cưng", tc);

            chartBaoCao.Series.Add(s);
        }

        // ================= 🧾 XUẤT PDF =================
        private void btnXuatPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "BaoCaoDoanhThu.pdf";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            DateTime from = dtFrom.Value.Date;
            DateTime to = dtTo.Value.Date;

            var list = dtHD.AsEnumerable()
                .Where(r =>
                {
                    DateTime d = DateTime.Parse(r["NgayLap"].ToString());
                    return d >= from && d <= to;
                });

            DataTable dtLoc = list.Any() ? list.CopyToDataTable() : dtHD.Clone();

            BaoCaoController controller = new BaoCaoController();
            controller.XuatPDF(
                sfd.FileName,
                from,
                to,
                dtLoc,
                dtCT,
                chartBaoCao
            );

            MessageBox.Show("Xuất PDF thành công!", "OK");
        }


    }
}
