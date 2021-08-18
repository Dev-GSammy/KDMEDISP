namespace KDMEDISP
{
    partial class frmCheckOut
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProdExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnGenRec = new System.Windows.Forms.Panel();
            this.TxtCustPhone = new MetroFramework.Controls.MetroTextBox();
            this.pbxAutoOpen = new System.Windows.Forms.PictureBox();
            this.pbxDefaultFolder = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDefPrinter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtCustName = new MetroFramework.Controls.MetroTextBox();
            this.btnGenReceipt = new System.Windows.Forms.Button();
            this.bgwReceipt = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnGenRec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAutoOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDefaultFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 40);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.btnProdExit);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 40);
            this.panel2.TabIndex = 10;
            // 
            // btnProdExit
            // 
            this.btnProdExit.ForeColor = System.Drawing.Color.Red;
            this.btnProdExit.Location = new System.Drawing.Point(309, 7);
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
            this.pictureBox1.Image = global::KDMEDISP.Properties.Resources.Purchase_Order_48px;
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
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Generate  Receipt";
            // 
            // pnGenRec
            // 
            this.pnGenRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnGenRec.Controls.Add(this.TxtCustPhone);
            this.pnGenRec.Controls.Add(this.pbxAutoOpen);
            this.pnGenRec.Controls.Add(this.pbxDefaultFolder);
            this.pnGenRec.Controls.Add(this.label3);
            this.pnGenRec.Controls.Add(this.lblDefPrinter);
            this.pnGenRec.Controls.Add(this.label1);
            this.pnGenRec.Controls.Add(this.label2);
            this.pnGenRec.Controls.Add(this.txtEmail);
            this.pnGenRec.Controls.Add(this.txtCustName);
            this.pnGenRec.Controls.Add(this.btnGenReceipt);
            this.pnGenRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGenRec.Location = new System.Drawing.Point(0, 40);
            this.pnGenRec.Name = "pnGenRec";
            this.pnGenRec.Size = new System.Drawing.Size(334, 224);
            this.pnGenRec.TabIndex = 19;
            this.pnGenRec.Paint += new System.Windows.Forms.PaintEventHandler(this.pnGenRec_Paint);
            // 
            // TxtCustPhone
            // 
            // 
            // 
            // 
            this.TxtCustPhone.CustomButton.Image = null;
            this.TxtCustPhone.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.TxtCustPhone.CustomButton.Name = "";
            this.TxtCustPhone.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.TxtCustPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCustPhone.CustomButton.TabIndex = 1;
            this.TxtCustPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCustPhone.CustomButton.UseSelectable = true;
            this.TxtCustPhone.CustomButton.Visible = false;
            this.TxtCustPhone.DisplayIcon = true;
            this.TxtCustPhone.Enabled = false;
            this.TxtCustPhone.Icon = global::KDMEDISP.Properties.Resources.ph;
            this.TxtCustPhone.Lines = new string[0];
            this.TxtCustPhone.Location = new System.Drawing.Point(12, 59);
            this.TxtCustPhone.MaxLength = 32767;
            this.TxtCustPhone.Name = "TxtCustPhone";
            this.TxtCustPhone.PasswordChar = '\0';
            this.TxtCustPhone.PromptText = "Tel";
            this.TxtCustPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCustPhone.SelectedText = "";
            this.TxtCustPhone.SelectionLength = 0;
            this.TxtCustPhone.SelectionStart = 0;
            this.TxtCustPhone.ShortcutsEnabled = true;
            this.TxtCustPhone.Size = new System.Drawing.Size(310, 31);
            this.TxtCustPhone.TabIndex = 8;
            this.TxtCustPhone.UseSelectable = true;
            this.TxtCustPhone.WaterMark = "Tel";
            this.TxtCustPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCustPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCustPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCustPhone_KeyPress);
            // 
            // pbxAutoOpen
            // 
            this.pbxAutoOpen.Image = global::KDMEDISP.Properties.Resources.Toggle_Off_20px;
            this.pbxAutoOpen.Location = new System.Drawing.Point(246, 150);
            this.pbxAutoOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxAutoOpen.Name = "pbxAutoOpen";
            this.pbxAutoOpen.Size = new System.Drawing.Size(76, 27);
            this.pbxAutoOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAutoOpen.TabIndex = 14;
            this.pbxAutoOpen.TabStop = false;
            this.pbxAutoOpen.Click += new System.EventHandler(this.pbxAutoOpen_Click);
            // 
            // pbxDefaultFolder
            // 
            this.pbxDefaultFolder.Image = global::KDMEDISP.Properties.Resources.Toggle_Off_20px;
            this.pbxDefaultFolder.Location = new System.Drawing.Point(126, 150);
            this.pbxDefaultFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxDefaultFolder.Name = "pbxDefaultFolder";
            this.pbxDefaultFolder.Size = new System.Drawing.Size(76, 27);
            this.pbxDefaultFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDefaultFolder.TabIndex = 14;
            this.pbxDefaultFolder.TabStop = false;
            this.pbxDefaultFolder.Click += new System.EventHandler(this.pbxDefaultFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(245, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Auto Open ";
            this.label3.Click += new System.EventHandler(this.pbxDefault_Click);
            // 
            // lblDefPrinter
            // 
            this.lblDefPrinter.AutoSize = true;
            this.lblDefPrinter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDefPrinter.ForeColor = System.Drawing.Color.White;
            this.lblDefPrinter.Location = new System.Drawing.Point(103, 3);
            this.lblDefPrinter.Name = "lblDefPrinter";
            this.lblDefPrinter.Size = new System.Drawing.Size(16, 13);
            this.lblDefPrinter.TabIndex = 10;
            this.lblDefPrinter.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Default Folder";
            this.label1.Click += new System.EventHandler(this.pbxDefault_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = " Default Printer:";
            this.label2.Click += new System.EventHandler(this.pbxDefault_Click);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DisplayIcon = true;
            this.txtEmail.Enabled = false;
            this.txtEmail.Icon = global::KDMEDISP.Properties.Resources.email;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(12, 96);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(310, 31);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCustName
            // 
            // 
            // 
            // 
            this.txtCustName.CustomButton.Image = null;
            this.txtCustName.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txtCustName.CustomButton.Name = "";
            this.txtCustName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtCustName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustName.CustomButton.TabIndex = 1;
            this.txtCustName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustName.CustomButton.UseSelectable = true;
            this.txtCustName.CustomButton.Visible = false;
            this.txtCustName.DisplayIcon = true;
            this.txtCustName.Enabled = false;
            this.txtCustName.Icon = global::KDMEDISP.Properties.Resources._1;
            this.txtCustName.Lines = new string[0];
            this.txtCustName.Location = new System.Drawing.Point(12, 22);
            this.txtCustName.MaxLength = 32767;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.PasswordChar = '\0';
            this.txtCustName.PromptText = "Customer \'s  Name";
            this.txtCustName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustName.SelectedText = "";
            this.txtCustName.SelectionLength = 0;
            this.txtCustName.SelectionStart = 0;
            this.txtCustName.ShortcutsEnabled = true;
            this.txtCustName.Size = new System.Drawing.Size(310, 31);
            this.txtCustName.TabIndex = 8;
            this.txtCustName.UseSelectable = true;
            this.txtCustName.WaterMark = "Customer \'s  Name";
            this.txtCustName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGenReceipt
            // 
            this.btnGenReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenReceipt.Image = global::KDMEDISP.Properties.Resources.posrec;
            this.btnGenReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenReceipt.Location = new System.Drawing.Point(127, 183);
            this.btnGenReceipt.Name = "btnGenReceipt";
            this.btnGenReceipt.Size = new System.Drawing.Size(195, 35);
            this.btnGenReceipt.TabIndex = 1;
            this.btnGenReceipt.Text = "Generate  and Print Receipt";
            this.btnGenReceipt.UseVisualStyleBackColor = true;
            this.btnGenReceipt.Click += new System.EventHandler(this.btnGenReceipt_Click);
            // 
            // bgwReceipt
            // 
            this.bgwReceipt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwReceipt_DoWork);
            this.bgwReceipt.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwReceipt_RunWorkerCompleted);
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 264);
            this.Controls.Add(this.pnGenRec);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "frmCheckOut";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnGenRec.ResumeLayout(false);
            this.pnGenRec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAutoOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDefaultFolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProdExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnGenRec;
        private System.Windows.Forms.Button btnGenReceipt;
        private System.Windows.Forms.Label lblDefPrinter;
        private System.ComponentModel.BackgroundWorker bgwReceipt;
        private System.Windows.Forms.PictureBox pbxDefaultFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxAutoOpen;
        private System.Windows.Forms.Label label3;
        public MetroFramework.Controls.MetroTextBox TxtCustPhone;
        public MetroFramework.Controls.MetroTextBox txtCustName;
        public MetroFramework.Controls.MetroTextBox txtEmail;
    }
}