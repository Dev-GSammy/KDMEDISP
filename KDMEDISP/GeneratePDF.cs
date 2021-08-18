using iTextSharp.text; //'Core PDF Text Functionalities
using iTextSharp.text.pdf; //'PDF Content
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP

{
   public  class   GeneratePDF
    {

        util imsg = new util();

       
        public  Task MakePDFAsync(DataGridView d,  bool def, bool autoOpen, bool remLastCol,object otherDetails = null)
        {
          return  Task.Factory.StartNew (()=>
            {
            string savename = string.Empty;
            PosOrder O =(PosOrder) otherDetails;

            string filePath = imsg.retConfigPath("storedata");
            DefaultConfig c = new DefaultConfig();
            serialize st = new serialize(filePath);
            c = (DefaultConfig)st.DeSerializeNow(c);

            try
            {
                string targetFolder = "Lush Report";
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
                    saveFileDialog1.Title = "Save Receipt";
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
                    savename = Path.Combine(reportsFolder, t + ".pdf");
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
                int i = 0;

                foreach (DataGridViewRow drow in d.Rows)
                {
                    foreach (DataGridViewCell dcell in drow.Cells)
                    {
                        cellvalue = dcell.FormattedValue.ToString();
                        pdfTable.AddCell(new Phrase((cellvalue).ToString(), fntbody));
                        float totalwidth = PageSize.A4.Rotate().Width;
                        float inWidth = totalwidth / colNum;
                        float[] widths = new float[colNum];
                        widths[0] = 10.0f;
                        widths[1] = 0.0f;

                        for (int cc = 2; cc < colNum - 2; cc++)
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
                Object rm = Properties.Resources.ResourceManager.GetObject("logo");
                System.Drawing.Bitmap mylogo = (System.Drawing.Bitmap)rm;
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(mylogo, System.Drawing.Imaging.ImageFormat.Png);

                logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                logo.ScaleToFit(80, 80);
                pdfDoc.Add(logo);

                Paragraph hText1 = new Paragraph(c.StoreName);
                hText1.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(hText1);
                //===========================
                Paragraph hText2 = new Paragraph(c.StoreAddress);
                hText2.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(hText2);
                //========================
                //===========================
                Paragraph hText3 = new Paragraph("Mobile: " + c.StorePhone+ " Email: " +c.ReceiptEmail);
            hText3.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(hText3);
            //========================
            Paragraph ReportTItle = new Paragraph("Customer's Name: " +O.CustomerName );
            ReportTItle.Alignment = Element.ALIGN_CENTER;

            pdfDoc.Add(ReportTItle);
                Paragraph transNo = new Paragraph("TransNo: " + O.InvoiceNo);
                transNo.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(transNo);
                //========================
                Paragraph hText5 = new Paragraph(DateTime.Now.ToLongDateString());
            hText5.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(hText5);
            //========================
            pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(pdfTable);
            //===========================

            Paragraph total = new Paragraph("Total:" + O.TotalAmount );
            total.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(total);
            Paragraph hText4 = new Paragraph("THANK YOU FOR YOUR PATRONAGE!");
            hText4.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(hText4);
            //========================
            pdfDoc.Close();
                stream.Close();
                //pdfStats = true;


            }
            catch (Exception)
            {

                //pdfStats = false;
            }
            if (autoOpen)
            {
                Process.Start(savename);

            }

            });
           
        }
        public object  MakePDF(DataGridView d, bool def, bool autoOpen, bool remLastCol, object otherDetails = null)
        {
            TaskReport Tsr = new TaskReport();
                string savename = string.Empty;
                PosOrder O = (PosOrder)otherDetails;
            Tsr.taskStatus = false;
                string filePath = imsg.retConfigPath("storedata");
                DefaultConfig c = new DefaultConfig();
                serialize st = new serialize(filePath);
                c = (DefaultConfig)st.DeSerializeNow(c);

                try
                {
                    string targetFolder = "KDMEDISP Receipt";
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
                        saveFileDialog1.Title = "Save Receipt";
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
                        savename = Path.Combine(reportsFolder, t + ".pdf");
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
                    int i = 0;

                    foreach (DataGridViewRow drow in d.Rows)
                    {
                        foreach (DataGridViewCell dcell in drow.Cells)
                        {
                            cellvalue = dcell.FormattedValue.ToString();
                            pdfTable.AddCell(new Phrase((cellvalue).ToString(), fntbody));
                            float totalwidth = PageSize.A4.Rotate().Width;
                            float inWidth = totalwidth / colNum;
                            float[] widths = new float[colNum];
                            widths[0] = 10.0f;
                            widths[1] = 0.0f;

                            for (int cc = 2; cc < colNum - 2; cc++)
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
                    pdfDoc.Add(logo);

                    Paragraph hText1 = new Paragraph(c.StoreName);
                    hText1.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(hText1);
                    //===========================
                    Paragraph hText2 = new Paragraph(c.StoreAddress);
                    hText2.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(hText2);
                    //========================
                    //===========================
                    Paragraph hText3 = new Paragraph("Mobile: " + c.StorePhone + " Email: " + c.ReceiptEmail);
                    hText3.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(hText3);
                    //========================
                    Paragraph ReportTItle = new Paragraph("Customer's Name: " + O.CustomerName);
                    ReportTItle.Alignment = Element.ALIGN_CENTER;

                    pdfDoc.Add(ReportTItle);
                    Paragraph transNo = new Paragraph("TransNo: " + O.InvoiceNo);
                    transNo.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(transNo);
                    //========================
                    Paragraph hText5 = new Paragraph(DateTime.Now.ToLongDateString());
                    hText5.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(hText5);
                    //========================
                    pdfDoc.Add(new Paragraph(" "));
                    pdfDoc.Add(pdfTable);
                    //===========================

                    Paragraph total = new Paragraph("Total:" + O.TotalAmount);
                    total.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(total);
                    Paragraph hText4 = new Paragraph("THANK YOU FOR YOUR PATRONAGE!");
                    hText4.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(hText4);
                    //========================
                    pdfDoc.Close();
                    stream.Close();
            Tsr.taskStatus = true;
                


            }
            catch (Exception)
                {
                Tsr.taskStatus = true;

            }
            if (autoOpen)
                {
                    Process.Start(savename);
                Tsr.genFilePath = savename;

            }


            return Tsr;
        }
    }
}

