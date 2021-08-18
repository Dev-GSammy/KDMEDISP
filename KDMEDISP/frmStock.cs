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
    public partial class frmStock : Form
    {
        util imsg = new util();
        Db db = new Db();
        public frmStock()
        {
            InitializeComponent();
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadStockHistory()
        {
            dgvStockHistory.Rows.Clear();
            //try
            //{
                DataTable retTable = (DataTable)
              db.returnViewStockinHistory(dtpStart.Value,dtpEnd.Value);
                int i = 0;


            foreach (DataRow dr in retTable.Rows)
            {
                i += 1;
                dgvStockHistory.Rows.Add(i, dr["id"].ToString(), dr["refno"].ToString(), dr["pcode"].ToString(), dr["nprimary"].ToString(), dr["qty"].ToString(), DateTime.Parse(dr["sdate"].ToString()).ToShortDateString(), dr["stockinby"].ToString());

            }

        //}
        //    catch (Exception)
        //    {

        //    }
}
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
        //public void loadStock()
        //{
        //    dgvStockProductList.Rows.Clear();
        //    try
        //    {
        //        DataTable retTable = (DataTable)
        //      db.returnStock(txtSearchProduct.Text.ToLower().Trim());
        //        int i = 0;


        //        foreach (DataRow dr in retTable.Rows)
        //        {
        //            i += 1;

        //            dgvStockProductList.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}
        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          
            this.Dispose();

        }

        private void txtSearchProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private string GenerateRandom()
        {
            string genPcode = " ";
            Random rand = new Random();
            int brA = rand.Next(99999);
            int brB = rand.Next(99999);
            string finalCOde = brA.ToString() + brB.ToString();
            if (db.getStockRefExist(finalCOde))
            {
                GenerateRandom();
            }
            else
            {
                genPcode = finalCOde;
            }
            return genPcode;
        }
        private void frmStock_Load(object sender, EventArgs e)
        {
            txtStockBy.Text = clGlobalTrack.LoginUsername;
            txtRefno.Text = GenerateRandom();

        }
        public void loadStockIn(string refno)
        {
           dgvAddStockIn.Rows.Clear();
            try
            {
                DataTable retTable = (DataTable)  
                    db.returnViewStockin(refno);
                int i = 0;
                                  

                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;

                    dgvAddStockIn.Rows.Add(i, dr["id"].ToString(), dr["refno"].ToString(), dr["pcode"].ToString(), dr["nprimary"].ToString(), dr["qty"].ToString(), dr["sdate"].ToString(), dr["stockinby"].ToString());
                }
            }
            catch (Exception)
            {

            }
        }
        private void dgvProductList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
          
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAddStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRefno.Text) || (string.IsNullOrWhiteSpace(txtStockBy.Text)))
            {
                imsg.info("Check Reference No and Entry name  and try again", "Add stock");
                txtRefno.Focus();
               txtRefno.BackColor = Color.FromArgb(239, 247, 254);
                return;
            }
            else
            {
                frmSearchProductStockin frm = new frmSearchProductStockin(this);
                frm.loadStock();
                frm.ShowDialog();
            }

        }

        private void dgvAddStockIn_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvAddStockIn.Columns[e.ColumnIndex].Name;
            string stockID = dgvAddStockIn.Rows[e.RowIndex].Cells["id"].Value.ToString();
            if (colname=="delete")
            {
                if(  imsg.prompt("Delete  Item","New stock") )
                {
                    db.DelStock(stockID);
                }
            }
            string refno = txtRefno.Text.Trim();

            loadStockIn(refno);

        }
           private  void clear()
        {
            txtRefno.Clear();
            txtStockBy.Clear();
            dtpStockInDate.Value = DateTime.Now;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAddStockIn.Rows.Count>0)
                {
                    if (imsg.prompt("Make Stock Entry?","Insert New Stock")   )
                    {
                        for (int i = 0; i < dgvAddStockIn.Rows.Count; i++)
                        {
                            string id = dgvAddStockIn.Rows[i].Cells[1].Value.ToString();
                            string pcode = dgvAddStockIn.Rows[i].Cells[3].Value.ToString();
                            int qty = int.Parse(dgvAddStockIn.Rows[i].Cells[5].Value.ToString());
                            db.UpdateProductQty(pcode, qty);
                            db.UpdateStock(id, qty);

                        }
                        clear();
                        dgvAddStockIn.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void txtRefno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvStockHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void tbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbStock.SelectedTab.Name == "stockhistory")
            {
                loadStockHistory();
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowRecords_Click(object sender, EventArgs e)
        {
            loadStockHistory();
        }

        private void dgvAddStockIn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string pcode = dgvAddStockIn.Rows[e.RowIndex].Cells[3].Value.ToString();

                string img = pcode + ".bmp";
                string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);
                pbxStockentryImage.Image = imsg.LoadBitmap(imgName);
                lblSelEntryStock.Text = dgvStockHistory.Rows[e.RowIndex].Cells["entrydesc"].Value.ToString();

            }
            catch (Exception )
            {

            }

        }

        private void dgvStockHistory_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string pcode = dgvStockHistory.Rows[e.RowIndex].Cells["pcode"].Value.ToString();

                string img = pcode + ".bmp";
                string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);
                pbxStockHisImg.Image = imsg.LoadBitmap(imgName);
                lblSelHisStock.Text = dgvStockHistory.Rows[e.RowIndex].Cells["desc"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pbxStockHisImg_Click(object sender, EventArgs e)
        {
            
        }

        private void txtStockBy_TextChanged(object sender, EventArgs e)
        {

        }
    }                                   
}
