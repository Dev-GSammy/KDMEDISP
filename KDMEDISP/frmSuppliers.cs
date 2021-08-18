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
    public partial class frmSuppliers : Form
    {
        dashboard dboard;
        util imsg = new util();
        Db db = new Db();
        public frmSuppliers( dashboard dbd)
        {
            InitializeComponent();
            dboard = dbd;
            LoadSuppliers();

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            
            frmNewSupplier frm = new frmNewSupplier(this);
            frm.TopLevel = false;

            dboard.pnDashboard.Controls.Clear();
            dboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.btnUpdate.Enabled = false;
            frm.Show();
            dboard.Show();
        }
       
      
        private void btnNewManu_Click(object sender, EventArgs e)
        {
            frmNewSupplier frm = new frmNewSupplier(this);
            frm.TopLevel = false;

            dboard.pnDashboard.Controls.Clear();
            dboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.btnUpdate.Enabled = false;
            frm.Show();
            dboard.Show();
        }


        public void LoadSuppliers()
        {
            dgvSuppliers.Rows.Clear();
            try
            {
                DataTable retTable = (DataTable)
              db.returnSuppliers("KDMEDISP", "tblsuppliers");
                int i = 0;


                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;

                    dgvSuppliers.Rows.Add(i, dr["id"].ToString(), dr["supplier"].ToString(), dr["phone"].ToString(),dr["email"].ToString(), dr["address"].ToString());
                }
            }
            catch (Exception)
            {

            }
        }
        private void dgvPatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSuppliers.Columns[e.ColumnIndex].Name;
            string id = dgvSuppliers[1, e.RowIndex].Value.ToString();
            string supplier = dgvSuppliers[2, e.RowIndex].Value.ToString();
            string phone = dgvSuppliers[3, e.RowIndex].Value.ToString();
            string email = dgvSuppliers[4, e.RowIndex].Value.ToString();
            string address = dgvSuppliers[5, e.RowIndex].Value.ToString();
            frmNewSupplier frm = new frmNewSupplier(this);
            if (colName == "Edit")
            {

                frm.txtSupplierName.Text = supplier;
                frm.txtPhone.Text = phone;
                frm.TxtEmail.Text = email;
                frm.txtAdd.Text = address;
                frm.btnSave.Enabled = false;
                frm.lblID.Text = id;


                frm.TopLevel = false;
                dboard.pnDashboard.Controls.Clear();

                dboard.pnDashboard.Controls.Add(frm);
                frm.BringToFront();
                frm.Dock = DockStyle.Fill;

                frm.Show();
                dboard.Show();
            }
            else if (colName == "Delete")
            {
                if (imsg.prompt("Delete  " + supplier + " from records ", "Delete"))
                {
                    db.DeleteSupplier(id);
                    LoadSuppliers();
                 
                }
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
