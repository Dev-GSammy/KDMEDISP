namespace KDMEDISP
{
    partial class frmProfile
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
            this.pnLoginMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnCreateAccount = new System.Windows.Forms.Panel();
            this.txtCreateConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtCreatePassword = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtCreateUsername = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditUsername = new System.Windows.Forms.Button();
            this.cboCashiers = new MetroFramework.Controls.MetroComboBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeletePro = new System.Windows.Forms.Button();
            this.pnLoginMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnCreateAccount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLoginMain
            // 
            this.pnLoginMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnLoginMain.Controls.Add(this.panel2);
            this.pnLoginMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLoginMain.Location = new System.Drawing.Point(0, 0);
            this.pnLoginMain.Name = "pnLoginMain";
            this.pnLoginMain.Size = new System.Drawing.Size(1028, 451);
            this.pnLoginMain.TabIndex = 1;
            this.pnLoginMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLoginMain_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pnCreateAccount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 427);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(979, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KDMEDISP.Properties.Resources.admin_png_8;
            this.pictureBox3.Location = new System.Drawing.Point(0, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnCreateAccount
            // 
            this.pnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnCreateAccount.Controls.Add(this.txtCreateConfirmPassword);
            this.pnCreateAccount.Controls.Add(this.txtCreatePassword);
            this.pnCreateAccount.Controls.Add(this.txtEmail);
            this.pnCreateAccount.Controls.Add(this.txtCreateUsername);
            this.pnCreateAccount.Controls.Add(this.label7);
            this.pnCreateAccount.Controls.Add(this.btnCreateAccount);
            this.pnCreateAccount.Location = new System.Drawing.Point(525, 112);
            this.pnCreateAccount.Name = "pnCreateAccount";
            this.pnCreateAccount.Size = new System.Drawing.Size(476, 220);
            this.pnCreateAccount.TabIndex = 9;
            // 
            // txtCreateConfirmPassword
            // 
            // 
            // 
            // 
            this.txtCreateConfirmPassword.CustomButton.Image = null;
            this.txtCreateConfirmPassword.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtCreateConfirmPassword.CustomButton.Name = "";
            this.txtCreateConfirmPassword.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtCreateConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreateConfirmPassword.CustomButton.TabIndex = 1;
            this.txtCreateConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreateConfirmPassword.CustomButton.UseSelectable = true;
            this.txtCreateConfirmPassword.CustomButton.Visible = false;
            this.txtCreateConfirmPassword.DisplayIcon = true;
            this.txtCreateConfirmPassword.Icon = global::KDMEDISP.Properties.Resources.icons8_Forgot_Password_20px;
            this.txtCreateConfirmPassword.Lines = new string[0];
            this.txtCreateConfirmPassword.Location = new System.Drawing.Point(21, 92);
            this.txtCreateConfirmPassword.MaxLength = 32767;
            this.txtCreateConfirmPassword.Name = "txtCreateConfirmPassword";
            this.txtCreateConfirmPassword.PasswordChar = '*';
            this.txtCreateConfirmPassword.PromptText = "Password";
            this.txtCreateConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreateConfirmPassword.SelectedText = "";
            this.txtCreateConfirmPassword.SelectionLength = 0;
            this.txtCreateConfirmPassword.SelectionStart = 0;
            this.txtCreateConfirmPassword.ShortcutsEnabled = true;
            this.txtCreateConfirmPassword.Size = new System.Drawing.Size(252, 31);
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
            this.txtCreatePassword.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtCreatePassword.CustomButton.Name = "";
            this.txtCreatePassword.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtCreatePassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreatePassword.CustomButton.TabIndex = 1;
            this.txtCreatePassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreatePassword.CustomButton.UseSelectable = true;
            this.txtCreatePassword.CustomButton.Visible = false;
            this.txtCreatePassword.DisplayIcon = true;
            this.txtCreatePassword.Icon = global::KDMEDISP.Properties.Resources.icons8_Forgot_Password_20px;
            this.txtCreatePassword.Lines = new string[0];
            this.txtCreatePassword.Location = new System.Drawing.Point(21, 58);
            this.txtCreatePassword.MaxLength = 32767;
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.PasswordChar = '*';
            this.txtCreatePassword.PromptText = "Password";
            this.txtCreatePassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreatePassword.SelectedText = "";
            this.txtCreatePassword.SelectionLength = 0;
            this.txtCreatePassword.SelectionStart = 0;
            this.txtCreatePassword.ShortcutsEnabled = true;
            this.txtCreatePassword.Size = new System.Drawing.Size(252, 31);
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
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DisplayIcon = true;
            this.txtEmail.Icon = global::KDMEDISP.Properties.Resources.emailadd;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(21, 126);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(252, 31);
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
            this.txtCreateUsername.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtCreateUsername.CustomButton.Name = "";
            this.txtCreateUsername.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtCreateUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreateUsername.CustomButton.TabIndex = 1;
            this.txtCreateUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreateUsername.CustomButton.UseSelectable = true;
            this.txtCreateUsername.CustomButton.Visible = false;
            this.txtCreateUsername.DisplayIcon = true;
            this.txtCreateUsername.Icon = global::KDMEDISP.Properties.Resources._1;
            this.txtCreateUsername.Lines = new string[0];
            this.txtCreateUsername.Location = new System.Drawing.Point(21, 24);
            this.txtCreateUsername.MaxLength = 32767;
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.PasswordChar = '\0';
            this.txtCreateUsername.PromptText = "Username";
            this.txtCreateUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreateUsername.SelectedText = "";
            this.txtCreateUsername.SelectionLength = 0;
            this.txtCreateUsername.SelectionStart = 0;
            this.txtCreateUsername.ShortcutsEnabled = true;
            this.txtCreateUsername.Size = new System.Drawing.Size(252, 31);
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
            this.label7.Location = new System.Drawing.Point(174, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Create New Cashiers";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(326, 92);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(102, 32);
            this.btnCreateAccount.TabIndex = 24;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manage Users";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(336, 58);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Id";
            this.lblID.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(450, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = " *Password Must Contain a Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(455, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "*Password length must be greater than 3 Characters";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btnEditUsername);
            this.panel1.Controls.Add(this.cboCashiers);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnDeletePro);
            this.panel1.Controls.Add(this.btnUpdateUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(85, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 220);
            this.panel1.TabIndex = 7;
            // 
            // btnEditUsername
            // 
            this.btnEditUsername.BackColor = System.Drawing.Color.Purple;
            this.btnEditUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUsername.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUsername.ForeColor = System.Drawing.Color.White;
            this.btnEditUsername.Location = new System.Drawing.Point(248, 92);
            this.btnEditUsername.Name = "btnEditUsername";
            this.btnEditUsername.Size = new System.Drawing.Size(38, 26);
            this.btnEditUsername.TabIndex = 13;
            this.btnEditUsername.Text = "Edit";
            this.btnEditUsername.UseVisualStyleBackColor = false;
            this.btnEditUsername.Click += new System.EventHandler(this.btnEditUsername_Click);
            // 
            // cboCashiers
            // 
            this.cboCashiers.FormattingEnabled = true;
            this.cboCashiers.ItemHeight = 23;
            this.cboCashiers.Location = new System.Drawing.Point(39, 54);
            this.cboCashiers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCashiers.Name = "cboCashiers";
            this.cboCashiers.Size = new System.Drawing.Size(251, 29);
            this.cboCashiers.TabIndex = 15;
            this.cboCashiers.UseSelectable = true;
            this.cboCashiers.SelectedIndexChanged += new System.EventHandler(this.cboCashiers_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = global::KDMEDISP.Properties.Resources.icons8_Forgot_Password_20px;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(39, 127);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(251, 31);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.DisplayIcon = true;
            this.txtUsername.Enabled = false;
            this.txtUsername.Icon = global::KDMEDISP.Properties.Resources._1;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(38, 90);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Enter   New Username";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(252, 31);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "Enter   New Username";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Purple;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(49, 174);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(129, 21);
            this.btnUpdateUser.TabIndex = 13;
            this.btnUpdateUser.Text = "Update Profile";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manage  Cashiers";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Purple;
            this.panel4.Location = new System.Drawing.Point(0, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1001, 10);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnDeletePro
            // 
            this.btnDeletePro.BackColor = System.Drawing.Color.Purple;
            this.btnDeletePro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePro.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePro.ForeColor = System.Drawing.Color.White;
            this.btnDeletePro.Location = new System.Drawing.Point(198, 174);
            this.btnDeletePro.Name = "btnDeletePro";
            this.btnDeletePro.Size = new System.Drawing.Size(129, 21);
            this.btnDeletePro.TabIndex = 13;
            this.btnDeletePro.Text = " Delete Profile";
            this.btnDeletePro.UseVisualStyleBackColor = false;
            this.btnDeletePro.Click += new System.EventHandler(this.btnDeletePro_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 451);
            this.Controls.Add(this.pnLoginMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfile";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.pnLoginMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnCreateAccount.ResumeLayout(false);
            this.pnCreateAccount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLoginMain;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnCreateAccount;
        private MetroFramework.Controls.MetroTextBox txtCreateConfirmPassword;
        private MetroFramework.Controls.MetroTextBox txtCreatePassword;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtCreateUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroComboBox cboCashiers;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnEditUsername;
        private System.Windows.Forms.Button btnDeletePro;
    }
}