using System;
using System.Diagnostics;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace KDMEDISP
{
    class GenerateExcel
    {

        util imsg = new util();
        public void createExcel(DataGridView dgrid, bool def, bool autoOpen)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (int t = 0; t < dgrid.ColumnCount; t++)
            {
                xlWorkSheet.Cells[1, t + 1] = dgrid.Columns[t].HeaderText;

            }
            for (i = 0; i <= dgrid.RowCount - 1; i++)
            {
                for (j = 0; j <= dgrid.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgrid[j, i];
                    xlWorkSheet.Cells[2+i , j + 1] = cell.Value;
                    //xlWorkSheet.Cells[i + 1, j] = cell.Value;  // make adjustment for hidden id rows used for datagrid value extraction
                }
            }

            string targetFolder = "Lush Report";
            Console.WriteLine(def);
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string reportsFolder = System.IO.Path.Combine(folderPath, targetFolder);
            if (!System.IO.Directory.Exists(reportsFolder))
            {
                System.IO.Directory.CreateDirectory(reportsFolder);
            }
            string savename = string.Empty;
            string savename2 = string.Empty;
            if (!def)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = reportsFolder;
                saveFileDialog1.Title = "Save Bin Report Files";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "xls";
                saveFileDialog1.Filter = "Excel files |*.xls";
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
                savename = reportsFolder + "/" + t + ".xls";
                savename2 = reportsFolder + "/" + t + ".csv";
            }
            //xlWorkBook.SaveAs(savename, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.SaveAs(savename2, Excel.XlFileFormat.xlCSV, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);

            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            if (autoOpen)
            {
                Process.Start(savename2);

            }

        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
