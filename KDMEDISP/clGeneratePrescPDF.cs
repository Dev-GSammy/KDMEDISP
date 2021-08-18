using System;
using System.Resources;
using iTextSharp.text; //'Core PDF Text Functionalities
using iTextSharp.text.pdf; //'PDF Content
using iTextSharp.text.pdf.parser;// 'Content Parserusing System;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;

namespace KDMEDISP
{
    class clGeneratePrescPDF
    {


        public bool MakePDF(DataGridView d, string oName, string Oy, bool def, string title = "")
        {
            bool pdfStats = false;
            string savename = string.Empty;

            //try
            //{
                string targetFolder = "KDMEDISP REPORT";
                Console.WriteLine(def);
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string reportsFolder = System.IO.Path.Combine(folderPath, targetFolder);
                if (!System.IO.Directory.Exists(reportsFolder))
                {
                    System.IO.Directory.CreateDirectory(reportsFolder);
                }

                if (!def)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.InitialDirectory = reportsFolder;
                    saveFileDialog1.Title = "Save Prescription  ";
                    saveFileDialog1.CheckPathExists = true;
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Filter = "Pdf files |*.pdf";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;
                    saveFileDialog1.ShowDialog();
                    savename = saveFileDialog1.FileName;
                }
                else
                {

                    string t = DateTime.Now.ToLongTimeString();
                    t = t.Replace(" ", "_");
                    t = t.Replace(":", "_");
                    savename = reportsFolder + "/" + t + ".pdf";
                }

                PdfPTable pdfTable = new PdfPTable(d.ColumnCount);
                Font fnthead = FontFactory.GetFont("Calisto MT", 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                Font fntbody = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 30;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.DefaultCell.BorderWidth = 1;
                pdfTable.TotalWidth = 700.0F;
                pdfTable.LockedWidth = true;


                Chunk ck = new Chunk();
                int colNum = d.ColumnCount;
                foreach (DataGridViewColumn column in d.Columns)
                {
                    PdfPCell Pcell = new PdfPCell(new Phrase(column.HeaderText, fnthead));
                    Pcell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(Pcell);

                }
                //    Console.WriteLine(colNum);
                //Adding DataRow
                string cellvalue = string.Empty;

                foreach (DataGridViewRow drow in d.Rows)
                {
                    foreach (DataGridViewCell dcell in drow.Cells)
                    {
                        cellvalue = dcell.FormattedValue.ToString();
                        pdfTable.AddCell(new Phrase((cellvalue).ToString(), fntbody));
                        float totalwidth = 700.0F;
                        float inWidth = totalwidth / colNum;
                        float[] widths = new float[colNum];
                        // widths[0] = 0.0f;
                        for (int cc = 0; cc < colNum; cc++)
                        {
                            widths[cc] = inWidth;

                        }
                        pdfTable.SetWidths(widths);

                    }
                }






                System.IO.FileStream stream = new System.IO.FileStream(savename, System.IO.FileMode.CreateNew);
                Document pdfDoc = new Document(PageSize.A4.Rotate(), 2.0F, 2.0F, 2.0F, 0.0F);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                Object rm = Properties.Resources.ResourceManager.GetObject("kdmedlogosm");
                System.Drawing.Bitmap mylogo = (System.Drawing.Bitmap)rm;

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(mylogo, System.Drawing.Imaging.ImageFormat.Png);

                logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                logo.ScaleToFit(80, 80);
                Paragraph ReportTItle = new Paragraph(Oy + "  " + title + " reports for " + oName);
                ReportTItle.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(logo);

                pdfDoc.Add(ReportTItle);

                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(pdfTable);

                pdfDoc.Close();
                stream.Close();
                Process.Start(savename);
                pdfStats = true;


            //}
            //catch (Exception)
            //{

            //    pdfStats = false;
            //}

            return pdfStats;


        }

    }
}

