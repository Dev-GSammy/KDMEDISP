using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP
{
     class GenerateCSV
    {
      public void ExportDGV(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            //MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dgv.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgv.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dgv.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dgv.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dgv.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            //MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
       public void ExportTOCSV( DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers  
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
        public void ExportToCsv2(DataTable dt, string filepath)
        {
            StringBuilder sb = new StringBuilder();
         
            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                    sb.Append(FormatCSV(dr[dc.ColumnName].ToString()) + ",");
                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();
            }
            File.WriteAllText(filepath, sb.ToString());
        }
        public void ExportDGVToCSV3(DataGridView dGV, string filename)
        {
            

                string stOutput = "";



                // Export titles: 

                string sHeaders = "";

                for (int j = 0; j < dGV.Columns.Count; j++)

                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + ", ";

                stOutput += sHeaders + "\r\n";

                // Export data. 

                for (int i = 0; i < dGV.RowCount - 1; i++)

                {

                    string stLine = "";

                    for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)

                        stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + ", ";

                    stOutput += stLine + "\r\n";

                }



                UTF8Encoding utf8 = new UTF8Encoding();

                //Encoding utf16 = Encoding.GetEncoding(1200);//unicode encoding

                byte[] output = utf8.GetBytes(stOutput);



                FileStream fs = new FileStream(filename, FileMode.Create);

                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(output, 0, output.Length); //write the encoded file

                bw.Flush();

                bw.Close();

                fs.Close();



            
        }
        public static string FormatCSV(string input)
        {
            try
            {
                if (input == null)
                    return string.Empty;

                bool containsQuote = false;
                bool containsComma = false;
                int len = input.Length;
                for (int i = 0; i < len && (containsComma == false || containsQuote == false); i++)
                {
                    char ch = input[i];
                    if (ch == '"')
                        containsQuote = true;
                    else if (ch == ',')
                        containsComma = true;
                }

                if (containsQuote && containsComma)
                    input = input.Replace("\"", "\"\"");

                if (containsComma)
                    return "\"" + input + "\"";
                else
                    return input;
            }
            catch
            {
                throw;
            }
        }

       
    }
}
