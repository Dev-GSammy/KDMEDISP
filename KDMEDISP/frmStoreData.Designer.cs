namespace KDMEDISP
{
    partial class frmStoreData
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
            this.pnGenRec = new System.Windows.Forms.Panel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtStoreTag = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStoreName = new MetroFramework.Controls.MetroTextBox();
            this.txtStoreAdd = new MetroFramework.Controls.MetroTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnsaveConfig = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProdExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgwReceipt = new System.ComponentModel.BackgroundWorker();
            this.pnGenRec.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnGenRec
            // 
            this.pnGenRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnGenRec.Controls.Add(this.txtEmail);
            this.pnGenRec.Controls.Add(this.txtStoreTag);
            this.pnGenRec.Controls.Add(this.txtPhone);
            this.pnGenRec.Controls.Add(this.label1);
            this.pnGenRec.Controls.Add(this.txtStoreName);
            this.pnGenRec.Controls.Add(this.txtStoreAdd);
            this.pnGenRec.Controls.Add(this.btnClear);
            this.pnGenRec.Controls.Add(this.btnsaveConfig);
            this.pnGenRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGenRec.Location = new System.Drawing.Point(0, 40);
            this.pnGenRec.Name = "pnGenRec";
            this.pnGenRec.Size = new System.Drawing.Size(373, 265);
            this.pnGenRec.TabIndex = 23;
            this.pnGenRec.Paint += new System.Windows.Forms.PaintEventHandler(this.pnGenRec_Paint);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DisplayIcon = true;
            this.txtEmail.Icon = global::KDMEDISP.Properties.Resources.email;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(12, 146);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(322, 31);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // txtStoreTag
            // 
            // 
            // 
            // 
            this.txtStoreTag.CustomButton.Image = null;
            this.txtStoreTag.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtStoreTag.CustomButton.Name = "";
            this.txtStoreTag.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtStoreTag.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStoreTag.CustomButton.TabIndex = 1;
            this.txtStoreTag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStoreTag.CustomButton.UseSelectable = true;
            this.txtStoreTag.CustomButton.Visible = false;
            this.txtStoreTag.DisplayIcon = true;
            this.txtStoreTag.Icon = global::KDMEDISP.Properties.Resources.pw;
            this.txtStoreTag.Lines = new string[0];
            this.txtStoreTag.Location = new System.Drawing.Point(12, 185);
            this.txtStoreTag.MaxLength = 32767;
            this.txtStoreTag.Name = "txtStoreTag";
            this.txtStoreTag.PasswordChar = '\0';
            this.txtStoreTag.PromptText = "Motto eg.  Health is Wealth";
            this.txtStoreTag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStoreTag.SelectedText = "";
            this.txtStoreTag.SelectionLength = 0;
            this.txtStoreTag.SelectionStart = 0;
            this.txtStoreTag.ShortcutsEnabled = true;
            this.txtStoreTag.Size = new System.Drawing.Size(322, 31);
            this.txtStoreTag.TabIndex = 3;
            this.txtStoreTag.UseSelectable = true;
            this.txtStoreTag.WaterMark = "Motto eg.  Health is Wealth";
            this.txtStoreTag.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStoreTag.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtStoreTag.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.DisplayIcon = true;
            this.txtPhone.Icon = global::KDMEDISP.Properties.Resources.OfficePhone_20px;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(11, 107);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PromptText = "Phone No";
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(322, 31);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMark = "Phone No";
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input the Details of your Organisation. These also appear on the receipt";
            // 
            // txtStoreName
            // 
            // 
            // 
            // 
            this.txtStoreName.CustomButton.Image = null;
            this.txtStoreName.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtStoreName.CustomButton.Name = "";
            this.txtStoreName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtStoreName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStoreName.CustomButton.TabIndex = 1;
            this.txtStoreName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStoreName.CustomButton.UseSelectable = true;
            this.txtStoreName.CustomButton.Visible = false;
            this.txtStoreName.DisplayIcon = true;
            this.txtStoreName.Icon = global::KDMEDISP.Properties.Resources.store;
            this.txtStoreName.Lines = new string[0];
            this.txtStoreName.Location = new System.Drawing.Point(12, 29);
            this.txtStoreName.MaxLength = 32767;
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.PasswordChar = '\0';
            this.txtStoreName.PromptText = "Name of Organisation";
            this.txtStoreName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStoreName.SelectedText = "";
            this.txtStoreName.SelectionLength = 0;
            this.txtStoreName.SelectionStart = 0;
            this.txtStoreName.ShortcutsEnabled = true;
            this.txtStoreName.Size = new System.Drawing.Size(322, 31);
            this.txtStoreName.TabIndex = 1;
            this.txtStoreName.UseSelectable = true;
            this.txtStoreName.WaterMark = "Name of Organisation";
            this.txtStoreName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStoreName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStoreAdd
            // 
            // 
            // 
            // 
            this.txtStoreAdd.CustomButton.Image = null;
            this.txtStoreAdd.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtStoreAdd.CustomButton.Name = "";
            this.txtStoreAdd.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtStoreAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStoreAdd.CustomButton.TabIndex = 1;
            this.txtStoreAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStoreAdd.CustomButton.UseSelectable = true;
            this.txtStoreAdd.CustomButton.Visible = false;
            this.txtStoreAdd.DisplayIcon = true;
            this.txtStoreAdd.Icon = global::KDMEDISP.Properties.Resources.Address_20px;
            this.txtStoreAdd.Lines = new string[0];
            this.txtStoreAdd.Location = new System.Drawing.Point(12, 68);
            this.txtStoreAdd.MaxLength = 32767;
            this.txtStoreAdd.Name = "txtStoreAdd";
            this.txtStoreAdd.PasswordChar = '\0';
            this.txtStoreAdd.PromptText = "Address";
            this.txtStoreAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStoreAdd.SelectedText = "";
            this.txtStoreAdd.SelectionLength = 0;
            this.txtStoreAdd.SelectionStart = 0;
            this.txtStoreAdd.ShortcutsEnabled = true;
            this.txtStoreAdd.Size = new System.Drawing.Size(322, 31);
            this.txtStoreAdd.TabIndex = 2;
            this.txtStoreAdd.UseSelectable = true;
            this.txtStoreAdd.WaterMark = "Address";
            this.txtStoreAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStoreAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClear.Image = global::KDMEDISP.Properties.Resources.Ok_16px;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(180, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 31);
            this.btnClear.TabIndex = 6;
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
            this.btnsaveConfig.Location = new System.Drawing.Point(282, 222);
            this.btnsaveConfig.Name = "btnsaveConfig";
            this.btnsaveConfig.Size = new System.Drawing.Size(68, 31);
            this.btnsaveConfig.TabIndex = 6;
            this.btnsaveConfig.Text = "Save";
            this.btnsaveConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsaveConfig.UseVisualStyleBackColor = true;
            this.btnsaveConfig.Click += new System.EventHandler(this.btnsaveConfig_Click);
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
            this.panel2.Size = new System.Drawing.Size(373, 40);
            this.panel2.TabIndex = 10;
            // 
            // btnProdExit
            // 
            this.btnProdExit.ForeColor = System.Drawing.Color.Red;
            this.btnProdExit.Location = new System.Drawing.Point(339, 8);
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
            this.pictureBox1.Image = global::KDMEDISP.Properties.Resources.store;
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
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = " Organisation Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 40);
            this.panel1.TabIndex = 22;
            // 
            // frmStoreData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 305);
            this.Controls.Add(this.pnGenRec);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStoreData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStoreData";
            this.Load += new System.EventHandler(this.frmStoreData_Load);
            this.pnGenRec.ResumeLayout(false);
            this.pnGenRec.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnGenRec;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroTextBox txtStoreName;
        private MetroFramework.Controls.MetroTextBox txtStoreAdd;
        private System.Windows.Forms.Button btnsaveConfig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProdExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker bgwReceipt;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtStoreTag;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private System.Windows.Forms.Button btnClear;
    }
}