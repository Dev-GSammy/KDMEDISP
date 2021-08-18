namespace KDMEDISP
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnProdExit = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnLoginMain = new System.Windows.Forms.Panel();
            this.pnCreateAccount = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreateConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtCreatePassword = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtCreateUsername = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnLoginMain.SuspendLayout();
            this.pnCreateAccount.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.pnTop.Controls.Add(this.btnProdExit);
            this.pnTop.Controls.Add(this.pbxLogo);
            this.pnTop.Controls.Add(this.label3);
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(480, 42);
            this.pnTop.TabIndex = 0;
            this.pnTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnProdExit
            // 
            this.btnProdExit.ForeColor = System.Drawing.Color.Red;
            this.btnProdExit.Location = new System.Drawing.Point(447, 6);
            this.btnProdExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProdExit.Name = "btnProdExit";
            this.btnProdExit.Size = new System.Drawing.Size(29, 28);
            this.btnProdExit.TabIndex = 4;
            this.btnProdExit.Text = "X";
            this.btnProdExit.UseVisualStyleBackColor = true;
            this.btnProdExit.Click += new System.EventHandler(this.btnProdExit_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::KDMEDISP.Properties.Resources.kdmedlogosm;
            this.pbxLogo.Location = new System.Drawing.Point(4, 0);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(52, 42);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(317, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "KDMEDISP";
            // 
            // pnLoginMain
            // 
            this.pnLoginMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnLoginMain.Controls.Add(this.pnCreateAccount);
            this.pnLoginMain.Controls.Add(this.pnMain);
            this.pnLoginMain.Controls.Add(this.pnTop);
            this.pnLoginMain.Controls.Add(this.lblLogin);
            this.pnLoginMain.Controls.Add(this.lblCreateAccount);
            this.pnLoginMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLoginMain.Location = new System.Drawing.Point(0, 0);
            this.pnLoginMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnLoginMain.Name = "pnLoginMain";
            this.pnLoginMain.Size = new System.Drawing.Size(484, 348);
            this.pnLoginMain.TabIndex = 0;
            this.pnLoginMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnLoginMain.MouseLeave += new System.EventHandler(this.pnLoginMain_MouseLeave);
            // 
            // pnCreateAccount
            // 
            this.pnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnCreateAccount.Controls.Add(this.label4);
            this.pnCreateAccount.Controls.Add(this.label1);
            this.pnCreateAccount.Controls.Add(this.txtCreateConfirmPassword);
            this.pnCreateAccount.Controls.Add(this.txtCreatePassword);
            this.pnCreateAccount.Controls.Add(this.txtEmail);
            this.pnCreateAccount.Controls.Add(this.txtCreateUsername);
            this.pnCreateAccount.Controls.Add(this.label7);
            this.pnCreateAccount.Controls.Add(this.btnCreateAccount);
            this.pnCreateAccount.Location = new System.Drawing.Point(463, 49);
            this.pnCreateAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnCreateAccount.Name = "pnCreateAccount";
            this.pnCreateAccount.Size = new System.Drawing.Size(441, 271);
            this.pnCreateAccount.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = " *Password Must Contain a Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "*Password length must be greater than 3 Characters";
            // 
            // txtCreateConfirmPassword
            // 
            // 
            // 
            // 
            this.txtCreateConfirmPassword.CustomButton.Image = null;
            this.txtCreateConfirmPassword.CustomButton.Location = new System.Drawing.Point(276, 2);
            this.txtCreateConfirmPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreateConfirmPassword.CustomButton.Name = "";
            this.txtCreateConfirmPassword.CustomButton.Size = new System.Drawing.Size(44, 41);
            this.txtCreateConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreateConfirmPassword.CustomButton.TabIndex = 1;
            this.txtCreateConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreateConfirmPassword.CustomButton.UseSelectable = true;
            this.txtCreateConfirmPassword.CustomButton.Visible = false;
            this.txtCreateConfirmPassword.DisplayIcon = true;
            this.txtCreateConfirmPassword.Icon = global::KDMEDISP.Properties.Resources.icons8_Forgot_Password_20px;
            this.txtCreateConfirmPassword.Lines = new string[0];
            this.txtCreateConfirmPassword.Location = new System.Drawing.Point(28, 113);
            this.txtCreateConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreateConfirmPassword.MaxLength = 32767;
            this.txtCreateConfirmPassword.Name = "txtCreateConfirmPassword";
            this.txtCreateConfirmPassword.PasswordChar = '*';
            this.txtCreateConfirmPassword.PromptText = "Password";
            this.txtCreateConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreateConfirmPassword.SelectedText = "";
            this.txtCreateConfirmPassword.SelectionLength = 0;
            this.txtCreateConfirmPassword.SelectionStart = 0;
            this.txtCreateConfirmPassword.ShortcutsEnabled = true;
            this.txtCreateConfirmPassword.Size = new System.Drawing.Size(243, 38);
            this.txtCreateConfirmPassword.TabIndex = 22;
            this.txtCreateConfirmPassword.UseSelectable = true;
            this.txtCreateConfirmPassword.WaterMark = "Password";
            this.txtCreateConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCreateConfirmPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCreatePassword
            // 
            // 
            // 
            // 
            this.txtCreatePassword.CustomButton.Image = null;
            this.txtCreatePassword.CustomButton.Location = new System.Drawing.Point(276, 2);
            this.txtCreatePassword.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreatePassword.CustomButton.Name = "";
            this.txtCreatePassword.CustomButton.Size = new System.Drawing.Size(44, 41);
            this.txtCreatePassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreatePassword.CustomButton.TabIndex = 1;
            this.txtCreatePassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreatePassword.CustomButton.UseSelectable = true;
            this.txtCreatePassword.CustomButton.Visible = false;
            this.txtCreatePassword.DisplayIcon = true;
            this.txtCreatePassword.Icon = global::KDMEDISP.Properties.Resources.icons8_Forgot_Password_20px;
            this.txtCreatePassword.Lines = new string[0];
            this.txtCreatePassword.Location = new System.Drawing.Point(28, 71);
            this.txtCreatePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreatePassword.MaxLength = 32767;
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.PasswordChar = '*';
            this.txtCreatePassword.PromptText = "Password";
            this.txtCreatePassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreatePassword.SelectedText = "";
            this.txtCreatePassword.SelectionLength = 0;
            this.txtCreatePassword.SelectionStart = 0;
            this.txtCreatePassword.ShortcutsEnabled = true;
            this.txtCreatePassword.Size = new System.Drawing.Size(243, 38);
            this.txtCreatePassword.TabIndex = 21;
            this.txtCreatePassword.UseSelectable = true;
            this.txtCreatePassword.WaterMark = "Password";
            this.txtCreatePassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCreatePassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(276, 2);
            this.txtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(44, 41);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DisplayIcon = true;
            this.txtEmail.Icon = global::KDMEDISP.Properties.Resources.emailadd;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(28, 155);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(243, 38);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCreateUsername
            // 
            // 
            // 
            // 
            this.txtCreateUsername.CustomButton.Image = null;
            this.txtCreateUsername.CustomButton.Location = new System.Drawing.Point(276, 2);
            this.txtCreateUsername.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreateUsername.CustomButton.Name = "";
            this.txtCreateUsername.CustomButton.Size = new System.Drawing.Size(44, 41);
            this.txtCreateUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreateUsername.CustomButton.TabIndex = 1;
            this.txtCreateUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreateUsername.CustomButton.UseSelectable = true;
            this.txtCreateUsername.CustomButton.Visible = false;
            this.txtCreateUsername.DisplayIcon = true;
            this.txtCreateUsername.Icon = global::KDMEDISP.Properties.Resources._1;
            this.txtCreateUsername.Lines = new string[0];
            this.txtCreateUsername.Location = new System.Drawing.Point(28, 30);
            this.txtCreateUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreateUsername.MaxLength = 32767;
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.PasswordChar = '\0';
            this.txtCreateUsername.PromptText = "Username";
            this.txtCreateUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreateUsername.SelectedText = "";
            this.txtCreateUsername.SelectionLength = 0;
            this.txtCreateUsername.SelectionStart = 0;
            this.txtCreateUsername.ShortcutsEnabled = true;
            this.txtCreateUsername.Size = new System.Drawing.Size(243, 38);
            this.txtCreateUsername.TabIndex = 20;
            this.txtCreateUsername.UseSelectable = true;
            this.txtCreateUsername.WaterMark = "Username";
            this.txtCreateUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCreateUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "*Only 1 Super Admin can be created!";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(291, 96);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(136, 39);
            this.btnCreateAccount.TabIndex = 24;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnMain.Controls.Add(this.txtPassword);
            this.pnMain.Controls.Add(this.txtUsername);
            this.pnMain.Controls.Add(this.pictureBox1);
            this.pnMain.Controls.Add(this.btnLogin);
            this.pnMain.Location = new System.Drawing.Point(4, 43);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(435, 271);
            this.pnMain.TabIndex = 7;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(299, 2);
            this.txtPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = global::KDMEDISP.Properties.Resources.icons8_Forgot_Password_20px;
            this.txtPassword.Lines = new string[] {
        "#Kadosh90#"};
            this.txtPassword.Location = new System.Drawing.Point(52, 156);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(335, 38);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "#Kadosh90#";
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(300, 2);
            this.txtUsername.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.DisplayIcon = true;
            this.txtUsername.Icon = global::KDMEDISP.Properties.Resources._1;
            this.txtUsername.Lines = new string[] {
        "mectro"};
            this.txtUsername.Location = new System.Drawing.Point(51, 111);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Username";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(336, 38);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Text = "mectro";
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "Username";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KDMEDISP.Properties.Resources.admin_png_8;
            this.pictureBox1.Location = new System.Drawing.Point(159, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Purple;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(144, 214);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 26);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLogin.Font = new System.Drawing.Font("Papyrus", 8F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(4, 324);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 24);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.MouseEnter += new System.EventHandler(this.lblLogin_MouseEnter);
            this.lblLogin.MouseLeave += new System.EventHandler(this.lblCreateAccount_MouseLeave);
            this.lblLogin.MouseHover += new System.EventHandler(this.lblLogin_MouseHover);
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCreateAccount.Font = new System.Drawing.Font("Papyrus", 8F, System.Drawing.FontStyle.Bold);
            this.lblCreateAccount.ForeColor = System.Drawing.Color.White;
            this.lblCreateAccount.Location = new System.Drawing.Point(4, 324);
            this.lblCreateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(166, 24);
            this.lblCreateAccount.TabIndex = 1;
            this.lblCreateAccount.Text = "Create Super Admin";
            this.lblCreateAccount.Click += new System.EventHandler(this.lblCreateAccount_Click);
            this.lblCreateAccount.MouseEnter += new System.EventHandler(this.lblLogin_MouseEnter);
            this.lblCreateAccount.MouseLeave += new System.EventHandler(this.lblCreateAccount_MouseLeave);
            this.lblCreateAccount.MouseHover += new System.EventHandler(this.lblLogin_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 348);
            this.Controls.Add(this.pnLoginMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnLoginMain.ResumeLayout(false);
            this.pnLoginMain.PerformLayout();
            this.pnCreateAccount.ResumeLayout(false);
            this.pnCreateAccount.PerformLayout();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnLoginMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnProdExit;
        private System.Windows.Forms.Panel pnMain;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel pnCreateAccount;
        private MetroFramework.Controls.MetroTextBox txtCreateConfirmPassword;
        private MetroFramework.Controls.MetroTextBox txtCreatePassword;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtCreateUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}