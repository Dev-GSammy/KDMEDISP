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
    public partial class frmAddDrugtoMedication : Form
    {

        util imsg = new util();
        Db db = new Db();
        frmPOS frmpos;
        frmFinalisePrescrip fp;
        public frmAddDrugtoMedication(frmFinalisePrescrip fpres)
        {
            InitializeComponent();
            loadProducts();
            fp = fpres;

        }
     

        //public productLookup(frmPOS fpos)
        //    {
        //        InitializeComponent();
        //        frmpos = fpos;
        //    }
            public void loadProducts()
            {
                dgvLookupProduct.Rows.Clear();
                try
                {
                    DataTable retTable = (DataTable)
                  db.returnDrugs("KDMEDISP", "tblDrugs");
                    int i = 0;


                    foreach (DataRow dr in retTable.Rows)
                    {
                        i += 1;

                        dgvLookupProduct.Rows.Add(i, dr["id"].ToString(), dr["nprimary"].ToString(),
                            dr["generic"].ToString(), dr["strength"].ToString(), dr["units"].ToString(),
                            dr["class"].ToString(), dr["manufacturer"].ToString(), dr["pcode"].ToString(), dr["barcode"].ToString()
                            , dr["storageLoc"].ToString(), dr["qty"].ToString(), dr["reorderqty"].ToString(), dr["expiryDate"].ToString()
                            , dr["supplier"].ToString(), dr["package"].ToString(), dr["price"].ToString(), dr["additionalInfo"].ToString()

                            );
                    }
                }
                catch (Exception)
                {

                }
            }
            private void dgvLookupProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                //try
                //{
                string colName = dgvLookupProduct.Columns[e.ColumnIndex].Name;
                string id = dgvLookupProduct[1, e.RowIndex].Value.ToString();
                string primary = dgvLookupProduct["nprimary", e.RowIndex].Value.ToString();
                string generic = dgvLookupProduct["generic", e.RowIndex].Value.ToString();
                string strength = dgvLookupProduct["strength", e.RowIndex].Value.ToString();
                string units = dgvLookupProduct["units", e.RowIndex].Value.ToString();
                string dclass = dgvLookupProduct["dclass", e.RowIndex].Value.ToString();
                string manufacturer = dgvLookupProduct["manufacturer", e.RowIndex].Value.ToString();
                string pcode = dgvLookupProduct["pcode", e.RowIndex].Value.ToString();
                string barcode = dgvLookupProduct["barcode", e.RowIndex].Value.ToString();
                string storageLoc = dgvLookupProduct["storageLoc", e.RowIndex].Value.ToString();
                string qty = dgvLookupProduct["qty", e.RowIndex].Value.ToString();
                string reorderqty = dgvLookupProduct["reorderqty", e.RowIndex].Value.ToString();
                string expirydate = dgvLookupProduct["expirydate", e.RowIndex].Value.ToString();
                string supplier = dgvLookupProduct["supplier", e.RowIndex].Value.ToString();
                string package = dgvLookupProduct["package", e.RowIndex].Value.ToString();
                string price = dgvLookupProduct["price", e.RowIndex].Value.ToString();
                string AdditionalInfo = dgvLookupProduct["additionalinfo", e.RowIndex].Value.ToString();
                if (colName == "addtocart")
                {

                //frmQty frmqty = new frmQty(frmpos);
                //frmqty.ProductDetails(pcode, Convert.ToDouble(price), frmpos.lblTransno.Text, int.Parse(qty));
                //string img = pcode + ".bmp";
                //string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);

                //frmqty.pbxFoundProd.Image = imsg.LoadBitmap(imgName);
                clPresandPatientID.medicationPcode = pcode;
                //frmqty.ShowDialog();
                frmAddSig frm = new frmAddSig();
                frm.btnUpdate.Enabled = false;
               // frm.TopLevel = false;

               //dboard .pnDashboard.Controls.Clear();
               // dboard.pnDashboard.Controls.Add(frm);
               // frm.Dock = DockStyle.Fill;
                frm.ShowDialog();
                

            }
                else
                {



                }

                //}
                //catch (Exception)
                //{


                //}
            }

           

            private void txtSearchProduct_TextChanged(object sender, EventArgs e)
            {
                loadProducts();
            }

            private void btnCloseProduct_Click(object sender, EventArgs e)
            {
            }

            private void btnCloseProduct_Click_1(object sender, EventArgs e)
            {
                this.Dispose();
            fp.loadPrescriptionCart();

            }

            private void dgvLookupProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
            {
                string primary = dgvLookupProduct["nprimary", e.RowIndex].Value.ToString();
                string generic = dgvLookupProduct["generic", e.RowIndex].Value.ToString();
                string price = dgvLookupProduct["price", e.RowIndex].Value.ToString();
                string pcode = dgvLookupProduct["pcode", e.RowIndex].Value.ToString();
                string storageloc = dgvLookupProduct["storageloc", e.RowIndex].Value.ToString();
                string expiryD = dgvLookupProduct["expiryDate", e.RowIndex].Value.ToString();
                string additionalInfo = dgvLookupProduct["additionalinfo", e.RowIndex].Value.ToString();
                lblExpiryDate.Text = expiryD;
                lbldrugFullName.Text = primary + " [" + generic + "]";
                lblPrice.Text = price;
                //lblAdditionalInfo.Text = additionalInfo;
                //lblStorageLoc.Text = storageloc;
            }

        private void btnCloseProduct_Click_2(object sender, EventArgs e)
        {
            this.Dispose();
            fp.loadPrescriptionCart();
        }

        private void frmAddDrugtoMedication_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + 90, this.Location.Y);

        }
    }
    }

