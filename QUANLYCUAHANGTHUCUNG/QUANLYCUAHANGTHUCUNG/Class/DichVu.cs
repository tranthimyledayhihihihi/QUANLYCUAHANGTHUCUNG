namespace QuanLyThuCung.Class
{
    public class DichVu
    {
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public int GiaDV { get; set; }

        // Dòng này đã được sửa để có public setter
        public int ThoiGianThucHien { get; set; }
    }
}