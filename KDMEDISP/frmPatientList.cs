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
    public partial class frmPatientList : Form
    {
        Db db = new Db();
        util imsg = new util();
        dashboard dboard;
        public frmPatientList(dashboard db)
        {
            InitializeComponent();
            dboard = db;
        }

        private void frmPatientList_Load(object sender, EventArgs e)
        {
            loadPatients();

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

                    dgvPatientList.Rows.Add(i, dr["id"].ToString(), dr["title"].ToString(), dr["firstname"].ToString(), dr["lastname"].ToString(), dr["othername"].ToString(), 
                        dr["phone"].ToString(),  dr["nextofkin"].ToString(), dr["nextofkinphone"].ToString(), dr["dob"].ToString(), dr["patientID"].ToString(), dr["allergies"].ToString(), dr["address"].ToString());
                }
            }
         
            catch (Exception)
            {

            }
            

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            //selBtn = "brand";

            //selbtnbgcol(selBtn);
            frmPatients frm = new frmPatients(this);
            frm.TopLevel = false;

            dboard.pnDashboard.Controls.Clear();
            dboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.btnUpdate.Enabled = false;
            frm.Show();
            dboard.Show();
        }

        private void dgvPatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvPatientList.Columns[e.ColumnIndex].Name;
            string id = dgvPatientList[1, e.RowIndex].Value.ToString();
            string patientID = dgvPatientList["patientID", e.RowIndex].Value.ToString();
            DataTable retTable = (DataTable)
                         db.returnPatientfromID(patientID); // fetch all data of that patient with that id from database

            int i = 0;

            frmPatients frm = new frmPatients(this);

            foreach (DataRow dr in retTable.Rows)

            {
                frm.txtfirstname.Text = dr.Field<string>("firstname");
                frm.txtLastName.Text = dr.Field<string>("lastname");
                frm.cbxSex.Text = dr.Field<string>("sex");
                frm.cbxTitle.Text = dr.Field<string>("title");
                frm.dtpDob.Text = dr.Field<string>("dob");
                frm.txtOtherName.Text = dr.Field<string>("othername");
                frm.txtPhone.Text = dr.Field<string>("phone");
                frm.txtpatientAdd.Text = dr.Field<string>("address");
                frm.txtNextofKin.Text = dr.Field<string>("nextofkin");
                frm.txtNextofkinPhone.Text = dr.Field<string>("nextofkinphone");
                frm.txtOrganisation.Text = dr.Field<string>("organisation");
                frm.txtAllergies.Text = dr.Field<string>("allergies");
                frm.txtMedicalNotes.Text = dr.Field<string>("medicalnotes");
                string idstring = dr.Field<string>("patientID");
                frm.lblid.Text=Convert.ToString(db.getIDfromPatientID(idstring));


            }
             
       
            if (colName == "Edit")
            {

                frm.btnSave.Enabled = false;

                frm.TopLevel = false;

                dboard.pnDashboard.Controls.Clear();
                dboard.pnDashboard.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                dboard.Show();
            }
            else if (colName == "Delete")
            {
                if (imsg.prompt("Delete  Patient from records ", "Delete"))
                {
                    db.DeletePatient(id, patientID);
                    loadPatients();
                }
            }
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
            string pimgid =  dgvPatientList["PatientID", e.RowIndex].Value.ToString();
            pimgid = db.getIDfromPatientID(pimgid).ToString();
            lblPatientFullName.Text = firstname + " " + lastname + " " + othername;
            lblPhone.Text = phone;
            lblAdress.Text = address;
            lblallergies.Text = allergies;
            lblnok.Text = nok;
            string imgID=  "PT" + pimgid;
            string img = imgID + ".bmp";
            string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);
            pbxPatientImg.Image = imsg.LoadBitmap(imgName);
        }

        private void txtSearchProduct_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblallergies_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void lblAdress_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblnok_Click(object sender, EventArgs e)
        {

        }

        private void lblx_Click(object sender, EventArgs e)
        {

        }

        private void lblNextofKinPhone_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblPatientFullName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pbxPatientImg_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseCategory_Click(object sender, EventArgs e)
        {

        }
    }
        
    }

