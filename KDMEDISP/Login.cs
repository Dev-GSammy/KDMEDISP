using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KDMEDISP
{
    public partial class Login : Form
    {
        util imsg = new util();
        Db db = new Db();
        public Login()
        {
            InitializeComponent();
            //pnTop.BackColor= imsg.topColor();
            //pnLoginMain.BackColor = imsg.leftColor();
            lblLogin.Visible = false;
            db.CreateActivate();
            db.CreateCounter();
            if (db.checkActivateExist()==-1)
            {
                db.InsertNonActivate(); 
            }
            if (db.checkCountExist()==-1)
            {
                db.InsertTrialCount();
            }
          
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            txtUsername.Text = " ";
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.Text = " ";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToLower();
            string DispName = username.Substring(0, 1).ToString().ToUpper() + username.Substring(1, username.Length - 1).ToString();
            NewMethod(DispName);
            if (string.IsNullOrWhiteSpace(username))
            {
                imsg.info("Enter a Username to Login!");
                return;
            }
           

            Home home = new Home();


            string password = txtPassword.Text;
            Db admin = new Db();
            bool stats = admin.loginAdmin(username, password);
            if (stats)
            {
                if (admin.isSuper(username))
                {
                    clGlobalTrack.SuperAdmin = true;
                    Console.WriteLine(true);
                }
                else
                {
                    clGlobalTrack.SuperAdmin = false;
                }
                Hide();
                home.Show();
            }
            else
            {
                imsg.info("An Error Occured! Please Try Again");
            }
        }

        private static void NewMethod(string DispName)
        {
            clGlobalTrack.LoginUsername = DispName;
        }

        private void btnexit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblCreateAccount_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
           pnCreateAccount.Location = new Point(3, 40);
            pnMain.Location = new Point(500, 500);

            pnCreateAccount.BringToFront();
            lblCreateAccount.Visible = false;
            lblLogin.Visible = true;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pnCreateAccount_Leave(object sender, EventArgs e)
        {
        }

        private void pnLoginMain_MouseEnter(object sender, EventArgs e)
        {
            pnCreateAccount.Location = new Point(0, 500);
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCreateUsername.Text) && !string.IsNullOrWhiteSpace(txtCreatePassword.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (txtCreateConfirmPassword.Text == txtCreatePassword.Text)
                {
                    string username = txtCreateUsername.Text.ToLower();
                    string password = txtCreatePassword.Text;
                    string email = txtEmail.Text;
                    if (password.Length < 4)
                    {
                        imsg.info("Password Length must be greater than 3 Characters");
                        return;
                    }
                    if (!password.Any(char.IsDigit))
                    {
                        imsg.info("Password must contain a number");
                        return;
                    }


                    if (!email.Contains("@"))
                    {
                        imsg.info("Invalid Email address");
                        return;
                    }
                    int privilege = 0;
                    Db admin = new Db();
                    if (admin.InsertAdmin(username, password, email, privilege))

                    {
                        imsg.info("Success");

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



        private void txtCreateUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtCreateUsername.Text = "";

        }

        private void txtCreatePassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtCreatePassword.Text = "";
        }

        private void txtCreateConfirmPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtCreateConfirmPassword.Text = "";
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtEmail.Text = "";
        }

        private void pnLoginMain_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnexit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //imsg.getLogo(pbxLogo);
            Db dbase = new Db();
            dbase.createAdmins();      // create admin table
                                       // "check if a table exist
                                       // if it doesn't exist create
                                       //else
                                       // check it contains colums
                                       // if it doesn't contain  alter table and add/ delete columns

            // " check the user database columns to see if it exists";


        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Home main = new Home();
                string username = txtUsername.Text.ToLower();
                string DispName = username.Substring(0, 1).ToString().ToUpper() + username.Substring(1, username.Length - 1).ToString();


                string password = txtPassword.Text;
                Db admin = new Db();
                if (admin.loginAdmin(username, password))
                {
                    Hide();

                    main.Show();

                }
                else
                {
                    imsg.info("An Error Occured! Please Try Again");
                }

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCreateUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnProdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void pnCreateAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            pnMain.Location   = new Point(3, 40);
            pnCreateAccount.Location = new Point(500, 500);
            pnMain.BringToFront();
            lblCreateAccount.Visible = true;
            lblLogin.Visible = false;



        }

        private void lblLogin_MouseHover(object sender, EventArgs e)
        {
        
        }

        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.FromArgb(233, 30, 99);
            lblCreateAccount.ForeColor = Color.FromArgb(233, 30, 99);
        }

        private void lblCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.White;
            lblCreateAccount.ForeColor = Color.White;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                string username = txtUsername.Text.ToLower();

                if (string.IsNullOrWhiteSpace(username))
                {
                    imsg.info("Enter a Username to Login!");
                    return;
                }
                string DispName = username.Substring(0, 1).ToString().ToUpper() + username.Substring(1, username.Length - 1).ToString();
                Home home = new Home();
                NewMethod(DispName);

                string password = txtPassword.Text;
                Db admin = new Db();
                if (admin.loginAdmin(username, password))
                {
                    home.Show();
                    this.Hide();
                }
                else
                {
                    imsg.info("An Error Occured! Please Try Again");


                }
            }
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
