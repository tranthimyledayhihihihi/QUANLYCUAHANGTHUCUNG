using System;
using System.Collections.Generic;
using System.Data; // Vẫn giữ để dùng DataTable nếu cần, hoặc dùng List
using System.Linq; // Quan trọng để truy vấn dữ liệu
using System.Windows.Forms;
using QuanLyThuCung.Class; // Namespace chứa FileXml và Models

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmBanHang : Form
    {
        // Khai báo các danh sách dữ liệu để hứng từ XML
        List<ThuCung> listThuCung;
        List<SanPham> listSanPham;
        List<DichVu> listDichVu;

        public frmBanHang()
        {
            InitializeComponent();
        }

        // 1. Sự kiện khi Form load lên
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đăng nhập
                if (HeThong.NhanVienDangNhap != null)
                {
                    this.Text = "Quản Lý Bán Hàng - Nhân viên: " + HeThong.NhanVienDangNhap.TenNhanVien;
                }

                // Tải dữ liệu từ XML lên lưới
                LoadDataThuCung();
                LoadDataSanPham();
                LoadDataDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        #region LOAD DỮ LIỆU TỪ XML
        private void LoadDataThuCung()
        {
            // Đọc XML và lọc những con có trạng thái "Còn hàng"
            listThuCung = FileXml.DocFile<ThuCung>("ThuCung.xml");
            var dsHienThi = listThuCung.Where(x => x.TrangThai == "Còn hàng" || string.IsNullOrEmpty(x.TrangThai)).ToList();
            dgvThuCung.DataSource = null;
            dgvThuCung.DataSource = dsHienThi;
        }

        private void LoadDataSanPham()
        {
            // Đọc XML và lọc những SP có số lượng tồn > 0
            listSanPham = FileXml.DocFile<SanPham>("SanPham.xml");
            var dsHienThi = listSanPham.Where(x => x.SoLuongTon > 0).ToList();
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = dsHienThi;
        }

        private void LoadDataDichVu()
        {
            // Đọc XML Dịch vụ
            listDichVu = FileXml.DocFile<DichVu>("DichVu.xml");
            dgvDichVu.DataSource = null;
            dgvDichVu.DataSource = listDichVu;
        }
        #endregion

        #region TÌM KHÁCH HÀNG (XML)
        private void btnTimKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSDT.Text)) return;

            try
            {
                // 1. Đọc danh sách khách hàng từ XML
                List<KhachHang> listKH = FileXml.DocFile<KhachHang>("KhachHang.xml");

                // 2. Tìm kiếm bằng LINQ
                var kh = listKH.FirstOrDefault(x => x.SDT == txtSDT.Text.Trim());

                if (kh != null)
                {
                    txtMaKhach.Text = kh.MaKhachHang;
                    txtTenKhach.Text = kh.TenKhachHang;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng! Vui lòng thêm mới.");
                    txtTenKhach.Text = "Khách vãng lai";
                    txtMaKhach.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }
        #endregion

        #region THÊM VÀO GIỎ HÀNG (Logic giữ nguyên, chỉ xử lý UI)
        private void dgvThuCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            // Xử lý an toàn khi click header
            if (dgvThuCung.Rows[e.RowIndex].Cells["MaThuCung"].Value == null) return;

            DataGridViewRow row = dgvThuCung.Rows[e.RowIndex];
            ThemVaoGio(
                row.Cells["MaThuCung"].Value.ToString(),
                row.Cells["TenThuCung"].Value.ToString(),
                "TC",
                1,
                Convert.ToDecimal(row.Cells["GiaBan"].Value)
            );
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvSanPham.Rows[e.RowIndex].Cells["MaSP"].Value == null) return;

            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
            ThemVaoGio(
                row.Cells["MaSP"].Value.ToString(),
                row.Cells["TenSP"].Value.ToString(),
                "SP",
                1,
                Convert.ToDecimal(row.Cells["DonGiaBan"].Value) // Chú ý tên cột DonGia hay DonGiaBan
            );
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvDichVu.Rows[e.RowIndex].Cells["MaDV"].Value == null) return;

            DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];
            ThemVaoGio(
                row.Cells["MaDV"].Value.ToString(),
                row.Cells["TenDV"].Value.ToString(),
                "DV",
                1,
                Convert.ToDecimal(row.Cells["GiaDV"].Value)
            );
        }

        private void ThemVaoGio(string ma, string ten, string loai, int sl, decimal gia)
        {
            // Kiểm tra trùng lặp trong giỏ hàng
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                if (row.Cells["MaHang"].Value != null && row.Cells["MaHang"].Value.ToString() == ma)
                {
                    // Nếu là Sản phẩm hoặc Dịch vụ thì cộng dồn số lượng
                    // Thú cưng thường bán từng con nên có thể không cộng dồn, nhưng ở đây ta cứ cộng
                    int currentSL = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    row.Cells["SoLuong"].Value = currentSL + 1;
                    row.Cells["ThanhTien"].Value = (currentSL + 1) * gia;
                    TinhTongTien();
                    return;
                }
            }

            // Nếu chưa có thì thêm dòng mới
            // Cấu trúc Add phải khớp với số cột bạn thiết kế trên Form (Design)
            // Giả sử thứ tự: MaHang, TenHang, LoaiHang, SoLuong, DonGia, ThanhTien
            dgvGioHang.Rows.Add(ma, ten, loai, sl, gia, sl * gia);
            TinhTongTien();
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                    tong += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
            }
            lblTongTien.Text = tong.ToString("#,###") + " VNĐ";
            lblTongTien.Tag = tong; // Lưu giá trị số vào Tag để tính toán sau
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.SelectedRows.Count > 0)
            {
                if (!dgvGioHang.SelectedRows[0].IsNewRow)
                {
                    dgvGioHang.Rows.RemoveAt(dgvGioHang.SelectedRows[0].Index);
                    TinhTongTien();
                }
            }
        }
        #endregion

        #region THANH TOÁN (XML - QUAN TRỌNG)
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count == 0 || (dgvGioHang.Rows.Count == 1 && dgvGioHang.Rows[0].IsNewRow)) return;

            // Validate
            if (string.IsNullOrEmpty(txtMaKhach.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước khi thanh toán!");
                return;
            }

            if (HeThong.NhanVienDangNhap == null)
            {
                MessageBox.Show("Phiên đăng nhập hết hạn. Vui lòng đăng nhập lại!");
                return;
            }

            try
            {
                // --- 1. TẠO HÓA ĐƠN ---
                List<HoaDon> listHD = FileXml.DocFile<HoaDon>("HoaDon.xml");

                // Tạo số hóa đơn (Giả lập Identity)
                int nextID = 1;
                if (listHD.Count > 0) nextID = listHD.Max(x => x.SoHoaDon) + 1;

                HoaDon hd = new HoaDon();
                hd.SoHoaDon = nextID;
                hd.MaNhanVien = HeThong.NhanVienDangNhap.MaNhanVien;
                hd.MaKhachHang = txtMaKhach.Text;
                hd.NgayLap = DateTime.Now;

                // Lấy tổng tiền từ Tag (hoặc parse lại từ text)
                if (lblTongTien.Tag != null)
                    hd.TongTien = Convert.ToInt32(Convert.ToDecimal(lblTongTien.Tag));
                else
                    hd.TongTien = 0;

                hd.DanhSachChiTiet = new List<ChiTietHoaDon>();

                // --- 2. XỬ LÝ CHI TIẾT & CẬP NHẬT KHO (IN-MEMORY) ---
                // Load dữ liệu kho hiện tại lên để trừ
                List<SanPham> khoSP = FileXml.DocFile<SanPham>("SanPham.xml");
                List<ThuCung> khoTC = FileXml.DocFile<ThuCung>("ThuCung.xml");

                foreach (DataGridViewRow row in dgvGioHang.Rows)
                {
                    if (row.Cells["MaHang"].Value == null) continue;

                    string ma = row.Cells["MaHang"].Value.ToString();
                    string loai = row.Cells["LoaiHang"].Value.ToString();
                    string ten = row.Cells["TenHang"].Value.ToString();
                    int sl = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    int gia = Convert.ToInt32(Convert.ToDecimal(row.Cells["DonGia"].Value));

                    // Thêm vào chi tiết hóa đơn
                    ChiTietHoaDon ct = new ChiTietHoaDon()
                    {
                        MaMatHang = ma,
                        LoaiMatHang = loai,
                        TenMatHang = ten,
                        SoLuong = sl,
                        DonGia = gia
                    };
                    hd.DanhSachChiTiet.Add(ct);

                    // Cập nhật kho (Trừ số lượng hoặc đổi trạng thái)
                    if (loai == "SP")
                    {
                        var sp = khoSP.FirstOrDefault(x => x.MaSP == ma);
                        if (sp != null)
                        {
                            if (sp.SoLuongTon < sl)
                            {
                                MessageBox.Show($"Sản phẩm {sp.TenSP} không đủ hàng tồn kho!");
                                return; // Dừng thanh toán
                            }
                            sp.SoLuongTon -= sl;
                        }
                    }
                    else if (loai == "TC")
                    {
                        var tc = khoTC.FirstOrDefault(x => x.MaThuCung == ma);
                        if (tc != null)
                        {
                            tc.TrangThai = "Đã bán"; // Đổi trạng thái
                        }
                    }
                }

                // --- 3. LƯU TẤT CẢ XUỐNG FILE XML ---
                // (Chỉ lưu khi mọi thứ ok để đảm bảo toàn vẹn dữ liệu)

                // Lưu Hóa đơn
                listHD.Add(hd);
                FileXml.GhiFile("HoaDon.xml", listHD);

                // Lưu lại kho Sản phẩm (Đã trừ tồn)
                FileXml.GhiFile("SanPham.xml", khoSP);

                // Lưu lại kho Thú cưng (Đã đổi trạng thái)
                FileXml.GhiFile("ThuCung.xml", khoTC);

                // --- 4. HOÀN TẤT ---
                MessageBox.Show("Thanh toán thành công! Mã HĐ: " + nextID);

                // Reset giao diện
                dgvGioHang.Rows.Clear();
                lblTongTien.Text = "0 VNĐ";
                lblTongTien.Tag = 0;

                // Load lại dữ liệu để cập nhật hiển thị (SP đã hết, TC đã bán sẽ ẩn đi)
                LoadDataSanPham();
                LoadDataThuCung();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán: " + ex.Message);
            }
        }
        #endregion
    }
}