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
    public partial class frmSelectPrescribers : Form
    {
        Db db = new Db();
        util imsg = new util();
        bool POS = false;
        dashboard dboard = new dashboard();
        public string selprescriberID = string.Empty;
        public frmSelectPrescribers(dashboard dbd, bool loadPOS)
        {
            InitializeComponent();
            dboard = dbd; 
            loadPrescribers();
            if (!(dgvPrescibersList.Rows.Count>0))
            {
                btnProceed.Enabled = false;
            }
            POS = loadPOS;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dgvPrescibersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadPrescribers()
        {
            dgvPrescibersList.Rows.Clear();
            try
            {
                DataTable retTable = (DataTable)
              db.returnPrescribers("KDMEDISP", "tblprescribers");
                int i = 0;


                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;

                    dgvPrescibersList.Rows.Add(i, dr["id"].ToString(), dr["title"].ToString(), dr["firstname"].ToString(), dr["lastname"].ToString(), dr["othername"].ToString(),
                        dr["phone"].ToString(), dr["dob"].ToString(), dr["address"].ToString(), dr["email"].ToString(), dr["staffID"].ToString());
                }
            }

            catch (Exception)
            {

            }


        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            NewPrescription frm = new NewPrescription(dboard,POS);
            frm.TopLevel = false;
            clPresandPatientID.prescriberID = selprescriberID;
            dboard.pnDashboard.Controls.Clear();
            dboard.pnDashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void dgvPrescibersList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string firstname = dgvPrescibersList["firstname", e.RowIndex].Value.ToString();
            string lastname = dgvPrescibersList["lastname", e.RowIndex].Value.ToString();
            string othername = dgvPrescibersList["othername", e.RowIndex].Value.ToString();
            string address = dgvPrescibersList["address", e.RowIndex].Value.ToString();
            string phone = dgvPrescibersList["phone", e.RowIndex].Value.ToString();
            string staffID = dgvPrescibersList["staffID", e.RowIndex].Value.ToString();
            string designation = dgvPrescibersList["designation", e.RowIndex].Value.ToString();
            string email = dgvPrescibersList["email", e.RowIndex].Value.ToString();
            //lblPrescriberFullName.Text = firstname + " " + lastname + " " + othername;
            selprescriberID = staffID;
            lblPhone.Text = phone;
            lblAdress.Text = address;
            lblDesignation.Text = designation;
            lblEmail.Text = email;
            lblStaffiD.Text = staffID;
            string img = staffID + ".bmp";
            string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);
            pbxPatientImg.Image = imsg.LoadBitmap(imgName);

        }

        private void frmSelectPrescribers_Load(object sender, EventArgs e)
        {
            lblTask.Text = clPresandPatientID.TaskText;
        }
    }
}
