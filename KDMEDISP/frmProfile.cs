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
    public partial class frmProfile : Form
    {
        Db db = new Db();
        util imsg = new util();

        public frmProfile()
        {
            InitializeComponent();
        }
        private void frmProfile_Load(object sender, EventArgs e)
        {
            try
            {
                loadAdmins();
            }
            catch (Exception)
            {

            }
        }
        public void loadAdmins()
        {


            cboCashiers.Items.Clear();
            if (!clGlobalTrack.SuperAdmin)
            {
                cboCashiers.Items.Add(clGlobalTrack.LoginUsername);
                cboCashiers.SelectedIndex = 0;
                cboCashiers.Enabled = false;



                return;
            }
            else
            {
                cboCashiers.Enabled = false;

                DataTable retTable = (DataTable)db.viewAdmin("KDMEDISP", "AdminLogin");
                foreach (DataRow item in retTable.Rows)
                {
                    if (!cboCashiers.Items.Contains(item["username"].ToString()))
                    {
                        cboCashiers.Items.Add(item["username"].ToString());

                    }
                }
                cboCashiers.SelectedIndex = 0;
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnLoginMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //if (!clGlobalTrack.SuperAdmin)
            //{
            //    imsg.info("Restricted to Super Admin!");
            //    return;
            //}
            if (!string.IsNullOrWhiteSpace(txtCreateUsername.Text) && !string.IsNullOrWhiteSpace(txtCreatePassword.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (txtCreateConfirmPassword.Text == txtCreatePassword.Text)
                {
                    string username = txtCreateUsername.Text.ToLower();
                    string password = txtCreatePassword.Text;
                    if (password.Length<4)
                    {
                        imsg.info("Password Length must be greater than 3 Characters");
                        return;
                    }
                    if (!password.Any(char.IsDigit) )
                    {
                        imsg.info("Password must contain a number");
                        return;
                    }
                    
                    string email = txtEmail.Text;

                    if (!email.Contains("@") )
                    {
                        imsg.info("Invalid Email address");
                        return;
                    }
                    int privilege = 1;
                    Db admin = new Db();
                    if (admin.InsertAdmin(username, password, email, privilege))

                    {
                        imsg.info("Success");
                        txtCreateUsername.Clear();
                       txtCreatePassword.Clear();
                       txtCreateConfirmPassword.Clear();
                        txtEmail.Clear();
                        loadAdmins(); 

                    }
                    else

                    {
                        imsg.info("An Error occured!");

                    }

                }
                else
                {
                    imsg.info(" Enter Matching Password!");

                }

            }
            else
            {
                imsg.info("An Error occured!");

            }
        }

        private void cboCashiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskReport ts   ;
            ts=(TaskReport) db.getSingleAdmin("KDMEDISP", "adminlogin", cboCashiers.Text);

            lblID.Text = ts.numData.ToString() ;
            txtUsername.Text = cboCashiers.Text;
        }

       

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                db.UpdateAdmin(lblID.Text, txtUsername.Text, txtPassword.Text);

            }
            catch (Exception)
            {

            }
            
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Enabled = false;
            imsg.info("Success");
            loadAdmins();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnEditUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private int getAdminID()
        {
            TaskReport ts = new TaskReport();
            ts = (TaskReport)db.getSingleAdmin("KDMEDISP", "adminlogin", cboCashiers.Text);
            Console.WriteLine(ts.numData);
            return ts.numData;
        }
        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            try
            {
                if (!clGlobalTrack.SuperAdmin)
                {
                    imsg.info("Restricted to Super Admin!");
                    return;
                }
                db.DeleteAdmin("KDMEDISP", "adminlogin", getAdminID());
                imsg.info("User Deleted");
            }
            catch (Exception)
            {

                imsg.info("An error Occured");

            }
            loadAdmins();

        }
    }
}
