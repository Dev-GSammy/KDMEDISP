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
    public partial class frmFillPrescription : Form
    {
        util imsg = new util();
        Db db = new Db();
        frmPOS frm = new frmPOS();

        public frmFillPrescription()
        {
            InitializeComponent();
        }

        private void frmFillPrescription_Load(object sender, EventArgs e)
        {
           
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            clPresandPatientID.GuesPatientName = txtGuestPatientName.Text;
            clPresandPatientID.GuesPatientPh = txtGuestPatientPhone.Text;
            clPresandPatientID.GuesPatientAddress = txtGuestPatientAddres.Text;
            clPresandPatientID.Guest = true;

            frmPOS frm = new frmPOS();
            this.Hide();

            frm.ShowDialog();

        }
       
    }
}
