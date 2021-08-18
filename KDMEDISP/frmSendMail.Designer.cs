namespace KDMEDISP
{
    partial class frmSendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendMail));
            this.pnGenRec = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProdExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgwReceipt = new System.ComponentModel.BackgroundWorker();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAttachement = new MetroFramework.Controls.MetroTextBox();
            this.txtEmailSubject = new MetroFramework.Controls.MetroTextBox();
            this.txtCustName = new MetroFramework.Controls.MetroTextBox();
            this.txtBcc = new MetroFramework.Controls.MetroTextBox();
            this.txtEmailAdd = new MetroFramework.Controls.MetroTextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnGenRec.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnGenRec
            // 
            this.pnGenRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnGenRec.Controls.Add(this.txtEmail);
            this.pnGenRec.Controls.Add(this.btnBrowse);
            this.pnGenRec.Controls.Add(this.txtAttachement);
            this.pnGenRec.Controls.Add(this.txtEmailSubject);
            this.pnGenRec.Controls.Add(this.txtCustName);
            this.pnGenRec.Controls.Add(this.txtBcc);
            this.pnGenRec.Controls.Add(this.txtEmailAdd);
            this.pnGenRec.Controls.Add(this.btnSendMail);
            this.pnGenRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGenRec.Location = new System.Drawing.Point(0, 40);
            this.pnGenRec.Name = "pnGenRec";
            this.pnGenRec.Size = new System.Drawing.Size(445, 332);
            this.pnGenRec.TabIndex = 23;
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
            this.panel2.Size = new System.Drawing.Size(445, 40);
            this.panel2.TabIndex = 10;
            // 
            // btnProdExit
            // 
            this.btnProdExit.ForeColor = System.Drawing.Color.Red;
            this.btnProdExit.Location = new System.Drawing.Point(413, 8);
            this.btnProdExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProdExit.Name = "btnProdExit";
            this.btnProdExit.Size = new System.Drawing.Size(22, 23);
            this.btnProdExit.TabIndex = 0;
            this.btnProdExit.Text = "X";
            this.btnProdExit.UseVisualStyleBackColor = true;
            this.btnProdExit.Click += new System.EventHandler(this.btnProdExit_Click);
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
            this.panel1.Size = new System.Drawing.Size(445, 40);
            this.panel1.TabIndex = 22;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(282, 2);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(117, 117);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DisplayIcon = true;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmail.Icon = ((System.Drawing.Image)(resources.GetObject("txtEmail.Icon")));
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(22, 126);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Message";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(402, 122);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Message";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(377, 257);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(47, 31);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtAttachement
            // 
            // 
            // 
            // 
            this.txtAttachement.CustomButton.Image = null;
            this.txtAttachement.CustomButton.Location = new System.Drawing.Point(326, 1);
            this.txtAttachement.CustomButton.Name = "";
            this.txtAttachement.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtAttachement.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAttachement.CustomButton.TabIndex = 1;
            this.txtAttachement.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAttachement.CustomButton.UseSelectable = true;
            this.txtAttachement.CustomButton.Visible = false;
            this.txtAttachement.DisplayIcon = true;
            this.txtAttachement.Enabled = false;
            this.txtAttachement.Icon = ((System.Drawing.Image)(resources.GetObject("txtAttachement.Icon")));
            this.txtAttachement.Lines = new string[0];
            this.txtAttachement.Location = new System.Drawing.Point(20, 257);
            this.txtAttachement.MaxLength = 32767;
            this.txtAttachement.Name = "txtAttachement";
            this.txtAttachement.PasswordChar = '\0';
            this.txtAttachement.PromptText = "Attachment";
            this.txtAttachement.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAttachement.SelectedText = "";
            this.txtAttachement.SelectionLength = 0;
            this.txtAttachement.SelectionStart = 0;
            this.txtAttachement.ShortcutsEnabled = true;
            this.txtAttachement.ShowClearButton = true;
            this.txtAttachement.Size = new System.Drawing.Size(356, 31);
            this.txtAttachement.TabIndex = 8;
            this.txtAttachement.UseSelectable = true;
            this.txtAttachement.WaterMark = "Attachment";
            this.txtAttachement.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAttachement.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmailSubject
            // 
            // 
            // 
            // 
            this.txtEmailSubject.CustomButton.Image = null;
            this.txtEmailSubject.CustomButton.Location = new System.Drawing.Point(372, 1);
            this.txtEmailSubject.CustomButton.Name = "";
            this.txtEmailSubject.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtEmailSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailSubject.CustomButton.TabIndex = 1;
            this.txtEmailSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailSubject.CustomButton.UseSelectable = true;
            this.txtEmailSubject.CustomButton.Visible = false;
            this.txtEmailSubject.DisplayIcon = true;
            this.txtEmailSubject.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmailSubject.Icon = ((System.Drawing.Image)(resources.GetObject("txtEmailSubject.Icon")));
            this.txtEmailSubject.Lines = new string[0];
            this.txtEmailSubject.Location = new System.Drawing.Point(22, 89);
            this.txtEmailSubject.MaxLength = 32767;
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.PasswordChar = '\0';
            this.txtEmailSubject.PromptText = "Subject";
            this.txtEmailSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailSubject.SelectedText = "";
            this.txtEmailSubject.SelectionLength = 0;
            this.txtEmailSubject.SelectionStart = 0;
            this.txtEmailSubject.ShortcutsEnabled = true;
            this.txtEmailSubject.Size = new System.Drawing.Size(402, 31);
            this.txtEmailSubject.TabIndex = 8;
            this.txtEmailSubject.UseSelectable = true;
            this.txtEmailSubject.WaterMark = "Subject";
            this.txtEmailSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCustName
            // 
            // 
            // 
            // 
            this.txtCustName.CustomButton.Image = null;
            this.txtCustName.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtCustName.CustomButton.Name = "";
            this.txtCustName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtCustName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustName.CustomButton.TabIndex = 1;
            this.txtCustName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustName.CustomButton.UseSelectable = true;
            this.txtCustName.CustomButton.Visible = false;
            this.txtCustName.DisplayIcon = true;
            this.txtCustName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCustName.Icon = ((System.Drawing.Image)(resources.GetObject("txtCustName.Icon")));
            this.txtCustName.Lines = new string[0];
            this.txtCustName.Location = new System.Drawing.Point(226, 6);
            this.txtCustName.MaxLength = 32767;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.PasswordChar = '\0';
            this.txtCustName.PromptText = "Customer\'s Name";
            this.txtCustName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustName.SelectedText = "";
            this.txtCustName.SelectionLength = 0;
            this.txtCustName.SelectionStart = 0;
            this.txtCustName.ShortcutsEnabled = true;
            this.txtCustName.Size = new System.Drawing.Size(198, 31);
            this.txtCustName.TabIndex = 8;
            this.txtCustName.UseSelectable = true;
            this.txtCustName.WaterMark = "Customer\'s Name";
            this.txtCustName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustName.Click += new System.EventHandler(this.txtEmailAdd_Click);
            // 
            // txtBcc
            // 
            // 
            // 
            // 
            this.txtBcc.CustomButton.Image = null;
            this.txtBcc.CustomButton.Location = new System.Drawing.Point(372, 1);
            this.txtBcc.CustomButton.Name = "";
            this.txtBcc.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtBcc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBcc.CustomButton.TabIndex = 1;
            this.txtBcc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBcc.CustomButton.UseSelectable = true;
            this.txtBcc.CustomButton.Visible = false;
            this.txtBcc.DisplayIcon = true;
            this.txtBcc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBcc.Icon = ((System.Drawing.Image)(resources.GetObject("txtBcc.Icon")));
            this.txtBcc.Lines = new string[0];
            this.txtBcc.Location = new System.Drawing.Point(22, 48);
            this.txtBcc.MaxLength = 32767;
            this.txtBcc.Name = "txtBcc";
            this.txtBcc.PasswordChar = '\0';
            this.txtBcc.PromptText = "BCC";
            this.txtBcc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBcc.SelectedText = "";
            this.txtBcc.SelectionLength = 0;
            this.txtBcc.SelectionStart = 0;
            this.txtBcc.ShortcutsEnabled = true;
            this.txtBcc.Size = new System.Drawing.Size(402, 31);
            this.txtBcc.TabIndex = 8;
            this.txtBcc.UseSelectable = true;
            this.txtBcc.WaterMark = "BCC";
            this.txtBcc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBcc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBcc.Click += new System.EventHandler(this.txtEmailAdd_Click);
            // 
            // txtEmailAdd
            // 
            // 
            // 
            // 
            this.txtEmailAdd.CustomButton.Image = null;
            this.txtEmailAdd.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtEmailAdd.CustomButton.Name = "";
            this.txtEmailAdd.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtEmailAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailAdd.CustomButton.TabIndex = 1;
            this.txtEmailAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailAdd.CustomButton.UseSelectable = true;
            this.txtEmailAdd.CustomButton.Visible = false;
            this.txtEmailAdd.DisplayIcon = true;
            this.txtEmailAdd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmailAdd.Icon = ((System.Drawing.Image)(resources.GetObject("txtEmailAdd.Icon")));
            this.txtEmailAdd.Lines = new string[0];
            this.txtEmailAdd.Location = new System.Drawing.Point(22, 6);
            this.txtEmailAdd.MaxLength = 32767;
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.PasswordChar = '\0';
            this.txtEmailAdd.PromptText = "Email Add";
            this.txtEmailAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailAdd.SelectedText = "";
            this.txtEmailAdd.SelectionLength = 0;
            this.txtEmailAdd.SelectionStart = 0;
            this.txtEmailAdd.ShortcutsEnabled = true;
            this.txtEmailAdd.Size = new System.Drawing.Size(198, 31);
            this.txtEmailAdd.TabIndex = 8;
            this.txtEmailAdd.UseSelectable = true;
            this.txtEmailAdd.WaterMark = "Email Add";
            this.txtEmailAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmailAdd.Click += new System.EventHandler(this.txtEmailAdd_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSendMail.Image = ((System.Drawing.Image)(resources.GetObject("btnSendMail.Image")));
            this.btnSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMail.Location = new System.Drawing.Point(349, 297);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 31);
            this.btnSendMail.TabIndex = 1;
            this.btnSendMail.Text = "Send";
            this.btnSendMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KDMEDISP.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 372);
            this.Controls.Add(this.pnGenRec);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSendMail";
            this.Load += new System.EventHandler(this.frmSendMail_Load);
            this.pnGenRec.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnGenRec;
        private System.Windows.Forms.Button btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtAttachement;
        private MetroFramework.Controls.MetroTextBox txtEmailAdd;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProdExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker bgwReceipt;
        private MetroFramework.Controls.MetroTextBox txtEmailSubject;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtCustName;
        private MetroFramework.Controls.MetroTextBox txtBcc;
    }
}