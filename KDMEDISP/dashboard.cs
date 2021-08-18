using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace KDMEDISP
{
    public partial class dashboard : Form
    {
        public static string timeTrack;
        public static string dateTrack;
        public static string selBtn = null;
        public static string username = "";
        util imsg = new util();
        Db db = new Db();
        public dashboard()
        {
            InitializeComponent();
          
            try
            {
                selbtnbgcol(selBtn);

                string folder = "KDMEDISP";
                string targetFolder = "Config";
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string dbFolder =Path.Combine(appData,folder,targetFolder);
                //imsg.getLogo(pbxLogo);
                #region "CreateDBs"
                //System.IO.File.Create(imsg.retConfigPath("vat"));

                // imsg.ConfigFileRead();
                db. createSuppliers();
                db. createDefaultDrug();
                db.createAdmins();
                db.CreateDrugs();
                db.CreatePrescribers();
                db.createCat();
                db.CreateManufacturers();
                db.CreateStockIn();
                db.CreateViewStockIn();
                db.CreateProdImg();
                db.CreateCart();
                db.CreatePatients();
                db.createBarCode();
                db.CreatePrescription();
                 db.Tr_ComputeTotal();// COMPUTE TRIGGER 
                db.CreateErrorModeConfig();
           
                db.CreateDiscTrack();
                db.Tr_ComputeTotalafterUpdate();
                db.CreateTopSellingView();
                db.CreateInitConfig(); //
                #endregion     // create all required tables and views
                //clGlobalTrack.LoginUsername = username;

                string checkConfig = db.GetSingleData("KDMEDISP", "InitConfigStats", "InitConfigStats");
                if (checkConfig=="0"|| checkConfig==string.Empty)
                {
                    db.InsertSingle("InitConfigStats", "InitConfigStats", 1);
                }
               if (!db.DefaultPrinterExist())
                {
                    db.InsertSingle("tblDefPrinter", "DefPrinter", "No Printer Selected!");

                }
            }
            catch (Exception)
            {

                imsg.info("Error Setting up");
            }
            //try
            //{
            //    cTrial.IncreCurrentCount();
            //    if (cTrial.getCount()==3)
            //    {
            //        imsg.info("Expired");
            //    }
            //}
            //catch (Exception)
            //{

                
            //}

}

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
            private void selbtnbgcol( string selBtn)
        {
            if (selBtn==null)
            {
                return;
            }
            switch (selBtn.ToLower())
            {
                //case "brand":
                //    foreach (Control item in pnLeft.Controls)
                //    {
                //        item.BackColor = imsg.leftColor();
                //    }
                //    btnBrand.BackColor = imsg.topColor();
                //    break;
                //case "products":
                //    foreach (Control item in pnLeft.Controls)
                //    {
                //         item.BackColor= imsg.leftColor();
                //    }
                //    btnProducts.BackColor = imsg.topColor();

                //    break;
                //case "records":
                //    foreach (Control item in pnLeft.Controls)
                //    {
                //        item.BackColor = imsg.leftColor();
                //    }
                //    btnRecord.BackColor = imsg.topColor();
                //    break;
                //case "category":
                //    foreach (Control item in pnLeft.Controls)
                //    {
                //        item.BackColor = imsg.leftColor();
                //    }
                //    btnCategory.BackColor = imsg.topColor();
                //    break;
                //case "stock":
                //    foreach (Control item in pnLeft.Controls)
                //    {
                //        item.BackColor = imsg.leftColor();
                //    }
                //    btnStock.BackColor = imsg.topColor();
                //    break;
                //case "profile":
                //    foreach (Control item in pnLeft.Controls)
                //    {
                //        item.BackColor = imsg.leftColor();
                //    }
                //    btnUsers.BackColor = imsg.topColor();
                //    break;
                //case "settings":
                //    foreach (Control item in pnLeft.Controls)
                //    {
                //        item.BackColor = imsg.leftColor();
                //    }
                //    btnSettings.BackColor = imsg.topColor();
                //    break;
                //default:
                //    break;
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }
            frmProfile frm = new frmProfile();
            selBtn = "profile";
            frm.btnExit.Visible = false;
            selbtnbgcol(selBtn);

            frm.TopLevel = false;
            pnDashboard.Controls.Clear();
            pnDashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            lblUsername.Text = clGlobalTrack.LoginUsername;
                //imsg.info(db.getCount().ToString());

            string dbaseName = "KDMEDISP";
            CreateBrand(dbaseName);
            if (db.getActivateStatus() == 0)
            {
                //Show();

               // frmNotActivated notactivated = new frmNotActivated();
              //  notactivated.ShowDialog();
            }

            if (db.getCount() == 0)
            {
              //  frmNotActivated notactivated = new frmNotActivated();
               // notactivated.ShowDialog();
            }
            //pnTop.BackColor = imsg.topColor();
            //pnLeft.BackColor = imsg.leftColor();

        }
        public void CreateBrand(string dbname, string tablename = "tblBrand")
        {
            SQLiteConnection conn = new SQLiteConnection();
            dbname = "KDMEDISP";
            Console.WriteLine(dbname);
            if (File.Exists(dbname))
            {

                return;
            }
            else
            {
                conn = db.CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string BinRec = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,    `brand` TEXT );";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = BinRec;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }

            Application.Exit(); 
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }

            Home home = new Home();

            home.Show();
            this.Hide();

        }

        private void p(object sender, PaintEventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pnDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }

            selBtn = "manufacturers";

            selbtnbgcol(selBtn);
            frmManufacturersList frm = new frmManufacturersList(this);
            frm.TopLevel = false;
            pnDashboard.Controls.Clear();

            pnDashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;

            frm.Show();
        }

        private bool StockAlert()

        {
            bool StockStatusAlert = false;
            try
            {
                DataTable retTable = (DataTable)
              db.returnDrugs("KDMEDISP","tblDrugs");
                int i = 0;

                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;
                    if (int.Parse(dr["qty"].ToString()) <= int.Parse(dr["reorderqty"].ToString()))
                    {
                        StockStatusAlert = true;
                    }
                }

            }
            catch (Exception)
            {

            }
            return StockStatusAlert;
            }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }

            selBtn = "products";
           
            selbtnbgcol(selBtn);
            
            //frmProductList productfrm = new frmProductList();
            frmDrugList productfrm = new frmDrugList(this);
            productfrm.TopLevel = false;

            pnDashboard.Controls.Clear() ;
            pnDashboard.Controls.Add(productfrm);
            productfrm.BringToFront();
            productfrm.Dock = DockStyle.Fill;
            productfrm.Show();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }

            frmRecords frm = new frmRecords(this);
                frm.TopLevel = false;
            pnDashboard.Controls.Clear();
            pnDashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            selBtn = "records";

            selbtnbgcol(selBtn);
            frm.Show();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            timeTrack = DateTime.Now.ToLongTimeString();
            dateTrack = DateTime.Now.ToLongDateString();
            lblTime.Text = timeTrack;
            lblDate.Text = dateTrack;

            if (StockAlert())
            {
                pbxStockLevel.Visible = !pbxStockLevel.Visible;
                lblLowStock.Visible = !lblLowStock.Visible;
            }
            else
            {
                pbxStockLevel.Image = Properties.Resources.bellGreen;
                pbxStockLevel.Visible = true;
                lblLowStock.Text = "Stock Level Ok!";
                lblLowStock.Visible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }

            selBtn = "stock";

            selbtnbgcol(selBtn);
            frmStock frm = new frmStock();
           
            frm.TopLevel = false;

            pnDashboard.Controls.Clear();
            pnDashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
         
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }
            //if (!clGlobalTrack.SuperAdmin)
            //{
            //    imsg.info("Restricted to Super Admin!");
            //    return;
            //}
            selBtn = "settings";

            selbtnbgcol(selBtn);
            Settings frm = new Settings();

            frm.TopLevel = false;
            frm.btnExit.Visible = false;
            pnDashboard.Controls.Clear();
            pnDashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }

            selBtn = "manufacturer";

            selbtnbgcol(selBtn);
            frmManufacturersList frm = new frmManufacturersList(this);
            frm.TopLevel = false;

            pnDashboard.Controls.Clear();
        pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            selBtn = "patients";
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }

            selbtnbgcol(selBtn);
            frmPatientList frm = new frmPatientList(this);
            frm.TopLevel = false;

            pnDashboard.Controls.Clear();
            pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            selBtn = "brand";
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }

            selbtnbgcol(selBtn);
            frmDoctorList frm = new frmDoctorList(this);
            frm.TopLevel = false;

            pnDashboard.Controls.Clear();
            pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void d(object sender, PaintEventArgs e)
        {
             
        }
        public void pendingCart()
        {

            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }
        }
        private void btnNewDispense_Click(object sender, EventArgs e)
        {
            clPresandPatientID.TaskText = "DISPENSE DRUGS TO PATIENT";

            selBtn = "dispense";
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }
            selbtnbgcol(selBtn);
            frmSelectPrescribers frm = new frmSelectPrescribers(this,true);
            frm.TopLevel = false;


            pnDashboard.Controls.Clear();
            pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }
            selbtnbgcol(selBtn);
            frmSuppliers frm = new frmSuppliers(this);
            frm.TopLevel = false;

            pnDashboard.Controls.Clear();
            pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnNewPres_Click(object sender, EventArgs e)
        {
            clPresandPatientID.TaskText = "MAKE A NEW PRESCRIPTION";

            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }

            frmSelectPrescribers frm = new frmSelectPrescribers(this, false);
            frm.TopLevel = false;

            pnDashboard.Controls.Clear();
            pnDashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void pnTop_Paint(object sender, PaintEventArgs e)
        {

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {

            // Paste the below code in the your label control MouseDown event

            if (e.Button == MouseButtons.Left)

            {

                ReleaseCapture();

                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }
    }
}
