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
    public partial class frmLicense : Form
    {
        Db db = new Db();
        util imsg = new util();
        public static string licenseUrl = "http://127.0.0.1/WB_2020/KDLicense/index.php";
        public frmLicense()
        {
            InitializeComponent();
        }

        private void frmLicense_Load(object sender, EventArgs e)
        {
            txtUniqueID.Text = HardwareInfo.GenerateUID("KDMEDISP");
        }

        private void btnActivate_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(txtEmail.Text)|| string.IsNullOrEmpty(txtFullName.Text)|| string.IsNullOrEmpty(txtLicenseKey.Text))
            {
                imsg.info("Enter Complete Information and Try again");
                return;
            }
            //    string Data = Web.GetPost(licenseUrl, "licenseKey", txtLicenseKey.Text, "appid", "KDMEDISP", "fullname",txtFullName.Text,"uniqueid",txtUniqueID.Text,"email",txtEmail.Text);
            //imsg.info(Data.Substring(2));
            //Console.WriteLine(Data);
            //int val;
            //int.TryParse(Data.Substring(1, 1).ToString(), out val);
            //if (val==1)
            //{
                if (db.UpdateActivate())
                {
                    //imsg.info("Success, App now activated");
                    this.Dispose();
                  
                    
                }
                else
                {
                    imsg.info("Oops an error occured!");
                    return;
                }
            //}

        }

        private void btnProdExit_Click(object sender, EventArgs e)
        {
           
            if (db.getActivateStatus() == 0)
            {
                //frmNotActivated notactivated = new frmNotActivated();
                //notactivated.ShowDialog();
            }
            Hide();

        }
    }
}
