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
    public partial class productLookup : Form
    {
        util imsg = new util();
        Db db = new Db();
        frmPOS frmpos;
        public productLookup(frmPOS fpos)
        {
            InitializeComponent();
            frmpos = fpos;
            loadProducts();
        }
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
                    
                        frmQty frmqty = new frmQty(frmpos);
                        frmqty.ProductDetails(pcode, Convert.ToDouble(price),frmpos.lblTransno.Text,int.Parse(qty));
                            string img = pcode + ".bmp";
                            string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);

                            frmqty.pbxFoundProd.Image = imsg.LoadBitmap(imgName);
             
            frmqty.ShowDialog();
                    
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

        }

        private void dgvLookupProduct_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            string primary = dgvLookupProduct["nprimary", e.RowIndex].Value.ToString();
            string generic = dgvLookupProduct["generic", e.RowIndex].Value.ToString();
            string price = dgvLookupProduct["price", e.RowIndex].Value.ToString();
            string pcode = dgvLookupProduct["pcode", e.RowIndex].Value.ToString();
            string storageloc = dgvLookupProduct["storageloc", e.RowIndex].Value.ToString();
            string expiryD = dgvLookupProduct["expiryDate", e.RowIndex].Value.ToString();
            string additionalInfo = dgvLookupProduct["additionalinfo", e.RowIndex].Value.ToString();
            string manuf= dgvLookupProduct["manufacturer", e.RowIndex].Value.ToString();
            lblExpiryDate.Text = expiryD;
            lblManufact.Text = primary + " [" + generic + "]";
            lblPrice.Text = price;
            lblAdditionalInfo.Text = additionalInfo;
            lblStorageLoc.Text = storageloc;
            lblManufact.Text = manuf;
            string img = pcode + ".bmp";
            string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);
            pbxDrugImage.Image = imsg.LoadBitmap(imgName);
        }

        private void txtSearchProduct_Click(object sender, EventArgs e)
        {

        }

        private void pbxPatientImg_Click(object sender, EventArgs e)
        {

        }

        private void lblStorageLoc_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblExpiryDate_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblAdditionalInfo_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbldrugFullName_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblx_Click(object sender, EventArgs e)
        {

        }

        private void productLookup_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + 90, this.Location.Y);

        }
    }
}
