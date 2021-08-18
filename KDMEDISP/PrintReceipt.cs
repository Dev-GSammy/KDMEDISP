using MetroFramework.Properties;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace KDMEDISP
{
    class PrintReceipt
    {
        PrintDocument recordDoc = new PrintDocument();


        public void PosPrint(string printerName)
        {
            recordDoc.DocumentName = "Customer Receipt";
            recordDoc.PrintPage += new PrintPageEventHandler(PrintReceiptPage); // function below
            recordDoc.PrintController = new StandardPrintController(); // hides status dialog popup
                                                                       // Comment if debugging 
            PrinterSettings ps = new PrinterSettings();
            ps.PrinterName = printerName;
            recordDoc.PrinterSettings = ps;
            recordDoc.Print();
            // --------------------------------------

            // Uncomment if debugging - shows dialog instead
            //PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
            //printPrvDlg.Document = recordDoc;
            //printPrvDlg.Width = 1200;
            //printPrvDlg.Height = 800;
            //printPrvDlg.ShowDialog();
            // --------------------------------------

            recordDoc.Dispose();
        }

        private static void PrintReceiptPage(object sender, PrintPageEventArgs e)
        {
            float x = 0.2F;
            float y = 5;
            float width = 200.0F; // max width I found through trial and error
            float height = 0F;

            Font drawFontArial12Bold = new Font("Arial", 8, FontStyle.Bold);
            Font drawFontArial10Regular = new Font("Arial", 6, FontStyle.Regular);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Set format of string.
            StringFormat drawFormatCenter = new StringFormat();
            drawFormatCenter.Alignment = StringAlignment.Center;
            StringFormat drawFormatLeft = new StringFormat();
            drawFormatLeft.Alignment = StringAlignment.Near;
            StringFormat drawFormatRight = new StringFormat();
            drawFormatRight.Alignment = StringAlignment.Far;

            // Draw string to screen.
            string text = "LushBeauty";
            e.Graphics.DrawString(text, drawFontArial12Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;

            text = "RECEIPT";
            e.Graphics.DrawString(text, drawFontArial12Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;

            text = "***********";
            e.Graphics.DrawString(text, drawFontArial12Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;
            text = "Customer Name: Kadosh Mechatronics";
            e.Graphics.DrawString(text, drawFontArial12Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;
            text = "***********";
            e.Graphics.DrawString(text, drawFontArial12Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;
            // Create image.
            Image newImage = Properties.Resources.logo;

            // Create coordinates for upper-left corner of image.
            float ximg = 100.0F;
            float yimg = 100.0F;

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(50.0F, 50.0F, 150.0F, 150.0F);
            GraphicsUnit units = GraphicsUnit.Pixel;

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, ximg, yimg, srcRect, units);
            // ... and so on
        }


        public void DrawImage2FloatRectF(PrintPageEventArgs e)
        {

            // Create image.
            Image newImage = Properties.Resources.logo ;

            // Create coordinates for upper-left corner of image.
            float x = 2.0F;
            float y = 5;

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(50.0F, 50.0F, 150.0F, 150.0F);
            GraphicsUnit units = GraphicsUnit.Pixel;

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, x, y, srcRect, units);
        }
    }
}
