namespace KDMEDISP
{
    partial class frmNewManufacturers
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtmanufName = new MetroFramework.Controls.MetroTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 45);
            this.panel2.TabIndex = 35;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Manufacturer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(754, 280);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "label2";
            this.lblID.Visible = false;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(524, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 28);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(435, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtmanufName
            // 
            // 
            // 
            // 
            this.txtmanufName.CustomButton.Image = null;
            this.txtmanufName.CustomButton.Location = new System.Drawing.Point(341, 2);
            this.txtmanufName.CustomButton.Name = "";
            this.txtmanufName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtmanufName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmanufName.CustomButton.TabIndex = 1;
            this.txtmanufName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmanufName.CustomButton.UseSelectable = true;
            this.txtmanufName.CustomButton.Visible = false;
            this.txtmanufName.DisplayIcon = true;
            this.txtmanufName.Icon = global::KDMEDISP.Properties.Resources.Manufacturing_25px;
            this.txtmanufName.Lines = new string[0];
            this.txtmanufName.Location = new System.Drawing.Point(398, 206);
            this.txtmanufName.MaxLength = 32767;
            this.txtmanufName.Name = "txtmanufName";
            this.txtmanufName.PasswordChar = '\0';
            this.txtmanufName.PromptText = "Enter Manufacturer\'s Name";
            this.txtmanufName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmanufName.SelectedText = "";
            this.txtmanufName.SelectionLength = 0;
            this.txtmanufName.SelectionStart = 0;
            this.txtmanufName.ShortcutsEnabled = true;
            this.txtmanufName.Size = new System.Drawing.Size(369, 30);
            this.txtmanufName.TabIndex = 37;
            this.txtmanufName.UseSelectable = true;
            this.txtmanufName.WaterMark = "Enter Manufacturer\'s Name";
            this.txtmanufName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmanufName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtmanufName.Click += new System.EventHandler(this.txtmanufName_Click);
            // 
            // frmNewManufacturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtmanufName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewManufacturers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d";
            this.Load += new System.EventHandler(this.frmNewManufacturers_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroTextBox txtmanufName;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
    }
}