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
    public partial class frmDoctorList : Form
    {
        dashboard dboard;
        Db db = new Db();
        util imsg = new util();
        public frmDoctorList(dashboard dbd)
        {
            InitializeComponent();
            dboard = dbd;
            loadPrescribers();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAdress_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblPatientFullName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void btnNewPrescriber_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor(this);
            frm.TopLevel = false;

            dboard.pnDashboard.Controls.Clear();
            dboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.btnUpdate.Enabled = false;
            frm.Show();
            dboard.Show();
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
       

           
          

            private void dgvPatientList_RowEnter(object sender, DataGridViewCellEventArgs e)
            {

                string colName = dgvPrescibersList.Columns[e.ColumnIndex].Name;
                string firstname = dgvPrescibersList["firstname", e.RowIndex].Value.ToString();
                string lastname = dgvPrescibersList["lastname", e.RowIndex].Value.ToString();
                string othername = dgvPrescibersList["othername", e.RowIndex].Value.ToString();
                string address = dgvPrescibersList["address", e.RowIndex].Value.ToString();
                string phone = dgvPrescibersList["phone", e.RowIndex].Value.ToString();
                string staffID = dgvPrescibersList["staffID", e.RowIndex].Value.ToString();
                string designation = dgvPrescibersList["designation", e.RowIndex].Value.ToString();
                string email = dgvPrescibersList["email", e.RowIndex].Value.ToString();
            lblPrescriberFullName.Text = firstname + " " + lastname + " " + othername;
                lblPhone.Text = phone;
                lblAdress.Text = address;
            lblDesignation.Text = designation;
            lblEmail.Text = email;
            lblStaffiD.Text = staffID;
                string img = staffID + ".bmp";
                string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);
                pbxPatientImg.Image = imsg.LoadBitmap(imgName);
            }

            private void txtSearchProduct_Click(object sender, EventArgs e)
            {

            }

        private void dgvPrescibersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvPrescibersList.Columns[e.ColumnIndex].Name;
            string id = dgvPrescibersList[1, e.RowIndex].Value.ToString();
            string staffID = dgvPrescibersList["staffID", e.RowIndex].Value.ToString();
            DataTable retTable = (DataTable)
                         db.returnPrescriberfromStaffID(staffID); // fetch all data of that patient with that id from database

            int i = 0;

            frmDoctor frm = new frmDoctor(this);

            foreach (DataRow dr in retTable.Rows)

            {
                frm.txtFirstName.Text = dr.Field<string>("firstname");
                frm.txtLastName.Text = dr.Field<string>("lastname");
                frm.cboSex.Text = dr.Field<string>("sex");
                frm.cbxTitle.Text = dr.Field<string>("title");
                frm.dtpDob.Text = dr.Field<string>("dob");
                frm.txtOtherName.Text = dr.Field<string>("othername");
                frm.txtPhone.Text = dr.Field<string>("phone");
                frm.txtAdd.Text = dr.Field<string>("address");
                frm.TxtEmail.Text = dr.Field<string>("email");
                string idstring = dr.Field<string>("staffID");
                frm.lblID.Text = Convert.ToString(db.getIDfromStaffID(idstring));


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
                    db.DeletePrecriber(id);
                    loadPrescribers();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchProduct_Click_1(object sender, EventArgs e)
        {

        }

        private void pbxPatientImg_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseCategory_Click(object sender, EventArgs e)
        {
            clGeneratePrescPDF gn = new clGeneratePrescPDF();
            gn.MakePDF(dgvPrescibersList, "dd", "d", true);
        }

        private void frmDoctorList_Load(object sender, EventArgs e)
        {

        }
    }

    }



