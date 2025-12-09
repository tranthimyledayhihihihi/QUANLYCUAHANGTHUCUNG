namespace QuanLyThuCung.Class
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int DonGia { get; set; }
        public int SoLuongTon { get; set; }
        public string LoaiSP { get; internal set; }
        public string DonViTinh { get; internal set; }
        public string MaNCC { get; internal set; }
    }
}