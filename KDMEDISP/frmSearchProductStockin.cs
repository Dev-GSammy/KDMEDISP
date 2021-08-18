using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KDMEDISP
{
    public partial class frmSearchProductStockin : Form
    {
        util imsg = new util();
        Db db = new Db();
        frmStock fs;
        public frmSearchProductStockin(frmStock frm)
        {
            InitializeComponent();
            fs = frm;
        }

        private void btnBrandexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvStockProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStockProductList.Columns[e.ColumnIndex].Name;
            try
            {
                string refno = fs.txtRefno.Text.Trim();
                string stockinBy = fs.txtStockBy.Text.Trim();
                DateTime stockinDate = fs.dtpStockInDate.Value;
                string pcode = dgvStockProductList.Rows[e.RowIndex].Cells["pcode"].Value.ToString();
                if (colName == "select")
                {
                    //  db.returnStockProduct(pcode);

                    if (imsg.prompt("Add this item?", "New stock"))
                    {
                        db.InsertStock(refno, pcode, stockinDate, stockinBy);

                    }

                    fs.loadStockIn(refno);
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtSearchProduct_Click(object sender, EventArgs e)
        {


        }
        public void loadStock()
        {
            dgvStockProductList.Rows.Clear();
            //try
            //{
                DataTable retTable = (DataTable)
              db.returnStock(txtSearchProduct.Text.ToLower().Trim());
                int i = 0;


                foreach (DataRow dr in retTable.Rows)
                {
                    int qty = int.Parse(dr["qty"].ToString());
                    int reqty = int.Parse(dr["reorderqty"].ToString());
                    Image stats = Properties.Resources.stockOK;

                    i += 1;
                    if (reqty <= qty)
                    {
          
                        dgvStockProductList.Rows.Add(i, dr["id"].ToString(), dr["nprimary"].ToString(),
                        dr["generic"].ToString(), dr["strength"].ToString(), dr["units"].ToString(),
                        dr["class"].ToString(), dr["manufacturer"].ToString(), dr["pcode"].ToString(), dr["barcode"].ToString()
                        , dr["storageLoc"].ToString(), dr["qty"].ToString(), dr["reorderqty"].ToString(), dr["expiryDate"].ToString()
                        , dr["supplier"].ToString(), dr["package"].ToString(), dr["price"].ToString(), dr["additionalInfo"].ToString(), stats);
                    }
                    else
                    {
                        dgvStockProductList.Rows.Add(i, dr["id"].ToString(), dr["nprimary"].ToString(),
                        dr["generic"].ToString(), dr["strength"].ToString(), dr["units"].ToString(),
                        dr["class"].ToString(), dr["manufacturer"].ToString(), dr["pcode"].ToString(), dr["barcode"].ToString()
                        , dr["storageLoc"].ToString(), dr["qty"].ToString(), dr["reorderqty"].ToString(), dr["expiryDate"].ToString()
                        , dr["supplier"].ToString(), dr["package"].ToString(), dr["price"].ToString(), dr["additionalInfo"].ToString());

                    }
                }
            //}
            //catch (Exception)
            //{

            //}
        }

        private void txtSearchProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            loadStock();

        }

        private void dgvStockProductList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //    string pcode = dgvStockProductList["pcode", e.RowIndex].Value.ToString();


            //    string img = pcode + ".bmp";
            //    string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);
            //    pbxStockProd.Image = imsg.LoadBitmap(imgName);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
