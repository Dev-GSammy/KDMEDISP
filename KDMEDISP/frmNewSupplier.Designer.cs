namespace KDMEDISP
{
    partial class frmNewSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewSupplier));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtAdd = new MetroFramework.Controls.MetroTextBox();
            this.txtSupplierName = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 55);
            this.panel2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Supplier";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1005, 449);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 17);
            this.lblID.TabIndex = 41;
            this.lblID.Text = "label2";
            this.lblID.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(672, 449);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 34);
            this.btnUpdate.TabIndex = 38;
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
            this.btnSave.Location = new System.Drawing.Point(553, 449);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 34);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(560, 2);
            this.TxtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.DisplayIcon = true;
            this.TxtEmail.Icon = ((System.Drawing.Image)(resources.GetObject("TxtEmail.Icon")));
            this.TxtEmail.Lines = new string[] {
        " "};
            this.TxtEmail.Location = new System.Drawing.Point(396, 240);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PromptText = "Email";
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(596, 38);
            this.TxtEmail.TabIndex = 44;
            this.TxtEmail.Text = " ";
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMark = "Email";
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdd
            // 
            // 
            // 
            // 
            this.txtAdd.CustomButton.Image = null;
            this.txtAdd.CustomButton.Location = new System.Drawing.Point(523, 1);
            this.txtAdd.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdd.CustomButton.Name = "";
            this.txtAdd.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.txtAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdd.CustomButton.TabIndex = 1;
            this.txtAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdd.CustomButton.UseSelectable = true;
            this.txtAdd.CustomButton.Visible = false;
            this.txtAdd.DisplayIcon = true;
            this.txtAdd.Icon = ((System.Drawing.Image)(resources.GetObject("txtAdd.Icon")));
            this.txtAdd.Lines = new string[] {
        " "};
            this.txtAdd.Location = new System.Drawing.Point(396, 358);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdd.MaxLength = 32767;
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.PasswordChar = '\0';
            this.txtAdd.PromptText = "Address";
            this.txtAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdd.SelectedText = "";
            this.txtAdd.SelectionLength = 0;
            this.txtAdd.SelectionStart = 0;
            this.txtAdd.ShortcutsEnabled = true;
            this.txtAdd.Size = new System.Drawing.Size(593, 71);
            this.txtAdd.TabIndex = 45;
            this.txtAdd.Text = " ";
            this.txtAdd.UseSelectable = true;
            this.txtAdd.WaterMark = "Address";
            this.txtAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSupplierName
            // 
            // 
            // 
            // 
            this.txtSupplierName.CustomButton.Image = null;
            this.txtSupplierName.CustomButton.Location = new System.Drawing.Point(557, 2);
            this.txtSupplierName.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupplierName.CustomButton.Name = "";
            this.txtSupplierName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtSupplierName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierName.CustomButton.TabIndex = 1;
            this.txtSupplierName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierName.CustomButton.UseSelectable = true;
            this.txtSupplierName.CustomButton.Visible = false;
            this.txtSupplierName.DisplayIcon = true;
            this.txtSupplierName.Icon = ((System.Drawing.Image)(resources.GetObject("txtSupplierName.Icon")));
            this.txtSupplierName.Lines = new string[] {
        " "};
            this.txtSupplierName.Location = new System.Drawing.Point(399, 181);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupplierName.MaxLength = 32767;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.PromptText = "First Name";
            this.txtSupplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.SelectionLength = 0;
            this.txtSupplierName.SelectionStart = 0;
            this.txtSupplierName.ShortcutsEnabled = true;
            this.txtSupplierName.Size = new System.Drawing.Size(593, 38);
            this.txtSupplierName.TabIndex = 43;
            this.txtSupplierName.Text = " ";
            this.txtSupplierName.UseSelectable = true;
            this.txtSupplierName.WaterMark = "First Name";
            this.txtSupplierName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(560, 2);
            this.txtPhone.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.DisplayIcon = true;
            this.txtPhone.Icon = ((System.Drawing.Image)(resources.GetObject("txtPhone.Icon")));
            this.txtPhone.Lines = new string[] {
        " "};
            this.txtPhone.Location = new System.Drawing.Point(396, 297);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PromptText = "Phone";
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(596, 38);
            this.txtPhone.TabIndex = 46;
            this.txtPhone.Text = " ";
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMark = "Phone";
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(564, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Details of New Supplier";
            // 
            // frmNewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 569);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNewSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewSupplier";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
        public MetroFramework.Controls.MetroTextBox TxtEmail;
        public MetroFramework.Controls.MetroTextBox txtAdd;
        public MetroFramework.Controls.MetroTextBox txtSupplierName;
        public MetroFramework.Controls.MetroTextBox txtPhone;
        public System.Windows.Forms.Label label2;
    }
}