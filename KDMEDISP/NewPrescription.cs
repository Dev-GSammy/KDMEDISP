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
    public partial class NewPrescription : Form
    {
        util imsg = new util();
        Db db = new Db();
        dashboard dboard = new dashboard();
        string SelpatientID = string.Empty;
        bool POS = false;
        public NewPrescription(dashboard dbd, bool loadPOS)
        {
            InitializeComponent();
            loadPatients();
            dboard = dbd;
            POS = loadPOS;
        }
       
            private void NewPrescription_Load(object sender, EventArgs e)
        {
            if (!(dgvPatientList.Rows.Count > 0))
            {
                btnProceed.Enabled = false;
            }
            lblTask.Text = clPresandPatientID.TaskText;

        }
        private string getPresID()
        {
                string transno="";
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string trans = "";
                DataTable retTable = (DataTable)db.returnPresID(sdate);
                int count;
                if (retTable.Rows.Count > 0)
                {
                    foreach (DataRow dr in retTable.Rows)
                    {


                        transno = dr[0].ToString();
                        transno = transno.Replace("DISP/", " ");
                        transno=transno.Trim();
                        count = int.Parse(transno.Substring(8, 4));
                        transno = sdate + (count + 1);
                    }
                }
                else
                {
                    transno = sdate + "1001";
                }
            }
            catch (Exception)
            {

            }
            return transno;
        }
        public void loadPatients()
        {
            dgvPatientList.Rows.Clear();
            try
            {
                DataTable retTable = (DataTable)
              db.returnPatients("KDMEDISP", "tblPatients");
                int i = 0;


                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;

                    dgvPatientList.Rows.Add(i, dr["id"].ToString(), dr["title"].ToString(), dr["firstname"].ToString(), dr["lastname"].ToString(), dr["othername"].ToString(), dr["sex"].ToString(),
                        dr["phone"].ToString(), dr["nextofkin"].ToString(), dr["nextofkinphone"].ToString(), dr["dob"].ToString(), dr["patientID"].ToString(), dr["allergies"].ToString(), dr["address"].ToString());
                }
            }

            catch (Exception)
            {

            }


        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            clPresandPatientID.patientID = SelpatientID;
            Console.WriteLine(SelpatientID);
            if (POS)
            {
                frmPOS frm = new frmPOS();
                this.Hide();

                frm.ShowDialog();
            }
            else
            {
                frmFinalisePrescrip frm = new frmFinalisePrescrip(dboard);
                frm.lblPatientID.Text = clPresandPatientID.patientID;
                frm.TopLevel = false;
                frm.lblPrescriptionID.Text = "DISP/" + getPresID();
                dboard.pnDashboard.Controls.Clear();
                dboard.pnDashboard.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            
        }

        private void dgvPatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPatientList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvPatientList.Columns[e.ColumnIndex].Name;
            string firstname = dgvPatientList["firstname", e.RowIndex].Value.ToString();
            string lastname = dgvPatientList["lastname", e.RowIndex].Value.ToString();
            string othername = dgvPatientList["othername", e.RowIndex].Value.ToString();
            string allergies = dgvPatientList["allergies", e.RowIndex].Value.ToString();
            string address = dgvPatientList["address", e.RowIndex].Value.ToString();
            string phone = dgvPatientList["phone", e.RowIndex].Value.ToString();
            string nok = dgvPatientList["nextofkin", e.RowIndex].Value.ToString();
            string nokphone = dgvPatientList["nextofkinphone", e.RowIndex].Value.ToString();
            string pimgid = dgvPatientList["PatientID", e.RowIndex].Value.ToString();
            SelpatientID = pimgid;
            pimgid = db.getIDfromPatientID(pimgid).ToString();
            //lblPatientFullName.Text = firstname + " " + lastname + " " + othername;
            lblPhone.Text = phone;
            lblAdress.Text = address;
            lblallergies.Text = allergies;
            string imgID = "PT" + pimgid;
            string img = imgID + ".bmp";
            string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);
            pbxPatientImg.Image = imsg.LoadBitmap(imgName);
        }

        private void dgvPrescibersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
