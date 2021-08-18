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
    public partial class frmAddSig : Form
    {
        public static string MedicationDetail = "...";
        cSig sig = new cSig();
        cDaw Daw = new cDaw();
        Db db = new Db();
        public static int i=0;
        string how = "", when = "", often = "", howmuch = "";
        util imsg = new util();
        frmFinalisePrescrip frm;
        public frmAddSig()
        {
            InitializeComponent();
            loadSigtoComboBoxes();
            loadDaw();
            getMedication();

        }
        public frmAddSig( frmFinalisePrescrip fp)
        {
            InitializeComponent();
            loadSigtoComboBoxes();
            loadDaw();
            getMedication();
            frm = fp;
        }

        private void frmAddSig_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + 70, this.Location.Y-60);
            lblPatientID.Text = clPresandPatientID.patientID;
            lblStaffID.Text = clPresandPatientID.prescriberID;
            lblPresID.Text = clPresandPatientID.prescriptionID;

        }
        public void loadDaw()
        {

            //Console.WriteLine(sig.sigHowKV("ad"));
            foreach (var item in Daw.Daw.AllKeys)
            {
                cbxDaw.Items.Add(item);
            }
            

        }
        public  void getMedication()
        {
            
                 try
            {
                DataTable retTable = (DataTable)
                   db.returnDrugsfromPcode(clPresandPatientID.medicationPcode);
                int i = 0;
                if (retTable == null)
                {
                    return;
                }

                foreach (DataRow dr in retTable.Rows)
                {


                    lblMedicationDetails.Text = dr["nprimary"].ToString() + "  [" + dr["generic"].ToString() + "] " + dr["strength"].ToString() + " ";  }
            }

            catch (Exception)
            {

            }
        }
        public void loadSigtoComboBoxes()
        {

            //Console.WriteLine(sig.sigHowKV("ad"));
            foreach (var item in sig.sigHow.AllKeys)
            {
                cbxSigHow.Items.Add(item);
            }
            foreach (var item in sig.sigHowMuch.AllKeys)
            {
                cbxSigHowMuch.Items.Add(item);
            }
            foreach (var item in sig.sigOften.AllKeys)
            {
                cbxSigOften.Items.Add(item);
            }
            foreach (var item in sig.sigWhen.AllKeys)
            {
                cbxSigWhen.Items.Add(item);
            }

        }

        private void cbxSigOften_SelectedIndexChanged(object sender, EventArgs e)
        {
            often = sig.sigOftenKV(cbxSigOften.Text);
            generateSig();
        }

        private void cbxSigWhen_SelectedIndexChanged(object sender, EventArgs e)
        {
            when = sig.sigWhenKV(cbxSigWhen.Text);
            generateSig();
        }

        private void cbxSigHow_SelectedIndexChanged(object sender, EventArgs e)
        {
            how = sig.sigHowKV(cbxSigHow.Text);
            generateSig();
        }           

        private void txtSigQty_Click(object sender, EventArgs e)
        {

        }

        private void cbxDaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDaw.Text = Daw.DecodeDaw(cbxDaw.Text);


        }

        private void btnAssignMedication_Click(object sender, EventArgs e)
        {

            //fpres.dgvFinalMedication.Rows.Add(i + 1, lblMedicationDetails.Text, txtSigTrans.Text, txtDispense.Text, txtRefill.Text);
            if (  db.InsertNewPrescription(lblPresID.Text,db.getIDfromStaffID(lblStaffID.Text).ToString(),clPresandPatientID.medicationPcode        ,
                   db.getIDfromPatientID(lblPatientID.Text).ToString() ,                 txtSigTrans.Text,                 txtDispense.Text,
            txtRefill.Text, lblDaw.Text, DateTime.Now.ToShortDateString()))
            {
                imsg.info(" Medication Added");
            }
            else
            {
                Console.WriteLine( "Error Adding Medication");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

                if (db.InsertUpdatePrescription(lblPresID.Text,lblDrugPCode.Text, txtSigTrans.Text, txtDispense.Text, txtRefill.Text, lblDaw.Text))
            {
                imsg.info("medication updated");
                frm.loadPrescriptionCart();

            }
            else
            {
                imsg.info("error updating medication");
            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void generateSig()
        {
            txtSigTrans.Text = "Take " + txtSigQty.Text + " " + howmuch + " " + often + " " + when + " [" + how + " ]";
        }
        private void cbxSigHowMuch_SelectedIndexChanged(object sender, EventArgs e)
        {
            howmuch = sig.sigHowMuchKV(cbxSigHowMuch.Text);
            generateSig();
        }
    }
}
