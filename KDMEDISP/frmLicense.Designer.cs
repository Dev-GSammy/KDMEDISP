namespace KDMEDISP
{
    partial class frmLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicense));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnProdExit = new System.Windows.Forms.Button();
            this.label66 = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.txtUniqueID = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtFullName = new MetroFramework.Controls.MetroTextBox();
            this.txtLicenseKey = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(15)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.btnProdExit);
            this.panel1.Controls.Add(this.label66);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 31);
            this.panel1.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(3, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(43, 31);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 30;
            this.pbxLogo.TabStop = false;
            // 
            // btnProdExit
            // 
            this.btnProdExit.ForeColor = System.Drawing.Color.Red;
            this.btnProdExit.Location = new System.Drawing.Point(492, 4);
            this.btnProdExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProdExit.Name = "btnProdExit";
            this.btnProdExit.Size = new System.Drawing.Size(20, 23);
            this.btnProdExit.TabIndex = 1;
            this.btnProdExit.Text = "X";
            this.btnProdExit.UseVisualStyleBackColor = true;
            this.btnProdExit.Click += new System.EventHandler(this.btnProdExit_Click);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label66.ForeColor = System.Drawing.Color.White;
            this.label66.Location = new System.Drawing.Point(64, 15);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(109, 16);
            this.label66.TabIndex = 31;
            this.label66.Text = "Activation Module";
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnActivate.FlatAppearance.BorderSize = 0;
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.Location = new System.Drawing.Point(311, 183);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(83, 33);
            this.btnActivate.TabIndex = 29;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // txtUniqueID
            // 
            this.txtUniqueID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            // 
            // 
            // 
            this.txtUniqueID.CustomButton.Image = null;
            this.txtUniqueID.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.txtUniqueID.CustomButton.Name = "";
            this.txtUniqueID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUniqueID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUniqueID.CustomButton.TabIndex = 1;
            this.txtUniqueID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUniqueID.CustomButton.UseSelectable = true;
            this.txtUniqueID.CustomButton.Visible = false;
            this.txtUniqueID.DisplayIcon = true;
            this.txtUniqueID.Enabled = false;
            this.txtUniqueID.Icon = global::KDMEDISP.Properties.Resources.HIPS_16px;
            this.txtUniqueID.Lines = new string[0];
            this.txtUniqueID.Location = new System.Drawing.Point(115, 42);
            this.txtUniqueID.MaxLength = 32767;
            this.txtUniqueID.Name = "txtUniqueID";
            this.txtUniqueID.PasswordChar = '\0';
            this.txtUniqueID.PromptText = "UniqueID";
            this.txtUniqueID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUniqueID.SelectedText = "";
            this.txtUniqueID.SelectionLength = 0;
            this.txtUniqueID.SelectionStart = 0;
            this.txtUniqueID.ShortcutsEnabled = true;
            this.txtUniqueID.Size = new System.Drawing.Size(279, 30);
            this.txtUniqueID.TabIndex = 28;
            this.txtUniqueID.UseSelectable = true;
            this.txtUniqueID.WaterMark = "UniqueID";
            this.txtUniqueID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUniqueID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DisplayIcon = true;
            this.txtEmail.Icon = global::KDMEDISP.Properties.Resources.emailpink;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(115, 150);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(279, 30);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFullName
            // 
            this.txtFullName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            // 
            // 
            // 
            this.txtFullName.CustomButton.Image = null;
            this.txtFullName.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.txtFullName.CustomButton.Name = "";
            this.txtFullName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFullName.CustomButton.TabIndex = 1;
            this.txtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFullName.CustomButton.UseSelectable = true;
            this.txtFullName.CustomButton.Visible = false;
            this.txtFullName.DisplayIcon = true;
            this.txtFullName.Icon = global::KDMEDISP.Properties.Resources._1;
            this.txtFullName.Lines = new string[0];
            this.txtFullName.Location = new System.Drawing.Point(115, 114);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PromptText = "Full Name";
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(279, 30);
            this.txtFullName.TabIndex = 28;
            this.txtFullName.UseSelectable = true;
            this.txtFullName.WaterMark = "Full Name";
            this.txtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLicenseKey
            // 
            this.txtLicenseKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            // 
            // 
            // 
            this.txtLicenseKey.CustomButton.Image = null;
            this.txtLicenseKey.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.txtLicenseKey.CustomButton.Name = "";
            this.txtLicenseKey.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtLicenseKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLicenseKey.CustomButton.TabIndex = 1;
            this.txtLicenseKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLicenseKey.CustomButton.UseSelectable = true;
            this.txtLicenseKey.CustomButton.Visible = false;
            this.txtLicenseKey.DisplayIcon = true;
            this.txtLicenseKey.Icon = global::KDMEDISP.Properties.Resources.Key_16px;
            this.txtLicenseKey.Lines = new string[0];
            this.txtLicenseKey.Location = new System.Drawing.Point(115, 78);
            this.txtLicenseKey.MaxLength = 32767;
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.PasswordChar = '\0';
            this.txtLicenseKey.PromptText = "License Key";
            this.txtLicenseKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLicenseKey.SelectedText = "";
            this.txtLicenseKey.SelectionLength = 0;
            this.txtLicenseKey.SelectionStart = 0;
            this.txtLicenseKey.ShortcutsEnabled = true;
            this.txtLicenseKey.Size = new System.Drawing.Size(279, 30);
            this.txtLicenseKey.TabIndex = 28;
            this.txtLicenseKey.UseSelectable = true;
            this.txtLicenseKey.WaterMark = "License Key";
            this.txtLicenseKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLicenseKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(15)))), ((int)(((byte)(41)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 3);
            this.panel2.TabIndex = 30;
            // 
            // frmLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 222);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.txtUniqueID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLicense";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLicense";
            this.Load += new System.EventHandler(this.frmLicense_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroTextBox txtLicenseKey;
        public MetroFramework.Controls.MetroTextBox txtFullName;
        public MetroFramework.Controls.MetroTextBox txtUniqueID;
        public MetroFramework.Controls.MetroTextBox txtEmail;
        public System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnProdExit;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Panel panel2;
    }
}