using Estate.Shared;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Client.Services
{
    public class PDFService
    {
        public MemoryStream CreatePDF(Invoice invoice)
        {
            using(PdfDocument pdfDocument = new PdfDocument())
            {
                int paragraphAfterSpacing = 8;
                int cellMargin = 8;

                PdfPage page = pdfDocument.Pages.Add();

                PdfStandardFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 16);

                PdfTextElement title = new PdfTextElement("Hyresavi", font, PdfBrushes.Black);
                PdfLayoutResult result = title.Draw(page, new Syncfusion.Drawing.PointF(0, 0));

                PdfTextElement invoiceNo = new PdfTextElement("Nr: " + invoice.Id.ToString(), font, PdfBrushes.Black);
                PdfLayoutResult invoiceResult = invoiceNo.Draw(page, new Syncfusion.Drawing.PointF(200, 0));

                PdfStandardFont addressFont = new PdfStandardFont(PdfFontFamily.Helvetica, 14);

                PdfTextElement name = new PdfTextElement(invoice.ApartmentId.ToString(), font, PdfBrushes.Black);
                PdfLayoutResult nameResult = name.Draw(page, new Syncfusion.Drawing.PointF(0, 60));

                PdfStandardFont contentfont = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
                PdfLayoutFormat format = new PdfLayoutFormat();
                format.Layout = PdfLayoutType.Paginate;

                PdfGrid pdfGrid = new PdfGrid();
                pdfGrid.Style.CellPadding.Left = cellMargin;
                pdfGrid.Style.CellPadding.Right = cellMargin;

                pdfGrid.ApplyBuiltinStyle(PdfGridBuiltinStyle.GridTable4Accent1);

                pdfGrid.DataSource = invoice.InvoiceLines;

                pdfGrid.Style.Font = contentfont;

                pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(0, result.Bounds.Bottom + paragraphAfterSpacing));

                using(MemoryStream stream = new MemoryStream())
                {
                    pdfDocument.Save(stream);
                    pdfDocument.Close(true);
                    return stream;
                }
            }
        }
    }
}
