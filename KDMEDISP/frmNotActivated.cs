using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP
{
    public partial class frmNotActivated : Form
    {
        public frmNotActivated()
        {
            InitializeComponent();
        }
        Home main = new Home();

        private void btnProdExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            main.Show();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            frmLicense lic = new frmLicense();

            lic.ShowDialog();
            Hide();

        }

        private void frmNotActivated_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPurchaseLicenseKey_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://flutterwave.com/pay/kdmedisp";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
