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
    public partial class frmStoreData : Form
    {
        Settings ss;
        util imsg = new util();
        public frmStoreData(Settings st)
        {
            InitializeComponent();
            ss = st;
        }

        private void frmStoreData_Load(object sender, EventArgs e)
        {
            string filePath = imsg.retConfigPath("storedata");
            DefaultConfig c = new DefaultConfig();
            serialize st = new serialize(filePath);
            c = (DefaultConfig)st.DeSerializeNow(c);
            txtStoreName.Text = c.StoreName;
           txtPhone.Text = c.StorePhone ;
            txtStoreAdd.Text = c.StoreAddress;
           txtStoreTag.Text = c.StoreTag ;
        txtEmail.Text = c.ReceiptEmail ;
        }

        private void pnGenRec_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnsaveConfig_Click(object sender, EventArgs e)
        {
            string filePath = imsg.retConfigPath("storedata");
            DefaultConfig c = new DefaultConfig();



            c.StoreName = txtStoreName.Text.Trim() ;
            c.StorePhone = txtPhone.Text;
            c.StoreAddress = txtStoreAdd.Text;
            c.StoreTag = txtStoreTag.Text;
            c.ReceiptEmail = txtEmail.Text;

            serialize st = new serialize(filePath);
            st.SerializeNow(c, c.StoreName);
            st.SerializeNow(c, c.StorePhone);
            st.SerializeNow(c, c.StoreAddress);
            st.SerializeNow(c, c.StoreTag);
            st.SerializeNow(c, c.ReceiptEmail);
            imsg.info(" Details Saved!");
            ss.Enabled = true;
            ss.Show();
            Dispose();
        }

        private void btnProdExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ss.Enabled = true;
            ss.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPhone.Clear();
            txtStoreAdd.Clear();
            txtStoreName.Clear();
            txtStoreTag.Clear();
            
        }
    }
}
