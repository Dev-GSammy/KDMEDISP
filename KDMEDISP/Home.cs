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
    public partial class Home : Form
    {
        util imsg = new util();
        public int count = 1;
        Db db = new Db();
        public string  TaskIdentifier=null;
        dashboard dashboard = new dashboard();
        public Home()
        {
            InitializeComponent();
            try
            {
                //imsg.getLogo(pbxLogo);
                 
            }
            catch (Exception)
            {

            }
           

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            //selBtn = "dispense";
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }
            //selbtnbgcol(selBtn);
            frmDoctorList frm = new frmDoctorList(dashboard);
            frm.TopLevel = false;

            dashboard.pnDashboard.Controls.Clear();
            dashboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
            //dashboard.selBtn = "profile";

            dashboard.Show();
            this.Hide();

        }

        private void SyncEstore()
        {

            frmSyncProd frm = new    frmSyncProd();
            frm.TopLevel = false;

            dashboard.pnDashboard.Controls.Clear();
            dashboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
            dashboard.selBtn = "brands";

            dashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            var dashboard = new dashboard();

        
            this.Hide(); 
            dashboard.Show();

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            frmBarcode bar = new frmBarcode();
            bar.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

            if (!clGlobalTrack.SuperAdmin)
            {
                imsg.info("Restricted to Super Admin!");
                return;
            }
            Settings frm = new Settings();
            frm.Show();
            this.Hide();

        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {
           //imsg.info(HardwareInfo.GenerateUID("KDMEDISP"));
            //string user="test";
            frmLicense license = new frmLicense();
            license.ShowDialog();
            //imsg.info(ConnectToLicenseServer.Delete("http://127.0.0.1/WB_2020/KDLicense/index.php", user).ToString());
            //imsg.info(ConnectToLicenseServer.Update("http://127.0.0.1/WB_2020/KDLicense/index.php", user).ToString());
            //imsg.info(ConnectToLicenseServer.Insert("http://127.0.0.1/WB_2020/KDLicense/index.php", user).ToString());



        }

        private void btnProducts_Click(object sender, EventArgs e)
        {



        }
        private void Category()
        {



            frmCategoryList frm = new frmCategoryList();
            frm.TopLevel = false;

            dashboard.pnDashboard.Controls.Clear();
            dashboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
            dashboard.selBtn = "category";

            dashboard.Show();
            this.Hide();

        }
        private void Records()
        {




            frmPatientList frm = new frmPatientList(dashboard);
            frm.TopLevel = false;

            dashboard.pnDashboard.Controls.Clear();
            dashboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
            dashboard.Show();
            dashboard.selBtn = "records";

            this.Hide();

        }
        private void ExportCSV()
        {




            frmGenerateCsv frm = new frmGenerateCsv();
            frm.TopLevel = false;

            dashboard.pnDashboard.Controls.Clear();
            dashboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
            //dashboard.selBtn = "products";
            dashboard.Show();
        }
        private void tmranimate_Tick(object sender, EventArgs e)
        {
            count++;
            if (count==6)
            {
                count = 1;
            }
            switch (count)
            {

                case 1:
                    pbxAnimate.Image = Properties.Resources._1p;
                    break;
                case 2:
                    pbxAnimate.Image = Properties.Resources._2p;
                    break;
                case 3:
                    pbxAnimate.Image = Properties.Resources._3p;
                    break;
                case 4:
                    pbxAnimate.Image = Properties.Resources._4p;
                    break;
                case 5:
                    pbxAnimate.Image = Properties.Resources._5p;
                    break;
                case 6:
                    pbxAnimate.Image = Properties.Resources._6p;
                    break;
                default:
                    break;
            }
        }

        private void bganimate_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (TaskIdentifier)
            {
                case "products":
                    //Products();
                    break;
                default:
                    break;
            }
        }

        private void bganimate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //tmranimate.Enabled = false;
            //pbxAnimate.Visible = false;
            //this.invoke((methodinvoker)(() => hide()));

        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            Records();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile();
        }

        private void Profile()
        {

            frmProfile frm = new frmProfile();
            frm.TopLevel = false;

            dashboard.pnDashboard.Controls.Clear();
            dashboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
            dashboard.selBtn = "profile";

            dashboard.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //imsg.info("Send a mail at KadoshMechatroics@gmail.com");
        }

        private void sync_Click(object sender, EventArgs e)
        {
            clPresandPatientID.TaskText = "DISPENSE DRUGS TO PATIENT";

            //selBtn = "dispense";
            if (clGlobalTrack.PendingPresc)
            {
                imsg.info("Pending Cart ! ");
                return;
            }
            //selbtnbgcol(selBtn);
            frmSelectPrescribers frm = new frmSelectPrescribers(dashboard, true);
            frm.TopLevel = false;

            dashboard.pnDashboard.Controls.Clear();
            dashboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
            //dashboard.selBtn = "profile";

            dashboard.Show();
            this.Hide();
        }

        private void btnExportStock_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }

        private void frmtest(object sender, EventArgs e)
        {
            frmDrugInteraction frm = new frmDrugInteraction();
            frm.Show();
            Hide();
        }

        private void btnDrugInteraction_Click(object sender, EventArgs e)
        {
            frmDrugInteractionMain frm = new frmDrugInteractionMain();
            frm.TopLevel = false;

            dashboard.pnDashboard.Controls.Clear();
            dashboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
            //dashboard.selBtn = "profile";

            dashboard.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnGuest_Click(object sender, EventArgs e)
        {

            frmFillPrescription frm = new frmFillPrescription();
            frm.TopLevel = false;

            dashboard.pnDashboard.Controls.Clear();
            dashboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
            //dashboard.selBtn = "profile";

            dashboard.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            if (db.getCount() == 0)
            {
                frmNotActivated notactivated = new frmNotActivated();
               // notactivated.ShowDialog();
            }


        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            if (db.getActivateStatus() == 0)
            {
                //Show();

                frmNotActivated notactivated = new frmNotActivated();
                //notactivated.ShowDialog();
            }
            if (db.getCount() == 0)
            {
                //frmNotActivated notactivated = new frmNotActivated();
                //notactivated.ShowDialog();
            }
        }

        private void Home_MouseEnter(object sender, EventArgs e)
        {
            if (db.getActivateStatus() == 0)
            {
                //Show();

                frmNotActivated notactivated = new frmNotActivated();
                //notactivated.ShowDialog();
            }
            if (db.getCount() == 0)
            {
                frmNotActivated notactivated = new frmNotActivated();
                //notactivated.ShowDialog();
            }
        }

        private void Home_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (db.getActivateStatus() == 0)
            {
                //Show();

                frmNotActivated notactivated = new frmNotActivated();
                //notactivated.ShowDialog();
            }
            if (db.getCount() == 0)
            {
                frmNotActivated notactivated = new frmNotActivated();
                //notactivated.ShowDialog();
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)

            {

                ReleaseCapture();

                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }
    }
}
