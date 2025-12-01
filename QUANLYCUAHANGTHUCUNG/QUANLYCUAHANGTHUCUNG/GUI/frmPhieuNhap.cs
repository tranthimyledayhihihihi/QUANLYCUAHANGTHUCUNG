using System;
using System.Collections.Generic;
using System.Linq; // Cần cái này để lọc và tìm kiếm dữ liệu
using System.Windows.Forms;
using QuanLyThuCung.Class; // Namespace chứa các class Model và FileXml

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadLichSuNhap();
            // Mặc định chọn nhập Sản phẩm
            radSanPham.Checked = true;
            // Gọi load combo lần đầu
            LoadComboBoxHangHoa();
        }

        // --- 1. TẢI LỊCH SỬ NHẬP (Dùng LINQ thay cho JOIN SQL) ---
        private void LoadLichSuNhap()
        {
            try
            {
                // 1. Đọc 2 file XML cần thiết
                List<PhieuNhap> listPN = FileXml.DocFile<PhieuNhap>("PhieuNhap.xml");
                List<NhanVien> listNV = FileXml.DocFile<NhanVien>("NhanVien.xml");

                // 2. Kết hợp (Join) để lấy tên nhân viên hiển thị lên Grid
                // Dùng LINQ để join 2 list lại với nhau
                var hienThi = from pn in listPN
                              join nv in listNV on pn.MaNhanVien equals nv.MaNhanVien
                              orderby pn.NgayLapPhieu descending // Sắp xếp mới nhất lên đầu
                              select new
                              {
                                  MaPhieu = pn.MaPhieu,
                                  MaMatHang = pn.MaMatHang,
                                  Loai = pn.LoaiMatHang == "SP" ? "Sản phẩm" : "Thú cưng",
                                  SoLuong = pn.SoLuongNhap,
                                  NgayNhap = pn.NgayLapPhieu,
                                  NguoiNhap = nv.TenNhanVien // Lấy tên thay vì mã
                              };

                // 3. Đổ dữ liệu vào Grid
                dgvPhieuNhap.DataSource = hienThi.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // --- 2. THAY ĐỔI LOẠI HÀNG (Load ComboBox từ XML) ---
        private void radSanPham_CheckedChanged(object sender, EventArgs e)
        {
            LoadComboBoxHangHoa();
        }

        private void LoadComboBoxHangHoa()
        {
            try
            {
                if (radSanPham.Checked)
                {
                    // Đọc file Sản Phẩm
                    List<SanPham> listSP = FileXml.DocFile<SanPham>("SanPham.xml");

                    cboMatHang.DataSource = listSP;
                    cboMatHang.DisplayMember = "TenSP"; // Hiển thị Tên
                    cboMatHang.ValueMember = "MaSP";    // Giá trị là Mã
                }
                else // Thú Cưng
                {
                    // Đọc file Thú Cưng
                    List<ThuCung> listTC = FileXml.DocFile<ThuCung>("ThuCung.xml");

                    cboMatHang.DataSource = listTC;
                    cboMatHang.DisplayMember = "TenThuCung";
                    cboMatHang.ValueMember = "MaThuCung";
                }
            }
            catch
            {
                // Bỏ qua lỗi nếu file chưa tồn tại
            }
        }

        // --- 3. XỬ LÝ NÚT NHẬP HÀNG (Lưu XML) ---
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (cboMatHang.SelectedValue == null) return;
            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0!");
                return;
            }

            try
            {
                // Lấy thông tin từ giao diện
                string maHang = cboMatHang.SelectedValue.ToString();
                string loaiHang = radSanPham.Checked ? "SP" : "TC";
                int soLuong = (int)numSoLuong.Value;

                // Lấy mã nhân viên đang đăng nhập (từ HeThong)
                string maNV = "";
                if (HeThong.NhanVienDangNhap != null)
                    maNV = HeThong.NhanVienDangNhap.MaNhanVien;
                else
                    maNV = "admin"; // Fallback nếu chưa đăng nhập (để test)

                // --- BƯỚC A: TẠO VÀ LƯU PHIẾU NHẬP ---
                List<PhieuNhap> dsPhieu = FileXml.DocFile<PhieuNhap>("PhieuNhap.xml");

                // Tạo ID tự tăng (Lấy ID lớn nhất + 1)
                int nextId = 1;
                if (dsPhieu.Count > 0)
                    nextId = dsPhieu.Max(x => x.MaPhieu) + 1;

                PhieuNhap pn = new PhieuNhap()
                {
                    MaPhieu = nextId,
                    MaMatHang = maHang,
                    LoaiMatHang = loaiHang,
                    MaNhanVien = maNV,
                    SoLuongNhap = soLuong,
                    NgayLapPhieu = DateTime.Now
                };

                dsPhieu.Add(pn);
                FileXml.GhiFile("PhieuNhap.xml", dsPhieu); // Lưu file phiếu nhập

                // --- BƯỚC B: CẬP NHẬT KHO (TĂNG SỐ LƯỢNG TỒN) ---
                if (loaiHang == "SP")
                {
                    List<SanPham> dsSP = FileXml.DocFile<SanPham>("SanPham.xml");
                    var sp = dsSP.FirstOrDefault(x => x.MaSP == maHang);
                    if (sp != null)
                    {
                        sp.SoLuongTon += soLuong; // Cộng dồn số lượng
                        FileXml.GhiFile("SanPham.xml", dsSP); // Lưu lại file SP
                    }
                }
                else // Thú Cưng
                {
                    List<ThuCung> dsTC = FileXml.DocFile<ThuCung>("ThuCung.xml");
                    var tc = dsTC.FirstOrDefault(x => x.MaThuCung == maHang);
                    if (tc != null)
                    {
                        tc.SoLuong += soLuong; // Cộng dồn số lượng thú cưng
                        // Có thể cập nhật thêm trạng thái nếu cần
                        // tc.TrangThai = "Còn hàng"; 
                        FileXml.GhiFile("ThuCung.xml", dsTC); // Lưu lại file TC
                    }
                }

                MessageBox.Show("Nhập hàng thành công!");
                LoadLichSuNhap(); // Load lại lưới để thấy phiếu mới
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập hàng: " + ex.Message);
            }
        }
    }
}