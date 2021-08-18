using iTextSharp.text; //'Core PDF Text Functionalities
using iTextSharp.text.pdf; //'PDF Content
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP

{
    public class cGenPrescPDF
    {

        util imsg = new util();


        public bool MakePDF(DataGridView d, bool def, bool autoOpen, bool remLastCol, object otherDetails = null)
        {

            string savename = string.Empty;


            string filePath = imsg.retConfigPath("storedata");
            DefaultConfig c = new DefaultConfig();
            serialize st = new serialize(filePath);
            c = (DefaultConfig)st.DeSerializeNow(c);
            bool pdfStats = false;
            try
            {
                string targetFolder = "KDMEDISP Report";
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
                saveFileDialog1.Title = "Save Prescription";
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
                    widths[2] = 0.0f;

                    for (int cc = 3; cc < colNum - 2; cc++)
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
            Paragraph presID = new Paragraph("ID:       " + cprescriptionReport.PrescriptionID);
            presID.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(presID);
            Paragraph hText5 = new Paragraph("Date:     " + DateTime.Now.ToLongDateString());
            hText5.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(hText5);
            string infoHead = "PRESCRIPTION DETAILS";
            Paragraph Lbreak = new Paragraph("==============================================" + infoHead + "==============================================");
            Lbreak.Alignment = Element.ALIGN_CENTER;

            pdfDoc.Add(Lbreak);

            Paragraph PA = new Paragraph("-------------------PATIENT DETAILS-------------------");
            PA.Alignment = Element.ALIGN_LEFT;

            pdfDoc.Add(PA);
            Paragraph ReportTItle = new Paragraph("    Name:    " + cprescriptionReport.PatientfullName);
            ReportTItle.Alignment = Element.ALIGN_LEFT;

            pdfDoc.Add(ReportTItle);
            Paragraph ptPhone = new Paragraph("    Phone:    " + cprescriptionReport.patientPhone);
            ptPhone.Alignment = Element.ALIGN_LEFT;

            pdfDoc.Add(ptPhone);
            Paragraph ptEmail = new Paragraph("    Email:     " + cprescriptionReport.patientEmail);
            ptEmail.Alignment = Element.ALIGN_LEFT;
            pdfDoc.Add(ptEmail);
            Paragraph ptAdd = new Paragraph("    Address:     " + cprescriptionReport.patientAddress + "      ");
            ptAdd.Alignment = Element.ALIGN_LEFT;
            pdfDoc.Add(ptAdd);

            Paragraph ptID = new Paragraph("    ID:     " + cprescriptionReport.PatientID);
            ptID.Alignment = Element.ALIGN_LEFT;
            pdfDoc.Add(ptID);
            //========================
            Paragraph ptDOB = new Paragraph("    Date of Birth: " + cprescriptionReport.patientDOB);
            ptDOB.Alignment = Element.ALIGN_LEFT;
            pdfDoc.Add(ptDOB);

            Paragraph sline = new Paragraph("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            sline.Alignment = Element.ALIGN_CENTER;

            pdfDoc.Add(sline);

            //========================

            //========================
            pdfDoc.Add(new Paragraph(" "));
            pdfDoc.Add(pdfTable);

            //===========================

            pdfDoc.Add(sline);

            Paragraph PR = new Paragraph("-------------------PRESCRIBER DETAILS-------------------");
            PR.Alignment = Element.ALIGN_RIGHT;

            pdfDoc.Add(PR);
            Paragraph total = new Paragraph(" Prescriber's Name:    " + cprescriptionReport.prescFullName + "        ");
            total.Alignment = Element.ALIGN_RIGHT;
            pdfDoc.Add(total);
            Paragraph preID = new Paragraph("StaffID/LicenseID   :" + cprescriptionReport.prescStaffID + "        ");
            preID.Alignment = Element.ALIGN_RIGHT;
            pdfDoc.Add(preID);
            Paragraph prephon = new Paragraph(" Phone:    " + cprescriptionReport.prescPhone + "         ");
            prephon.Alignment = Element.ALIGN_RIGHT;
            pdfDoc.Add(prephon);
            Paragraph preEmail = new Paragraph(" Email:    " + cprescriptionReport.prescEmail + "          ");
            preEmail.Alignment = Element.ALIGN_RIGHT;
            pdfDoc.Add(preEmail);


            Paragraph preSign = new Paragraph("Signature  _________________________ ");
            preSign.Alignment = Element.ALIGN_RIGHT;
            pdfDoc.Add(preSign);
            infoHead = "THANK YOU";
            Paragraph Lbreak2 = new Paragraph("==============================================" + infoHead + "==============================================");
            Lbreak2.Alignment = Element.ALIGN_CENTER;

            pdfDoc.Add(Lbreak2);



            //========================
            pdfDoc.Close();
            stream.Close();
            pdfStats = true;


        }
            catch (Exception)
            {

                //pdfStats = false;
            }
            if (autoOpen)
            {
                Process.Start(savename);

            }

            return pdfStats;

        }

    }
}

