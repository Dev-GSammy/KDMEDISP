using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP
{
    public partial class frmGenerateCsv : Form
    {
        string FileName="";
        string dispData = "...";
        util imsg = new util();
        Db db = new Db();
        public int reorderBool = 0;
        DataTable ImportedCsvTable = new DataTable();
        DataTable InsysProdTable = new DataTable();
        public frmGenerateCsv()
        {
            InitializeComponent();
        }

        private void frmGenerateCsv_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseCsv_Click(object sender, EventArgs e)
        {
            fetchCsV();
        }

        private void fetchCsV()
        {
            using OpenFileDialog opfd = new OpenFileDialog();
            {

                if (opfd.ShowDialog() == DialogResult.OK)
                {



                    FileName = opfd.FileName;

                }

            }

            ReadCSV csv = new ReadCSV(FileName);
            lblDisp.Text = "Source CSV";
                ImportedCsvTable = csv.readCSV;
            dgvExportCsv.DataSource = ImportedCsvTable;
        }

        private void fetchProductsTable ()
        {
            DataTable retTable = (DataTable)


         db.returnProduct(reorderBool, "");

               InsysProdTable= retTable;

        }

        private async void btnSyncStock_Click(object sender, EventArgs e)
        {
            dgvExportCsv.Enabled = false;
            await updateStock();


            dgvExportCsv.DataSource = null;
            dgvExportCsv.DataSource = ImportedCsvTable;
            dgvExportCsv.Enabled = true;

            lblDisp.Text = " Updated CSV";
            GenerateCSV CSV = new GenerateCSV();
            //CSV.ExportDGV(dgvExportCsv);
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Csv files (*.csv)|*.csv";
            //sfd.FilterIndex = 2;
            //sfd.RestoreDirectory = true;
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{

            //}   //Csv.ExportToCsv2(ImportedCsvTable, sfd.FileName);
                //CSV.ExportDGVToCSV3(dgvExportCsv, sfd.FileName);
                GenerateExcel excel = new GenerateExcel();
                excel.createExcel(dgvExportCsv, true, true);
            


        }
        private async  Task<bool> updateStock()
        {
            bool status = false;
 fetchProductsTable();
            int ID, EstoreID;
            foreach (DataRow dr1 in ImportedCsvTable.Rows)
            {
                ID = (Convert.ToInt32(dr1["ID"]));
                foreach (DataRow dr2 in InsysProdTable.Rows)
                {
                    EstoreID = (Convert.ToInt32(dr2["EstoreID"]));
                    Console.WriteLine("ID==> " + ID + "   ESTOEREID  ===>" + EstoreID);
                    if (ID == EstoreID)       // if dt product is found in the current app inventory
                    {


                        dr1["stock"] = dr2["qty"]; //change the name
                                                   //break; break or not depending on you

                    }
                    else
                    {

                        Console.WriteLine("Not found");
                    }
                }
            }
            return status;
        }
     
    }
}
