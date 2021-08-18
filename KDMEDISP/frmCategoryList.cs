using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace KDMEDISP
{
    public partial class frmCategoryList : Form
    {
        Db db = new Db();
        util imsg = new util();
        public frmCategoryList()
        {
            InitializeComponent();
            loadCategory();
        }

        private void frmCategoryList_Load(object sender, EventArgs e)
        {

        }
           public void loadCategory()
        {
            dgvCategoryList.Rows.Clear();
            try
            {
                DataTable retTable = (DataTable)
              db.returnCategory("KDMEDISP", "tblcategory");
                int i = 1;


                foreach (DataRow dr in retTable.Rows)
                {
                    dgvCategoryList.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString());
                    i += 1;
                }
            }
            catch (Exception)
            {

            }
        }



       
        private void btnCloseCategory_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            Category cat = new Category(this);
            cat.btnSave.Enabled = true;
            cat.btnUpdateCat.Enabled = false;
            cat.ShowDialog();
        }
        public bool DeleteCat(string id, string brandName)
        {
            string dbname = "KDMEDISP";
            string tablename = "tblcategory";
            try
            {
                SQLiteConnection conn = new SQLiteConnection();

                conn = db.CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string DelRec = " Delete FROM `" + tablename + "`  	 WHERE id=@id  ;";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.Parameters.AddWithValue("@id", id);
                sqlite_cmd.CommandText = DelRec;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private void dgvCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategoryList.Columns[e.ColumnIndex].Name;
            string id = dgvCategoryList[1, e.RowIndex].Value.ToString();
            string categoryName = dgvCategoryList[2, e.RowIndex].Value.ToString();
            Category frm = new Category(this);

            if (colName == "Edit")
            {

                frm.txtCategory.Text = categoryName;
                frm.btnSave.Enabled = false;
                frm.lblID.Text = id;


                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (imsg.prompt("Delete  " + categoryName + " from records ", "Delete")  )
                {
                    DeleteCat(id, categoryName);
                    loadCategory();
                }
            }
        }

       
    }
}
