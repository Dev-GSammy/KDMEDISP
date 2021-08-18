namespace KDMEDISP
{
    partial class frmEmailSettings
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProdExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnGenRec = new System.Windows.Forms.Panel();
            this.txtConfirmPass = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtserver = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnsaveConfig = new System.Windows.Forms.Button();
            this.bgwReceipt = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnGenRec.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnProdExit);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 40);
            this.panel2.TabIndex = 10;
            // 
            // btnProdExit
            // 
            this.btnProdExit.ForeColor = System.Drawing.Color.Red;
            this.btnProdExit.Location = new System.Drawing.Point(324, 4);
            this.btnProdExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProdExit.Name = "btnProdExit";
            this.btnProdExit.Size = new System.Drawing.Size(22, 23);
            this.btnProdExit.TabIndex = 0;
            this.btnProdExit.Text = "X";
            this.btnProdExit.UseVisualStyleBackColor = true;
            this.btnProdExit.Click += new System.EventHandler(this.btnProdExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KDMEDISP.Properties.Resources.email;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email Configuration";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 40);
            this.panel1.TabIndex = 20;
            // 
            // pnGenRec
            // 
            this.pnGenRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnGenRec.Controls.Add(this.txtConfirmPass);
            this.pnGenRec.Controls.Add(this.txtPassword);
            this.pnGenRec.Controls.Add(this.label1);
            this.pnGenRec.Controls.Add(this.txtserver);
            this.pnGenRec.Controls.Add(this.txtUsername);
            this.pnGenRec.Controls.Add(this.btnClear);
            this.pnGenRec.Controls.Add(this.btnsaveConfig);
            this.pnGenRec.Location = new System.Drawing.Point(0, 0);
            this.pnGenRec.Name = "pnGenRec";
            this.pnGenRec.Size = new System.Drawing.Size(349, 266);
            this.pnGenRec.TabIndex = 21;
            this.pnGenRec.Paint += new System.Windows.Forms.PaintEventHandler(this.pnGenRec_Paint);
            // 
            // txtConfirmPass
            // 
            // 
            // 
            // 
            this.txtConfirmPass.CustomButton.Image = null;
            this.txtConfirmPass.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtConfirmPass.CustomButton.Name = "";
            this.txtConfirmPass.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtConfirmPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmPass.CustomButton.TabIndex = 1;
            this.txtConfirmPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmPass.CustomButton.UseSelectable = true;
            this.txtConfirmPass.CustomButton.Visible = false;
            this.txtConfirmPass.DisplayIcon = true;
            this.txtConfirmPass.Icon = global::KDMEDISP.Properties.Resources.pw;
            this.txtConfirmPass.Lines = new string[0];
            this.txtConfirmPass.Location = new System.Drawing.Point(12, 180);
            this.txtConfirmPass.MaxLength = 32767;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.PromptText = "Confirm Password";
            this.txtConfirmPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.SelectionLength = 0;
            this.txtConfirmPass.SelectionStart = 0;
            this.txtConfirmPass.ShortcutsEnabled = true;
            this.txtConfirmPass.Size = new System.Drawing.Size(322, 31);
            this.txtConfirmPass.TabIndex = 8;
            this.txtConfirmPass.UseSelectable = true;
            this.txtConfirmPass.WaterMark = "Confirm Password";
            this.txtConfirmPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmPass.Click += new System.EventHandler(this.TxtCustPhone_Click);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = global::KDMEDISP.Properties.Resources.pw;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(12, 143);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(322, 31);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Click += new System.EventHandler(this.TxtCustPhone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Admin Email  to be used for sending out mails . Different from receipt mails";
            // 
            // txtserver
            // 
            // 
            // 
            // 
            this.txtserver.CustomButton.Image = null;
            this.txtserver.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtserver.CustomButton.Name = "";
            this.txtserver.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtserver.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtserver.CustomButton.TabIndex = 1;
            this.txtserver.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtserver.CustomButton.UseSelectable = true;
            this.txtserver.CustomButton.Visible = false;
            this.txtserver.DisplayIcon = true;
            this.txtserver.Icon = global::KDMEDISP.Properties.Resources.email;
            this.txtserver.Lines = new string[0];
            this.txtserver.Location = new System.Drawing.Point(12, 71);
            this.txtserver.MaxLength = 32767;
            this.txtserver.Name = "txtserver";
            this.txtserver.PasswordChar = '\0';
            this.txtserver.PromptText = "Server";
            this.txtserver.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtserver.SelectedText = "";
            this.txtserver.SelectionLength = 0;
            this.txtserver.SelectionStart = 0;
            this.txtserver.ShortcutsEnabled = true;
            this.txtserver.Size = new System.Drawing.Size(322, 31);
            this.txtserver.TabIndex = 8;
            this.txtserver.UseSelectable = true;
            this.txtserver.WaterMark = "Server";
            this.txtserver.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtserver.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.DisplayIcon = true;
            this.txtUsername.Icon = global::KDMEDISP.Properties.Resources._1;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(12, 106);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Username";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(322, 31);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "Username";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClear.Image = global::KDMEDISP.Properties.Resources.Ok_16px;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(165, 217);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 31);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnsaveConfig
            // 
            this.btnsaveConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsaveConfig.Image = global::KDMEDISP.Properties.Resources.Ok_16px;
            this.btnsaveConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaveConfig.Location = new System.Drawing.Point(269, 217);
            this.btnsaveConfig.Name = "btnsaveConfig";
            this.btnsaveConfig.Size = new System.Drawing.Size(68, 31);
            this.btnsaveConfig.TabIndex = 1;
            this.btnsaveConfig.Text = "Save";
            this.btnsaveConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsaveConfig.UseVisualStyleBackColor = true;
            this.btnsaveConfig.Click += new System.EventHandler(this.btnsaveConfig_Click);
            // 
            // frmEmailSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 266);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnGenRec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmailSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmailSettings";
            this.Load += new System.EventHandler(this.frmEmailSettings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnGenRec.ResumeLayout(false);
            this.pnGenRec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProdExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnGenRec;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtserver;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private System.Windows.Forms.Button btnsaveConfig;
        private System.ComponentModel.BackgroundWorker bgwReceipt;
        private MetroFramework.Controls.MetroTextBox txtConfirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
    }
}