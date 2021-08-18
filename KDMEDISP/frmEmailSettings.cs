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

namespace KDMEDISP
{
    public partial class frmEmailSettings : Form
    {
        util imsg = new util();
        Db db = new Db();
        Settings s = new Settings();
        public frmEmailSettings(Settings set)
        {
            InitializeComponent();
            s = set;
        }

        private void TxtCustPhone_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsaveConfig_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text!=txtPassword.Text)
            {
                imsg.info("Password does not match! Check password!");
                return;
            }
            string filePath = imsg.retConfigPath("email");
            DefaultConfig c = new DefaultConfig();
            c.EmailServer = txtserver.Text;
            c.EmailUsername = txtUsername.Text;
            c.EmailPassword = txtPassword.Text;

            serialize st = new serialize(filePath);
            st.SerializeNow(c, c.EmailServer);
            st.SerializeNow(c, c.EmailUsername);
            st.SerializeNow(c, c.EmailPassword);
            imsg.info("Saved!");
            Dispose();
            s.Enabled = true;

            s.Show();
        }

        private void btnProdExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            s.Enabled = true;
            s.Show();
        }

        private void frmEmailSettings_Load(object sender, EventArgs e)
        {

            string filePath = imsg.retConfigPath("email");
            DefaultConfig c = new DefaultConfig();
            serialize st = new serialize(filePath);
            c = (DefaultConfig)st.DeSerializeNow(c);
          
            txtserver.Text=c.EmailServer;
           txtUsername.Text=c.EmailUsername;
           txtPassword.Text=c.EmailPassword;
           txtConfirmPass.Text=c.EmailPassword;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtserver.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
        }

        private void pnGenRec_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
