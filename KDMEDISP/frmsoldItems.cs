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
    public partial class frmsoldItems : Form
    {
        util imsg = new util();
        Db db = new Db();
        public frmsoldItems()
        {
            InitializeComponent();
            loadsoldproducts();

        }

        public void loadsoldproducts()
        {
            dgvSoldItems.Rows.Clear();
            //try
            //{
                DataTable retTable = (DataTable)db.returnSoldItems(dtpStart.Value,dtpEnd.Value,"KDMEDISP", "tblcart");
              //db.returnProduct(0, txtSearchProduct.Text.ToLower().Trim());
                int i = 0;

            if (retTable==null)
            {
                return;
            }
                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;

                dgvSoldItems.Rows.Add(i, dr["id"].ToString(), dr["sdate"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["nprimary"].ToString(), dr["price"].ToString(), dr["qty"].ToString(),dr["discount"].ToString(), dr["total"].ToString());
                }
            //}
            //catch (Exception)
            //{

            //}
        }

        private void btnsoldExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            loadsoldproducts();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSoldItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmsoldItems_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Now.AddDays(-1);
        }
    }


}
