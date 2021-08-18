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
    public partial class frmManufacturersList : Form
    {
        dashboard dboard;
        frmDrug drg;
        util imsg = new util();
        Db db = new Db();
        public frmManufacturersList(dashboard dbd)
        {
            InitializeComponent();
            dboard = dbd;
            loadManufacturers();
        }
        public frmManufacturersList(frmDrug _drg)
        {
            InitializeComponent();
            drg = _drg;
            loadManufacturers();
        }
        private void btnNewManu_Click(object sender, EventArgs e)
        {
           frmNewManufacturers frm = new frmNewManufacturers(this);
            frm.TopLevel = false;

            dboard.pnDashboard.Controls.Clear();
            dboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.btnUpdate.Enabled = false;
            frm.Show();
            dboard.Show();
        }

        private void dgvManufacturerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvManufacturerList.Columns[e.ColumnIndex].Name;
            string id = dgvManufacturerList[1, e.RowIndex].Value.ToString();
            string manufName = dgvManufacturerList[2, e.RowIndex].Value.ToString();
           frmNewManufacturers frm = new frmNewManufacturers(this);
            if (colName == "Edit")
            {

                frm.txtmanufName.Text = manufName;
                frm.btnSave.Enabled = false;
                frm.lblID.Text = id;


                try
                {
                    frm.TopLevel = false;
                    dboard.pnDashboard.Controls.Clear();

                    dboard.pnDashboard.Controls.Add(frm);
                    frm.BringToFront();
                    frm.Dock = DockStyle.Fill;

                    frm.Show();
                    dboard.Show();
                }
                catch (Exception)
                {

                }
            }
            else if (colName == "Delete")
            {
                if (imsg.prompt("Delete  " + manufName + " from records ", "Delete"))
                {
                    db.DeleteManufacturer(id);
                    loadManufacturers();
                }
                frmManufacturersList M = new frmManufacturersList (dboard);

                M.TopLevel = false;
                    dboard.pnDashboard.Controls.Clear();

                    dboard.pnDashboard.Controls.Add(M);
                M.BringToFront();
                M.Dock = DockStyle.Fill;

                    
                    dboard.Show();
            }
        }
    
        public void loadManufacturers()
        {
            dgvManufacturerList.Rows.Clear();
            try
            {
                DataTable retTable = (DataTable)
              db.returnManufacturers("KDMEDISP", "tblmanufacturers");
                int i = 0;


                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;

                    dgvManufacturerList.Rows.Add(i, dr["id"].ToString(), dr["manufacturer"].ToString());
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnCloseCategory_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
