using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP
{

    /// <summary>
    /// P- check if pcode exist before inserting else generate new random
    /// Add functionality to set in default import  columns and names in settings
    /// </summary>

    public partial class frmSyncProd : Form
    {
        string filename = "";
        int EstoreID;
        Db db = new Db();
        util imsg = new util();
        string  pbcode;
        int cid, bid;
        string DefPcode = string.Empty;
        public frmSyncProd()
        {
            InitializeComponent();
        }

        private void loadingON()
        {
            pbxAnimate.Show();
        }
        private void loadingO()
        {
            pbxAnimate.Show();
        }
        private void frmSyncProd_Load(object sender, EventArgs e)
        {

        }

        private void dgvProdSync_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataTable LoadCSVOnDataGridView(string fileName)
        {
            //try
            //{
                ReadCSV csv = new ReadCSV(fileName);
             
                  dgvProdSync.AutoResizeColumns();
                    dgvProdSync.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    return csv.readCSV;
               
            //}
            //catch (Exception ex)
            //{
            //}
          
        }

        private void btnBrowseCsv_Click(object sender, EventArgs e)
        {
            using OpenFileDialog opfd = new OpenFileDialog();
            {

                if (opfd.ShowDialog() == DialogResult.OK)
                {

                   

                    filename = opfd.FileName;

                }
            }
            pbxAnimate.Visible = true;
            bgwgif.RunWorkerAsync();

        }

     

        private void btnSyncStock_Click(object sender, EventArgs e)
        {
            // loop through each row in the datagrid
            // check for records in products
            //  if not existing, insert records
            // check for stock quantity
            //       if different update
            //  check price if price is different   and update

            foreach (DataGridViewRow row in dgvProdSync.Rows)
            {
               
                string Defbarcode = string.Empty;
                string DefCat = "Default";
                string DefBr = "Default";


                string prodName;
                int qty;
                int DefReorderQty=50;
                double price=0;


                string TempEstoreID = row.Cells["id"].Value.ToString();
              string   tempPrice = row.Cells["Regular price"].Value.ToString();
                string imgUrl = row.Cells["Images"].Value.ToString();
                int.TryParse(TempEstoreID, out EstoreID);
                // get image
                imgUrl = extractimgUrlfromCsv(imgUrl);
                Console.WriteLine(imgUrl);
                double.TryParse(tempPrice, out price);

               string tempqty=row.Cells["Stock"].Value.ToString();
                int.TryParse(tempqty, out qty);
                prodName = row.Cells["name"].Value.ToString();
                if (db.GetIDForEstoreID(EstoreID)==-1)            // if product does not exist
                {
                    Console.WriteLine("adding  products now");

                    insertProduct(DefPcode, prodName, Defbarcode, DefCat, DefBr, qty, DefReorderQty, price, EstoreID, imgUrl);
                } else
                {
                    Console.WriteLine("Already Existing");
                }
                //More code here
            }



        }
        private string GenerateRandom()
        {
            Random rand = new Random();
            int brA = rand.Next(99999);
            int brB = rand.Next(99999);
            string finalCOde = brA.ToString() + brB.ToString();
            if (db.CheckPCodeExist(finalCOde))
            {
                GenerateRandom();
            }
            else
            {
                DefPcode=finalCOde;

            }
            return DefPcode;
        }

        private string extractimgUrlfromCsv( string urlstring)

        {
            urlstring = urlstring.Trim().ToLower();
            string actualUrl="";
            if (urlstring.Contains(".gif")    )
            {
                actualUrl = urlstring.Substring(0, urlstring.IndexOf(".gif")+4);

            }
            else if (urlstring.Contains(","))
            {
                actualUrl = urlstring.Substring(0, urlstring.IndexOf(",") );
            }
            else if (urlstring.Contains(".jpg"))
            {
                actualUrl = urlstring.Substring(0, urlstring.IndexOf(".jpg") + 4);
            }
            else if (urlstring.Contains(".jpeg"))
            {
                actualUrl = urlstring.Substring(0, urlstring.IndexOf(".jpeg") + 5);
            }
            else if (urlstring.Contains(".png"))
            {
                actualUrl = urlstring.Substring(0, urlstring.IndexOf(".png") + 4);
            }
            else if (urlstring.Contains(".bmp"))
            {
                actualUrl = urlstring.Substring(0, urlstring.IndexOf(".bmp") + 4);
            }
            else if (urlstring.Contains(".tif"))
            {
                actualUrl = urlstring.Substring(0, urlstring.IndexOf(".tif") + 4);
            }
            else if (urlstring.Contains(".webp"))
            {
                actualUrl = urlstring.Substring(0, urlstring.IndexOf(".webp") + 4);
            }
            return actualUrl;

        }
        private  bool insertProduct(string pcode,string pdesc,string barcode, string selcat, string selbr, int qty, int reorderQty, double price,int EstoreID, string imgUrl)
        {
          
                cid = 1;
                bid = 1;
               

                        if (db.InsertProduct(pcode, pbcode, pdesc, bid, cid, price, qty, reorderQty, EstoreID, imgUrl))
                        {
                Console.WriteLine("Success!", "Add Product");

               

                        }
                        else
                        {
                Console.WriteLine("An error Occured!", "Add Product");

                        }




            return true;
        }

        private void bgwgif_DoWork(object sender, DoWorkEventArgs e)
        {

           LoadCSVOnDataGridView(filename);
                                                                                                                                     
        }

        private void pbxAnimate_Click(object sender, EventArgs e)
        {

        }

        private void bgwgif_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvProdSync.DataSource = LoadCSVOnDataGridView(filename);

        }

        private void dgvProdSync_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            pbxAnimate.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            Hide();
        }
    }
}