using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

// 👇 alias tránh trùng
using PdfFont = iTextSharp.text.Font;
using PdfImage = iTextSharp.text.Image;

namespace QuanLyCuaHangThuCung.Class
{
    public class BaoCaoPDFService
    {
        public void XuatBaoCaoPDF(
            string filePath,
            string tieuDe,
            DateTime tuNgay,
            DateTime denNgay,
            DataTable dtHoaDon,
            DataTable dtChiTiet,
            Chart chart)
        {
            Document doc = new Document(PageSize.A4, 30, 30, 30, 30);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // ===== FONT PDF =====
            string fontPath = Application.StartupPath + @"\Data\font\ARIAL.TTF";

            PdfFont titleFont = TaoFont(fontPath, 18, PdfFont.BOLD);
            PdfFont headerFont = TaoFont(fontPath, 11, PdfFont.BOLD);
            PdfFont normalFont = TaoFont(fontPath, 10);

            // ===== TIÊU ĐỀ =====
            doc.Add(new Paragraph(tieuDe, titleFont)
            {
                Alignment = Element.ALIGN_CENTER
            });
            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph(
                $"Thời gian: {tuNgay:dd/MM/yyyy} - {denNgay:dd/MM/yyyy}", normalFont));
            doc.Add(new Paragraph($"Ngày in: {DateTime.Now:dd/MM/yyyy}", normalFont));
            doc.Add(new Paragraph("\n"));

            // ===== THỐNG KÊ =====
            int tongHD = dtHoaDon.Rows.Count;
            int tongTien = dtHoaDon.AsEnumerable()
                .Sum(r => Convert.ToInt32(r["TongTien"]));

            doc.Add(new Paragraph($"🧾 Tổng hóa đơn: {tongHD}", headerFont));
            doc.Add(new Paragraph($"💰 Tổng doanh thu: {tongTien:#,###} VNĐ", headerFont));
            doc.Add(new Paragraph("\n"));

            // ===== BẢNG =====
            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 2f, 3f, 3f, 3f });

            AddCell(table, "Số HĐ", headerFont);
            AddCell(table, "Ngày lập", headerFont);
            AddCell(table, "Khách hàng", headerFont);
            AddCell(table, "Tổng tiền", headerFont);

            foreach (DataRow row in dtHoaDon.Rows)
            {
                AddCell(table, row["SoHoaDon"].ToString(), normalFont);
                AddCell(table,
                    Convert.ToDateTime(row["NgayLap"]).ToString("dd/MM/yyyy"), normalFont);
                AddCell(table, row["TenKhachHang"].ToString(), normalFont);
                AddCell(table,
                    $"{Convert.ToInt32(row["TongTien"]):#,###}", normalFont);
            }

            doc.Add(table);
            doc.Add(new Paragraph("\n"));

            // ===== BIỂU ĐỒ =====
            string chartPath = Path.Combine(Path.GetTempPath(), "chart.png");
            chart.SaveImage(chartPath, ChartImageFormat.Png);

            PdfImage chartImg = PdfImage.GetInstance(chartPath);
            chartImg.ScaleToFit(500f, 300f);
            chartImg.Alignment = Element.ALIGN_CENTER;
            doc.Add(chartImg);

            doc.Close();
            File.Delete(chartPath);
        }

        private iTextSharp.text.Font TaoFont(string fontPath, float size, int style = iTextSharp.text.Font.NORMAL)
        {
            BaseFont bf = BaseFont.CreateFont(
                fontPath,
                BaseFont.IDENTITY_H,   // 🔥 QUAN TRỌNG
                BaseFont.EMBEDDED);

            return new iTextSharp.text.Font(bf, size, style);
        }


        private void AddCell(PdfPTable table, string text, PdfFont font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Padding = 5;
            table.AddCell(cell);
        }
    }
}
