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
    public partial class frmDrugList : Form
    {
        dashboard dboard;
        util imsg = new util();
        Db db = new Db();
        public frmDrugList(dashboard dbd)
        {
            InitializeComponent();
            dboard = dbd;
            LoadDrugs();
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            frmDrug frm = new frmDrug(this);
            frm.TopLevel = false;
            frm.txtPcode.Text = GenerateRandom();
            dboard.pnDashboard.Controls.Clear();
            dboard.pnDashboard.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.btnUpdate.Enabled = false;
            frm.Show();
            dboard.Show();
        }

        private void frmDrugList_Load(object sender, EventArgs e)
        {

        }
        public void LoadDrugs()
        {
            dgvDrugList.Rows.Clear();
            try
            {
                DataTable retTable = (DataTable)
              db.returnDrugs("KDMEDISP", "tblDrugs");
                int i = 0;


                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;

                    dgvDrugList.Rows.Add(i, dr["id"].ToString(), dr["nprimary"].ToString(), 
                        dr["generic"].ToString(), dr["strength"].ToString(), dr["units"].ToString(),
                        dr["class"].ToString(), dr["manufacturer"].ToString(), dr["pcode"].ToString(), dr["barcode"].ToString()
                        , dr["storageLoc"].ToString(), dr["qty"].ToString(), dr["reorderqty"].ToString(),dr["expiryDate"].ToString()
                        , dr["supplier"].ToString(), dr["package"].ToString(), dr["price"].ToString(), dr["additionalInfo"].ToString()

                        );
                }
            }
            catch (Exception)
            {

            }
        }
        private string GenerateRandom()
        {
            string genPcode = " ";
            Random rand = new Random();
            int brA = rand.Next(99999);
            int brB = rand.Next(99999);
            string finalCOde = brA.ToString() + brB.ToString();
            if (db.getDrugPcode(finalCOde))
            {
                GenerateRandom();
            }
            else
            {
                genPcode = finalCOde;
            }
            return genPcode;
        }
        private void dgvDrugList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            string colName = dgvDrugList.Columns[e.ColumnIndex].Name;
            string id = dgvDrugList[1, e.RowIndex].Value.ToString();
            string primary = dgvDrugList["nprimary", e.RowIndex].Value.ToString();
            string generic = dgvDrugList["generic", e.RowIndex].Value.ToString();
            string strength = dgvDrugList["strength", e.RowIndex].Value.ToString();
            string units = dgvDrugList["units", e.RowIndex].Value.ToString();
            string dclass = dgvDrugList["dclass", e.RowIndex].Value.ToString();
            string manufacturer = dgvDrugList["manufacturer", e.RowIndex].Value.ToString();
            string pcode = dgvDrugList["pcode", e.RowIndex].Value.ToString();
            string barcode = dgvDrugList["barcode", e.RowIndex].Value.ToString();
            string storageLoc = dgvDrugList["storageLoc", e.RowIndex].Value.ToString();
            string qty = dgvDrugList["qty", e.RowIndex].Value.ToString();
            string reorderqty = dgvDrugList["reorderqty", e.RowIndex].Value.ToString();
            string expirydate = dgvDrugList["expirydate", e.RowIndex].Value.ToString();
            string supplier = dgvDrugList["supplier", e.RowIndex].Value.ToString();
            string package = dgvDrugList["package", e.RowIndex].Value.ToString();
            string price = dgvDrugList["price", e.RowIndex].Value.ToString();
            string AdditionalInfo = dgvDrugList["additionalinfo", e.RowIndex].Value.ToString();

            frmDrug frm = new frmDrug(this);
            frmDrug.NewRec = false;
            if (colName == "Edit")
            {

                frm.txtprimary.Text = primary;
                frm.txtGeneric.Text = generic;
                frm.txtstrength.Text = strength;
                frm.txtUnit.Text = units;
                frm.cboClassofDrug.Text = dclass;
                frm.cboManufacturers.Text = manufacturer;
                frm.txtPcode.Text = pcode;
                frm.txtBarCode.Text = barcode;
                frm.txtStorageLocation.Text = storageLoc;
                frm.txtIniQty.Text = qty;
                frm.txtReorderLevel.Text = reorderqty;
                frm.dtpExpiry.Text = expirydate;
                frm.cboSupplier.Text = supplier;
                frm.cboPackage.Text = package;
                frm.txtPrice.Text = price;
                frm.txtDrugAddInfo.Text = AdditionalInfo;

                


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
                if (imsg.prompt("Delete  " + primary + " from records ", "Delete"))
                {
                    db.DeleteDrugs(id);
                    LoadDrugs();

                }
                ;
            }
        }

        private void dgvDrugList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          string primary = dgvDrugList["nprimary", e.RowIndex].Value.ToString();
            string generic = dgvDrugList["generic", e.RowIndex].Value.ToString();
           string price = dgvDrugList["price", e.RowIndex].Value.ToString();
            string pcode = dgvDrugList["pcode", e.RowIndex].Value.ToString();
            string storageloc = dgvDrugList["storageloc", e.RowIndex].Value.ToString();
            string expiryD = dgvDrugList["expiryDate", e.RowIndex].Value.ToString();
            string additionalInfo = dgvDrugList["additionalinfo", e.RowIndex].Value.ToString();

            lblExpiryDate.Text = expiryD;
            lbldrugFullName.Text = primary + " [" + generic+"]";
            lblPrice.Text = price;
            lblAdditionalInfo.Text = additionalInfo;
            lblStorageLoc.Text = storageloc;
            string img = pcode + ".bmp";
            string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);
            pbxPatientImg.Image = imsg.LoadBitmap(imgName);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }
    }
}
