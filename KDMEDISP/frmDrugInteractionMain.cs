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
    public partial class frmDrugInteractionMain : Form
    {
        util imsg = new util();

        dashboard ds = new dashboard();
        public static bool fromPos = false;
        frmPOS p;
        public frmDrugInteractionMain()
        {
            InitializeComponent();
            //p = pos;
        }

        private void btnInteraction_Click(object sender, EventArgs e)
        {
            frmDrugInteraction frm = new frmDrugInteraction();


            if (!fromPos)
            {

                frm.TopLevel = false;

                ds.pnDashboard.Controls.Clear();
                ds.pnDashboard.Controls.Add(frm);
                frm.BringToFront();
                frm.Dock = DockStyle.Fill;

                frm.Show();
                ds.Show();
                Hide();
            }
            else
            {

                frmDrugInteraction.fromPos = true;
                frm.ShowDialog();
            }
        }

        private void btnMultipleIn_Click(object sender, EventArgs e)
        {
            frmMultipleDrugsInte frm = new frmMultipleDrugsInte();

            if (!fromPos)
            {
                frm.TopLevel = false;

                ds.pnDashboard.Controls.Clear();
                ds.pnDashboard.Controls.Add(frm);
                frm.BringToFront();
                frm.Dock = DockStyle.Fill;

                frm.Show();
                ds.Show();
                Hide();
            }
            else
            {
                frmMultipleDrugsInte.fromPos = true;

                frm.ShowDialog();
            }
        }

        private void frmDrugInteractionMain_Load(object sender, EventArgs e)
        {
            if (fromPos)
            {
                btnExit.Visible = true;
            }
            else
            {
                btnExit.Visible = false;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
}