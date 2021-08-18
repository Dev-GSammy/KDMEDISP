namespace KDMEDISP
{
    partial class frmFillPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFillPrescription));
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtGuestPatientPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtGuestPatientName = new MetroFramework.Controls.MetroTextBox();
            this.txtGuestPatientAddres = new MetroFramework.Controls.MetroTextBox();
            this.txtGuestAdd = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(314, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Patient Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "New Dispense";
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(474, 406);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(83, 29);
            this.btnProceed.TabIndex = 35;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(15)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1054, 35);
            this.panel2.TabIndex = 36;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(314, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Patient Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(403, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "GUEST DISPENSE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KDMEDISP.Properties.Resources.Sell_32px;
            this.pictureBox2.Location = new System.Drawing.Point(346, 74);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // txtGuestPatientPhone
            // 
            // 
            // 
            // 
            this.txtGuestPatientPhone.CustomButton.Image = null;
            this.txtGuestPatientPhone.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.txtGuestPatientPhone.CustomButton.Name = "";
            this.txtGuestPatientPhone.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtGuestPatientPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuestPatientPhone.CustomButton.TabIndex = 1;
            this.txtGuestPatientPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuestPatientPhone.CustomButton.UseSelectable = true;
            this.txtGuestPatientPhone.CustomButton.Visible = false;
            this.txtGuestPatientPhone.DisplayIcon = true;
            this.txtGuestPatientPhone.Icon = ((System.Drawing.Image)(resources.GetObject("txtGuestPatientPhone.Icon")));
            this.txtGuestPatientPhone.Lines = new string[] {
        " "};
            this.txtGuestPatientPhone.Location = new System.Drawing.Point(421, 269);
            this.txtGuestPatientPhone.MaxLength = 32767;
            this.txtGuestPatientPhone.Name = "txtGuestPatientPhone";
            this.txtGuestPatientPhone.PasswordChar = '\0';
            this.txtGuestPatientPhone.PromptText = "Phone";
            this.txtGuestPatientPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuestPatientPhone.SelectedText = "";
            this.txtGuestPatientPhone.SelectionLength = 0;
            this.txtGuestPatientPhone.SelectionStart = 0;
            this.txtGuestPatientPhone.ShortcutsEnabled = true;
            this.txtGuestPatientPhone.Size = new System.Drawing.Size(291, 31);
            this.txtGuestPatientPhone.TabIndex = 51;
            this.txtGuestPatientPhone.Text = " ";
            this.txtGuestPatientPhone.UseSelectable = true;
            this.txtGuestPatientPhone.WaterMark = "Phone";
            this.txtGuestPatientPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuestPatientPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGuestPatientName
            // 
            // 
            // 
            // 
            this.txtGuestPatientName.CustomButton.Image = null;
            this.txtGuestPatientName.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.txtGuestPatientName.CustomButton.Name = "";
            this.txtGuestPatientName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtGuestPatientName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuestPatientName.CustomButton.TabIndex = 1;
            this.txtGuestPatientName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuestPatientName.CustomButton.UseSelectable = true;
            this.txtGuestPatientName.CustomButton.Visible = false;
            this.txtGuestPatientName.DisplayIcon = true;
            this.txtGuestPatientName.Icon = ((System.Drawing.Image)(resources.GetObject("txtGuestPatientName.Icon")));
            this.txtGuestPatientName.Lines = new string[] {
        " "};
            this.txtGuestPatientName.Location = new System.Drawing.Point(421, 224);
            this.txtGuestPatientName.MaxLength = 32767;
            this.txtGuestPatientName.Name = "txtGuestPatientName";
            this.txtGuestPatientName.PasswordChar = '\0';
            this.txtGuestPatientName.PromptText = "Name";
            this.txtGuestPatientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuestPatientName.SelectedText = "";
            this.txtGuestPatientName.SelectionLength = 0;
            this.txtGuestPatientName.SelectionStart = 0;
            this.txtGuestPatientName.ShortcutsEnabled = true;
            this.txtGuestPatientName.Size = new System.Drawing.Size(291, 31);
            this.txtGuestPatientName.TabIndex = 50;
            this.txtGuestPatientName.Text = " ";
            this.txtGuestPatientName.UseSelectable = true;
            this.txtGuestPatientName.WaterMark = "Name";
            this.txtGuestPatientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuestPatientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGuestPatientAddres
            // 
            // 
            // 
            // 
            this.txtGuestPatientAddres.CustomButton.Image = null;
            this.txtGuestPatientAddres.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.txtGuestPatientAddres.CustomButton.Name = "";
            this.txtGuestPatientAddres.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtGuestPatientAddres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuestPatientAddres.CustomButton.TabIndex = 1;
            this.txtGuestPatientAddres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuestPatientAddres.CustomButton.UseSelectable = true;
            this.txtGuestPatientAddres.CustomButton.Visible = false;
            this.txtGuestPatientAddres.DisplayIcon = true;
            this.txtGuestPatientAddres.Icon = global::KDMEDISP.Properties.Resources.Address_20px;
            this.txtGuestPatientAddres.Lines = new string[] {
        " "};
            this.txtGuestPatientAddres.Location = new System.Drawing.Point(421, 324);
            this.txtGuestPatientAddres.MaxLength = 32767;
            this.txtGuestPatientAddres.Name = "txtGuestPatientAddres";
            this.txtGuestPatientAddres.PasswordChar = '\0';
            this.txtGuestPatientAddres.PromptText = "Address";
            this.txtGuestPatientAddres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuestPatientAddres.SelectedText = "";
            this.txtGuestPatientAddres.SelectionLength = 0;
            this.txtGuestPatientAddres.SelectionStart = 0;
            this.txtGuestPatientAddres.ShortcutsEnabled = true;
            this.txtGuestPatientAddres.Size = new System.Drawing.Size(291, 31);
            this.txtGuestPatientAddres.TabIndex = 51;
            this.txtGuestPatientAddres.Text = " ";
            this.txtGuestPatientAddres.UseSelectable = true;
            this.txtGuestPatientAddres.WaterMark = "Address";
            this.txtGuestPatientAddres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuestPatientAddres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGuestAdd
            // 
            this.txtGuestAdd.AutoSize = true;
            this.txtGuestAdd.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtGuestAdd.ForeColor = System.Drawing.Color.Black;
            this.txtGuestAdd.Location = new System.Drawing.Point(314, 324);
            this.txtGuestAdd.Name = "txtGuestAdd";
            this.txtGuestAdd.Size = new System.Drawing.Size(56, 17);
            this.txtGuestAdd.TabIndex = 49;
            this.txtGuestAdd.Text = "Address";
            // 
            // frmFillPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 529);
            this.Controls.Add(this.txtGuestPatientAddres);
            this.Controls.Add(this.txtGuestPatientPhone);
            this.Controls.Add(this.txtGuestPatientName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtGuestAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFillPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFillPrescription";
            this.Load += new System.EventHandler(this.frmFillPrescription_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public MetroFramework.Controls.MetroTextBox txtGuestPatientPhone;
        public MetroFramework.Controls.MetroTextBox txtGuestPatientName;
        public MetroFramework.Controls.MetroTextBox txtGuestPatientAddres;
        private System.Windows.Forms.Label txtGuestAdd;
    }
}