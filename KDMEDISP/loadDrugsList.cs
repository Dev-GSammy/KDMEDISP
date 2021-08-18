using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;
namespace KDMEDISP
{
    public partial class loadDrugsList : Form
    {
        string csvPath = "";
        util imsg = new util();
        Db db = new Db();
        private frmDrug frmDrug;

        public loadDrugsList()
        {
            InitializeComponent();
        }

        public loadDrugsList(frmDrug frmDrug)
        {
            this.frmDrug = frmDrug;
            InitializeComponent();

        }

        private void btnLoadDefault_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse drug Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblSelectedFile.Text = openFileDialog1.FileName;
                csvPath = lblSelectedFile.Text;
            }
            ReadCSV();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public   void  ReadCSV()
        {
            var csvTable = new DataTable();

            
                using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(csvPath)), true))
                {
                    csvTable.Load(csvReader);
                }
         

            AddDrugs(csvTable);
        }

        private void AddDrugs(DataTable dt)
        {
            //try
            //{
                string  generic, strength, dclass;
            foreach (DataRow dr in dt.Rows)
            {

                generic = dr.Field<string>("Generic");
                strength = dr.Field<string>("strength");
                dclass = dr.Field<string>("class");
                if (string.IsNullOrEmpty(generic))
                {

                }
                else
                {
                    if (db.InsertDefaultDrugs(generic, strength, dclass))
                    {



                    }

                }

            }   
            //}
            //catch (Exception)
            //{
            //    imsg.info("Check Entry and try again !", "Add Product Error");

            //}
        }

        private void dgvDrugLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvDrugLists.Columns[e.ColumnIndex].Name;
            string id = dgvDrugLists[0, e.RowIndex].Value.ToString();
            string generic = dgvDrugLists[2, e.RowIndex].Value.ToString();
            string dclass = dgvDrugLists[4, e.RowIndex].Value.ToString();
            string strength = dgvDrugLists[3, e.RowIndex].Value.ToString();
            if (colName == "add")
            {
                this.Close();
                frmDrug.txtprimary.Text = generic;
                frmDrug.txtstrength.Text = strength;
                frmDrug.txtGeneric.Text = generic;
                frmDrug.Show();
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadDrugsList_Load(object sender, EventArgs e)
        {
            dgvDrugLists.Rows.Clear();

            loadDefaultDrugs();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvDrugLists.Rows.Clear();
            loadDefaultDrugs();
        }
        private void loadDefaultDrugs()
        {
            string searchQuery = txtGenericName.Text;
            try
            {
                DataTable retTable = (DataTable)
              db.returnDefaultDrugs("KDMEDISP", "tblDefaultDrugList", searchQuery);
                int i = 0;


                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;

                    dgvDrugLists.Rows.Add(dr["id"].ToString(),i, dr["generic"].ToString(),
                        dr["strength"].ToString(), dr["dclass"].ToString());
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
