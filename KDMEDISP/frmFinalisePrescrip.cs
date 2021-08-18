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
    public partial class frmFinalisePrescrip : Form
    {
        dashboard dboard;
        Db db = new Db();
        util imsg = new util();
        bool UseDefFolder = false;
        bool AutoOpen = false;
        bool generated = false;
        public frmFinalisePrescrip(dashboard dbd)
        {
            InitializeComponent();
            dboard = dbd;
            loadPresandPatientDetails();
            
        }
       public void loadPrescriptionCart()
        {
       
            dgvFinalMedication.Rows.Clear();
            try
            {
                DataTable retTable = (DataTable)
                   db.ReturnPrescriptionCart(lblPrescriptionID.Text); ;
                int i = 0;
                if (retTable==null)
                {
                    clGlobalTrack.PendingPresc = false;
                    return;

                }
                btnGeneratePresPDF.Enabled = true;
                clGlobalTrack.PendingPresc = true;
                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;
                    
                    dgvFinalMedication.Rows.Add(i, dr["id"].ToString(), dr["medication"].ToString(), getMedication(dr["medication"].ToString()), dr["sig"].ToString(), dr["dispense"].ToString(), dr["refill"].ToString(), dr["daw"].ToString());     }
            }
           
            catch (Exception)
            {

            }


        }
        public string getMedication( string pcode)
        {
            string result = string.Empty;
            try
            {
                DataTable retTable = (DataTable)
                   db.returnDrugsfromPcode(pcode);
                int i = 0;
                if (retTable == null)
                {
                }

                foreach (DataRow dr in retTable.Rows)
                {


                    result = dr["nprimary"].ToString() + "  [" + dr["generic"].ToString() + "] " + dr["strength"].ToString() + " ";
                }
            }

            catch (Exception)
            {

            }
            return result;
        }
        private void dgvPatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddDrugtoPres_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDrugtoPres_Click(object sender, EventArgs e)
        {
            clPresandPatientID.prescriptionID = lblPrescriptionID.Text;
            
            frmAddDrugtoMedication frm = new frmAddDrugtoMedication(this);
            frm.ShowDialog();
       

        }
        private void loadPresandPatientDetails()
        {
         
            DataTable retTable = (DataTable)
                
         db.returnPatientfromtblID(db.getIDfromPatientID(clPresandPatientID.patientID).ToString());
            int i = 0;


            foreach (DataRow dr in retTable.Rows)
            {

                lblPatientFullName.Text = dr["title"].ToString() + " " + dr["firstname"].ToString() + " " + dr["LastName"].ToString() + " " + dr["othername"].ToString();
                lblPatientAdd.Text = dr["address"].ToString();
                lblPatientPh.Text = dr["phone"].ToString();
                lblDob.Text = dr["dob"].ToString();
            }

            //}
            //catch (Exception)
            //{


            //}

            //try
            //{
            
            DataTable retTable2 = (DataTable)
        db.returnPrescriberfromtblID(db.getIDfromStaffID(clPresandPatientID.prescriberID).ToString());


            foreach (DataRow dr in retTable2.Rows)
            {

                lblPrescFullName.Text = dr["title"].ToString() + " " + dr["firstname"].ToString() + " " + dr["LastName"].ToString() + " " + dr["othername"].ToString();
                lblPrescriberAdd.Text = dr["address"].ToString();
                lblPrescrPhone.Text = dr["phone"].ToString();
                lblPresEmail.Text = dr["email"].ToString();
            }
        }
        private void frmFinalisePrescrip_Load(object sender, EventArgs e)
        {
            lblStaffID.Text = clPresandPatientID.prescriberID;
            lblPatientID.Text = clPresandPatientID.patientID;
            loadPrescriptionCart();
            if(! (dgvFinalMedication.Rows.Count>0))
            {
                btnGeneratePresPDF.Enabled = false;
            }

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void dgvFinalMedication_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvFinalMedication.Columns[e.ColumnIndex].Name;
            string id = dgvFinalMedication[1, e.RowIndex].Value.ToString();
            string categoryName = dgvFinalMedication[2, e.RowIndex].Value.ToString();
            string pcode = dgvFinalMedication["pcode", e.RowIndex].Value.ToString();
            string medication = dgvFinalMedication["medication", e.RowIndex].Value.ToString();
            frmAddSig frm = new frmAddSig( this);


            if (colName == "Edit")
            {


                frm.lblMedicationDetails.Text = medication;
                frm.lblDrugPCode.Text = pcode;
                frm.btnAssignMedication.Enabled = false;
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (imsg.prompt("Delete   from records ", "Delete"))
                {
                    db.DeleteMedicationFromPrescription(id);
                    loadPrescriptionCart();
                }
            }

        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (imsg.prompt("Clear  items from Cart?"))
            {
                if (generated)
                {
                    dgvFinalMedication.Rows.Clear();
                }
                else

                {
                    for (int i = 0; i < dgvFinalMedication.Rows.Count; i++)
                    {
                        string RowID = dgvFinalMedication.Rows[i].Cells["id"].Value.ToString();
                        if ((db.DeleteMedicationFromPrescription(RowID)))
                        {
                            clGlobalTrack.PendingPresc = false;
                        } 


                    }

                    loadPrescriptionCart();
                    

                }
            }
        }

        private  async void btnGeneratePresPDF_Click(object sender, EventArgs e)
        {
            string filePath = imsg.retConfigPath("storedata");
            DefaultConfig c = new DefaultConfig();
            serialize st = new serialize(filePath);
            c = (DefaultConfig)st.DeSerializeNow(c);

            cprescriptionReport
                .PatientfullName = lblPatientFullName.Text;
            cprescriptionReport.patientAddress = lblPatientAdd.Text;
            cprescriptionReport.patientPhone = lblPatientPh.Text;
            cprescriptionReport.patientDOB = lblDob.Text;
            cprescriptionReport.prescEmail = lblPresEmail.Text;
            cprescriptionReport.PatientID = lblPatientID.Text;
            cprescriptionReport.prescAdd = lblPrescriberAdd.Text;
            cprescriptionReport.prescFullName = lblPrescFullName.Text;
            cprescriptionReport.prescStaffID = lblStaffID.Text;
            cprescriptionReport.prescPhone = lblPrescrPhone.Text;
            cprescriptionReport.PrescriptionID = lblPrescriptionID.Text;

            cGenPrescPDF gen = new cGenPrescPDF();
            if (gen.MakePDF(dgvFinalMedication, UseDefFolder, AutoOpen, false))
            {
                dgvFinalMedication.Rows.Clear();
                generated = true;
                lblPatientAdd.Text = " ";
                lblPatientFullName.Text = " ";
                lblPatientID.Text = " ";
                lblPatientPh.Text = " ";
                lblPrescriberAdd.Text = " ";
                lblPrescrPhone.Text = " ";
                lblPresEmail.Text = " ";
                lblStaffID.Text = " ";
                lblPrescriptionID.Text = " ";
                lblDob.Text = " ";
                lblID.Text = " ";
                lblPrescFullName.Text = " ";
                btnGeneratePresPDF.Enabled = false;

                clGlobalTrack.PendingPresc = false;


            }


        }

        private void bgwPrescription_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvFinalMedication.Rows.Clear();
            
            dgvFinalMedication.Enabled = false;
        }

        private void pbxDefaultFolder_Click(object sender, EventArgs e)
        {
            UseDefFolder = !UseDefFolder;
            if (UseDefFolder)
            {
                pbxDefaultFolder.Image = Properties.Resources.Toggle_On_20px;
            }
            else
            {
                pbxDefaultFolder.Image = Properties.Resources.Toggle_Off_20px;

            }
        }

        private void pbxAutoOpen_Click(object sender, EventArgs e)
        {

            AutoOpen = !AutoOpen;
            if (AutoOpen)
            {
                pbxAutoOpen.Image = Properties.Resources.Toggle_On_20px;
            }
            else
            {
                pbxAutoOpen.Image = Properties.Resources.Toggle_Off_20px;

            }
        }
    }
    }
