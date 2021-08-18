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
    public partial class frmRecords : Form
    {
        dashboard ds = new dashboard() ;
        public frmRecords(dashboard frm)
        {
            InitializeComponent();
            ds = frm;
        }

        private void btnSoldItems_Click(object sender, EventArgs e)
        {
            frmsoldItems frm = new frmsoldItems();
            frm.TopLevel = false;

            ds.pnDashboard.Controls.Clear();
            ds.pnDashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            this.Hide();
            frm.Show();
            
        }
    
       

        private void btnTopSelling_Click(object sender, EventArgs e)
        {
            frmTopSelling frm = new frmTopSelling();
            frm.TopLevel = false;

            ds.pnDashboard.Controls.Clear();
            ds.pnDashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            this.Hide();
            frm.Show();

        }

        private void btnCashierAnalytics_Click(object sender, EventArgs e)
        {
            frmCashierAnalytics frm = new frmCashierAnalytics();
            frm.TopLevel = false;

            ds.pnDashboard.Controls.Clear();
            ds.pnDashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            this.Hide();
            frm.Show();
        }
    }
}
