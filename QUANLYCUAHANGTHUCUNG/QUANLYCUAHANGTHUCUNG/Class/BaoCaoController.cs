using System;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCuaHangThuCung.Class
{
    public class BaoCaoController
    {
        BaoCaoPDFService pdfService = new BaoCaoPDFService();

        public void XuatPDF(
            string path,
            DateTime from,
            DateTime to,
            DataTable dtHD,
            DataTable dtCT,
            Chart chart)
        {
            pdfService.XuatBaoCaoPDF(
                path,
                "BÁO CÁO DOANH THU",
                from,
                to,
                dtHD,
                dtCT,
                chart
            );
        }
    }
}
