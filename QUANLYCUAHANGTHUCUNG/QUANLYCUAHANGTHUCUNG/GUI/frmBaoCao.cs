using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Threading.Tasks;
using QuanLyThuCung.Class;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmBaoCao : Form
    {
        private bool _isChartsInitialized = false;
        private bool _isFormReady = false;

        public frmBaoCao()
        {
            InitializeComponent();

            // GIẢI PHÁP TRIỆT ĐỂ: Tạm thời đặt kích thước tối thiểu cho chart
            if (chartDoanhThu != null)
            {
                chartDoanhThu.MinimumSize = new Size(100, 100);
                chartDoanhThu.Width = 100;
                chartDoanhThu.Height = 100;
            }

            if (chartThuCung != null)
            {
                chartThuCung.MinimumSize = new Size(100, 100);
                chartThuCung.Width = 100;
                chartThuCung.Height = 100;
            }
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            // Set ngày mặc định cho tab Doanh thu
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;
            
            // Đăng ký sự kiện SelectedIndexChanged cho TabControl
            if (tabControlBaoCao != null)
            {
                tabControlBaoCao.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            }
        }

        // PHƯƠNG THỨC ĐẢM BẢO CHART AN TOÀN
        private bool IsChartSafeToDraw(Chart chart)
        {
            if (chart == null) return false;
            if (!chart.IsHandleCreated) return false;
            if (!chart.Visible) return false;
            if (chart.Width <= 1 || chart.Height <= 1) return false;
            if (!chart.Created) return false;
            return true;
        }

        // Khởi tạo biểu đồ AN TOÀN
        private void InitializeChartsSafely()
        {
            try
            {
                if (!_isChartsInitialized && _isFormReady)
                {
                    // KHỞI TẠO CHART DOANH THU
                    if (chartDoanhThu != null && IsChartSafeToDraw(chartDoanhThu))
                    {
                        chartDoanhThu.Series.Clear();
                        chartDoanhThu.Titles.Clear();
                        
                        // Thêm title
                        chartDoanhThu.Titles.Add("Biểu đồ doanh thu theo ngày");
                        chartDoanhThu.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);
                        
                        // Tạo series
                        Series seriesDoanhThu = new Series("DoanhThu");
                        seriesDoanhThu.ChartType = SeriesChartType.Column;
                        seriesDoanhThu.Color = Color.FromArgb(65, 105, 225);
                        seriesDoanhThu.IsValueShownAsLabel = true;
                        seriesDoanhThu.LabelFormat = "#,##0 VNĐ";
                        chartDoanhThu.Series.Add(seriesDoanhThu);
                        
                        // Cấu hình ChartArea
                        chartDoanhThu.ChartAreas[0].AxisX.Title = "Ngày";
                        chartDoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
                        chartDoanhThu.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";
                    }

                    // KHỞI TẠO CHART THÚ CƯNG
                    if (chartThuCung != null && IsChartSafeToDraw(chartThuCung))
                    {
                        chartThuCung.Series.Clear();
                        chartThuCung.Titles.Clear();
                        
                        // Thêm title
                        chartThuCung.Titles.Add("Thống kê trạng thái thú cưng");
                        chartThuCung.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);
                        
                        // Tạo series
                        Series seriesTrangThai = new Series("TrangThai");
                        seriesTrangThai.ChartType = SeriesChartType.Pie;
                        seriesTrangThai.IsValueShownAsLabel = true;
                        seriesTrangThai.Label = "#VALX: #VALY (#PERCENT{P0})";
                        chartThuCung.Series.Add(seriesTrangThai);
                    }
                    
                    _isChartsInitialized = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khởi tạo biểu đồ: " + ex.Message);
                _isChartsInitialized = false;
            }
        }

        private void frmBaoCao_Shown(object sender, EventArgs e)
        {
            // Đánh dấu form đã sẵn sàng
            _isFormReady = true;
            
            // Hiển thị chart sau khi form đã render xong
            if (chartDoanhThu != null) 
            {
                chartDoanhThu.Visible = true;
                chartDoanhThu.Refresh();
            }
            if (chartThuCung != null) 
            {
                chartThuCung.Visible = true;
                chartThuCung.Refresh();
            }
            
            // Delay một chút để đảm bảo controls đã có kích thước
            Task.Delay(100).ContinueWith(t =>
            {
                if (!this.IsDisposed && this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        InitializeChartsSafely();
                        LoadDataForCurrentTab();
                    }));
                }
            });
        }

        // Tải dữ liệu cho tab hiện tại
        private void LoadDataForCurrentTab()
        {
            if (!_isFormReady || this.IsDisposed) return;

            try
            {
                this.SuspendLayout();
                
                // Xác định tab hiện tại
                int selectedIndex = 0;
                if (tabControlBaoCao != null)
                {
                    selectedIndex = tabControlBaoCao.SelectedIndex;
                }
                
                switch (selectedIndex)
                {
                    case 0: // Doanh thu
                        LoadBaoCaoDoanhThu();
                        break;
                    case 1: // Tồn kho
                        LoadBaoCaoTonKho();
                        break;
                    case 2: // Thú cưng
                        LoadThongKeThuCung();
                        break;
                }
            }
            finally
            {
                this.ResumeLayout();
            }
        }

        #region 1. BÁO CÁO DOANH THU (Tab 1)
        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            LoadBaoCaoDoanhThu();
        }

        private void LoadBaoCaoDoanhThu()
        {
            if (!_isFormReady) return;

            try
            {
                // 1. Lấy dữ liệu từ XML
                List<HoaDon> listHD = FileXml.DocFile<HoaDon>("HoaDon.xml");

                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

                var danhSachLoc = listHD.Where(x => x.NgayLap >= tuNgay && x.NgayLap <= denNgay).ToList();

                // 2. Đổ vào Grid
                dgvDoanhThu.DataSource = null;
                dgvDoanhThu.DataSource = danhSachLoc;

                // Điều chỉnh cột
                if (dgvDoanhThu.Rows.Count > 0)
                {
                    dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    // Ẩn cột không cần thiết nếu có
                    if (dgvDoanhThu.Columns.Contains("MaHD"))
                        dgvDoanhThu.Columns["MaHD"].HeaderText = "Mã HĐ";
                    if (dgvDoanhThu.Columns.Contains("NgayLap"))
                        dgvDoanhThu.Columns["NgayLap"].HeaderText = "Ngày lập";
                    if (dgvDoanhThu.Columns.Contains("TongTien"))
                        dgvDoanhThu.Columns["TongTien"].HeaderText = "Tổng tiền";
                }

                // 3. Tính tổng tiền
                long tongDoanhThu = danhSachLoc.Sum(x => (long)x.TongTien);
                if (lblTongDoanhThu != null)
                    lblTongDoanhThu.Text = tongDoanhThu.ToString("#,###") + " VNĐ";

                // 4. Vẽ biểu đồ cột (Nhóm theo ngày)
                var dataChart = danhSachLoc
                    .GroupBy(x => x.NgayLap.ToString("dd/MM"))
                    .Select(g => new {
                        Ngay = g.Key,
                        TongTien = g.Sum(x => x.TongTien)
                    })
                    .OrderBy(x => x.Ngay)
                    .ToList();

                // VẼ BIỂU ĐỒ AN TOÀN - SỬA LỖI Ở ĐÂY
                DrawDoanhThuChartSafely(dataChart);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo doanh thu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SỬA LẠI PHƯƠNG THỨC NÀY - XÓA THAM SỐ HOẶC SỬA KIỂU
        private void DrawDoanhThuChartSafely(dynamic dataChart = null)
        {
            if (chartDoanhThu == null) return;
            
            // Kiểm tra điều kiện an toàn
            if (!IsChartSafeToDraw(chartDoanhThu))
            {
                // Nếu chưa an toàn, lên lịch vẽ lại sau
                this.BeginInvoke(new Action(() => DrawDoanhThuChartSafely(dataChart)), null);
                return;
            }

            try
            {
                // Đảm bảo chart đã được khởi tạo
                if (!_isChartsInitialized)
                {
                    InitializeChartsSafely();
                }

                // Kiểm tra series tồn tại
                if (chartDoanhThu.Series.IndexOf("DoanhThu") == -1)
                {
                    InitializeChartsSafely();
                }

                // Xóa dữ liệu cũ
                chartDoanhThu.Series["DoanhThu"].Points.Clear();
                
                // Kiểm tra nếu dataChart là null hoặc rỗng
                if (dataChart != null && dataChart.Any)
                {
                    foreach (var item in dataChart)
                    {
                        try
                        {
                            DataPoint point = new DataPoint();
                            point.SetValueXY(item.Ngay, item.TongTien);
                            point.Label = item.TongTien.ToString("#,##0");
                            chartDoanhThu.Series["DoanhThu"].Points.Add(point);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Lỗi thêm điểm dữ liệu: " + ex.Message);
                        }
                    }
                    
                    // Xóa title không có dữ liệu nếu có
                    if (chartDoanhThu.Titles.Count > 1)
                    {
                        for (int i = chartDoanhThu.Titles.Count - 1; i >= 1; i--)
                        {
                            chartDoanhThu.Titles.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    // Hiển thị thông báo không có dữ liệu
                    if (chartDoanhThu.Titles.Count <= 1)
                    {
                        chartDoanhThu.Titles.Add("(Không có dữ liệu trong khoảng thời gian này)");
                        chartDoanhThu.Titles[1].Font = new Font("Arial", 10, FontStyle.Italic);
                        chartDoanhThu.Titles[1].ForeColor = Color.Gray;
                    }
                }
                
                // Sử dụng BeginInvoke để vẽ bất đồng bộ
                this.BeginInvoke(new Action(() =>
                {
                    try
                    {
                        chartDoanhThu.Invalidate();
                        chartDoanhThu.Update();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi vẽ biểu đồ doanh thu: " + ex.Message);
                    }
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong DrawDoanhThuChartSafely: " + ex.Message);
            }
        }
        #endregion

        #region 2. BÁO CÁO TỒN KHO (Tab 2)
        private void LoadBaoCaoTonKho()
        {
            try
            {
                List<SanPham> listSP = FileXml.DocFile<SanPham>("SanPham.xml");
                var spSapHet = listSP.Where(x => x.SoLuongTon <= 10).OrderBy(x => x.SoLuongTon).ToList();

                dgvTonKho.DataSource = null;
                dgvTonKho.DataSource = spSapHet;

                // Điều chỉnh cột
                if (dgvTonKho.Rows.Count > 0)
                {
                    dgvTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    // Tô màu cảnh báo cho hàng sắp hết
                    foreach (DataGridViewRow row in dgvTonKho.Rows)
                    {
                        if (row.Cells["SoLuongTon"].Value != null)
                        {
                            int soLuong = Convert.ToInt32(row.Cells["SoLuongTon"].Value);
                            if (soLuong <= 5)
                                row.DefaultCellStyle.BackColor = Color.LightPink;
                            else if (soLuong <= 10)
                                row.DefaultCellStyle.BackColor = Color.LightYellow;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải tồn kho: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region 3. THỐNG KÊ THÚ CƯNG (Tab 3)
        private void LoadThongKeThuCung()
        {
            if (!_isFormReady) return;

            try
            {
                List<ThuCung> listTC = FileXml.DocFile<ThuCung>("ThuCung.xml");
                dgvThuCung.DataSource = null;
                dgvThuCung.DataSource = listTC;

                // Điều chỉnh cột
                if (dgvThuCung.Rows.Count > 0)
                {
                    dgvThuCung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                // Thống kê trạng thái
                int conHang = listTC.Count(x => x.TrangThai == "Còn hàng" || string.IsNullOrEmpty(x.TrangThai));
                int daBan = listTC.Count(x => x.TrangThai == "Đã bán");
                int tongSo = listTC.Count;

                // VẼ BIỂU ĐỒ AN TOÀN
                DrawThuCungChartSafely(conHang, daBan, tongSo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê thú cưng: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // PHƯƠNG THỨC VẼ BIỂU ĐỒ THÚ CƯNG AN TOÀN
        private void DrawThuCungChartSafely(int conHang, int daBan, int tongSo)
        {
            if (chartThuCung == null) return;
            
            // Kiểm tra điều kiện an toàn
            if (!IsChartSafeToDraw(chartThuCung))
            {
                // Nếu chưa an toàn, lên lịch vẽ lại sau
                this.BeginInvoke(new Action(() => DrawThuCungChartSafely(conHang, daBan, tongSo)), null);
                return;
            }

            try
            {
                // Đảm bảo chart đã được khởi tạo
                if (!_isChartsInitialized)
                {
                    InitializeChartsSafely();
                }

                // Kiểm tra series tồn tại
                if (chartThuCung.Series.IndexOf("TrangThai") == -1)
                {
                    InitializeChartsSafely();
                }

                // Xóa dữ liệu cũ
                chartThuCung.Series["TrangThai"].Points.Clear();
                
                if (tongSo > 0)
                {
                    // Thêm điểm dữ liệu
                    DataPoint p1 = new DataPoint();
                    p1.SetValueXY("Còn hàng", conHang);
                    p1.Color = Color.LightGreen;
                    p1.Label = "#PERCENT{P0}";
                    chartThuCung.Series["TrangThai"].Points.Add(p1);

                    DataPoint p2 = new DataPoint();
                    p2.SetValueXY("Đã bán", daBan);
                    p2.Color = Color.LightCoral;
                    p2.Label = "#PERCENT{P0}";
                    chartThuCung.Series["TrangThai"].Points.Add(p2);
                    
                    // Xóa title không có dữ liệu nếu có
                    if (chartThuCung.Titles.Count > 1)
                    {
                        for (int i = chartThuCung.Titles.Count - 1; i >= 1; i--)
                        {
                            chartThuCung.Titles.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    // Hiển thị thông báo không có dữ liệu
                    if (chartThuCung.Titles.Count <= 1)
                    {
                        chartThuCung.Titles.Add("(Không có dữ liệu thú cưng)");
                        chartThuCung.Titles[1].Font = new Font("Arial", 10, FontStyle.Italic);
                        chartThuCung.Titles[1].ForeColor = Color.Gray;
                    }
                }
                
                // Sử dụng BeginInvoke để vẽ bất đồng bộ
                this.BeginInvoke(new Action(() =>
                {
                    try
                    {
                        chartThuCung.Invalidate();
                        chartThuCung.Update();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi vẽ biểu đồ thú cưng: " + ex.Message);
                    }
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong DrawThuCungChartSafely: " + ex.Message);
            }
        }
        #endregion

        // Xử lý khi chuyển tab
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Visible && this.Width > 10 && this.IsHandleCreated && _isFormReady)
            {
                LoadDataForCurrentTab();
            }
        }

        // Xử lý khi form thay đổi kích thước
        private void frmBaoCao_Resize(object sender, EventArgs e)
        {
            if (this.Visible && this.Width > 10 && this.Height > 10 && this.IsHandleCreated && _isFormReady)
            {
                // Refresh biểu đồ khi thay đổi kích thước
                this.BeginInvoke(new Action(() =>
                {
                    if (tabControlBaoCao != null)
                    {
                        int selectedIndex = tabControlBaoCao.SelectedIndex;
                        
                        if (selectedIndex == 0) // Doanh thu
                        {
                            chartDoanhThu?.Invalidate();
                        }
                        else if (selectedIndex == 2) // Thú cưng
                        {
                            chartThuCung?.Invalidate();
                        }
                    }
                }));
            }
        }

        // Xử lý khi form đóng
        private void frmBaoCao_FormClosing(object sender, FormClosingEventArgs e)
        {
            _isFormReady = false;
            
            // Dọn dẹp tài nguyên AN TOÀN
            if (chartDoanhThu != null && !chartDoanhThu.IsDisposed)
            {
                try
                {
                    chartDoanhThu.Series.Clear();
                }
                catch { }
            }
            
            if (chartThuCung != null && !chartThuCung.IsDisposed)
            {
                try
                {
                    chartThuCung.Series.Clear();
                }
                catch { }
            }
        }
    }
}