using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KDMEDISP
{
    public partial class Category : Form
    {
        util imsg = new util();
        frmCategoryList frmCatlist;
        Db db = new Db();
        public Category(frmCategoryList flist)
        {
            InitializeComponent();
            frmCatlist = flist;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void clear()
        {
            btnSave.Enabled = true;
            btnUpdateCat.Enabled = false;
            txtCategory.Clear();
            txtCategory.Focus();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (imsg.prompt("Save Entry ?", "Save Category"))
                {
                    CategoryInfo catinfo = new CategoryInfo();
                    catinfo.category = txtCategory.Text.ToString();      // assigned brandName to autoProperty
                    string category = catinfo.category;                 // fetch assigned brand Name
                    if (string.IsNullOrWhiteSpace(category))
                    {
                        imsg.info("Check entry and try again!", "Add Category");

                    }
                    else
                    {


                        if (db.InsertCategory(category))
                        {


                            clear();
                            imsg.info("Success!", "Add Category");
                            frmCatlist.loadCategory();
                            this.Dispose();
                        }
                        else
                        {
                            imsg.info("An error occured !", "Add Category");

                        }
                    }
                }
            }
            catch (Exception)
            {

                imsg.info("An error has occured", "Save Category");
            }
        }
        public bool UpdateCategory(string category, string categoryID)
        {
            bool status = false;
            string dbname;

            dbname = "KDMEDISP";
            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                //Console.WriteLine();
                conn = db.CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                string update = "UPDATE tblcategory SET [category]=@category WHERE id= @id";


                sqlite_cmd.Parameters.AddWithValue("@category", category);

                sqlite_cmd.Parameters.AddWithValue("@id", categoryID);


                // conn.Open();
                sqlite_cmd.CommandText = update;


                sqlite_cmd.ExecuteNonQuery();

                conn.Close();
                status = true;
            }
            catch (Exception)
            {

                status = false;
            }
            return status;
        }
        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (imsg.prompt("Update Records?", "Records"))
                {
                    CategoryInfo catinfo = new CategoryInfo();
                    catinfo.category = txtCategory.Text.ToString();
                    string CategoryName = catinfo.category;                 // fetch assigned brand Name
                    if (string.IsNullOrWhiteSpace(CategoryName))
                    {
                        imsg.info("Check entry and try again!", "Update Category");

                    }
                    else
                    {
                        if (!UpdateCategory(CategoryName, lblID.Text))
                        {
                            imsg.info("Ops, An error has occured!", "Update Category");

                        }
                        else
                        {
                            clear();
                            imsg.info("Success!", "Update Category");
                            frmCatlist.loadCategory();
                            this.Dispose();
                        }

                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
