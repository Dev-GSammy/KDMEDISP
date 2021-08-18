namespace KDMEDISP
{
    partial class frmDoctor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctor));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtOtherName = new MetroFramework.Controls.MetroTextBox();
            this.cbxTitle = new System.Windows.Forms.ComboBox();
            this.dtpDob = new MetroFramework.Controls.MetroDateTime();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbxNewProdImg = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtStaffID = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtAdd = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNewProdImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(15)))), ((int)(((byte)(41)))));
            this.panel4.Location = new System.Drawing.Point(0, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1003, 10);
            this.panel4.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(38, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "DOCTOR / PRESCRIBER DETAILS";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(379, 321);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 29);
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
            this.btnSave.Location = new System.Drawing.Point(250, 321);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 29);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(344, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Date of Birth";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(755, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Prescriber\'s Photo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(192, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Sex";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(57, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Title";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cboSex
            // 
            this.cboSex.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboSex.Location = new System.Drawing.Point(226, 54);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(84, 27);
            this.cboSex.TabIndex = 32;
            this.cboSex.SelectedIndexChanged += new System.EventHandler(this.cboSex_SelectedIndexChanged);
            // 
            // txtOtherName
            // 
            // 
            // 
            // 
            this.txtOtherName.CustomButton.Image = null;
            this.txtOtherName.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.txtOtherName.CustomButton.Name = "";
            this.txtOtherName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtOtherName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOtherName.CustomButton.TabIndex = 1;
            this.txtOtherName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOtherName.CustomButton.UseSelectable = true;
            this.txtOtherName.CustomButton.Visible = false;
            this.txtOtherName.DisplayIcon = true;
            this.txtOtherName.Lines = new string[] {
        "Raro"};
            this.txtOtherName.Location = new System.Drawing.Point(347, 88);
            this.txtOtherName.MaxLength = 32767;
            this.txtOtherName.Name = "txtOtherName";
            this.txtOtherName.PasswordChar = '\0';
            this.txtOtherName.PromptText = "Other Name";
            this.txtOtherName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOtherName.SelectedText = "";
            this.txtOtherName.SelectionLength = 0;
            this.txtOtherName.SelectionStart = 0;
            this.txtOtherName.ShortcutsEnabled = true;
            this.txtOtherName.Size = new System.Drawing.Size(314, 31);
            this.txtOtherName.TabIndex = 30;
            this.txtOtherName.Text = "Raro";
            this.txtOtherName.UseSelectable = true;
            this.txtOtherName.WaterMark = "Other Name";
            this.txtOtherName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOtherName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOtherName.Click += new System.EventHandler(this.txtOtherName_Click);
            // 
            // cbxTitle
            // 
            this.cbxTitle.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cbxTitle.FormattingEnabled = true;
            this.cbxTitle.Items.AddRange(new object[] {
            "Pharm",
            "Nurse",
            "Dr."});
            this.cbxTitle.Location = new System.Drawing.Point(97, 54);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(89, 27);
            this.cbxTitle.TabIndex = 33;
            this.cbxTitle.SelectedIndexChanged += new System.EventHandler(this.cbxTitle_SelectedIndexChanged);
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(431, 54);
            this.dtpDob.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(230, 29);
            this.dtpDob.TabIndex = 31;
            this.dtpDob.ValueChanged += new System.EventHandler(this.dtpDob_ValueChanged);
            // 
            // txtLastName
            // 
            // 
            // 
            // 
            this.txtLastName.CustomButton.Image = null;
            this.txtLastName.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.txtLastName.CustomButton.Name = "";
            this.txtLastName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.CustomButton.TabIndex = 1;
            this.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName.CustomButton.UseSelectable = true;
            this.txtLastName.CustomButton.Visible = false;
            this.txtLastName.DisplayIcon = true;
            this.txtLastName.Lines = new string[] {
        "Isaiah"};
            this.txtLastName.Location = new System.Drawing.Point(21, 140);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PromptText = "Last Name";
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(291, 31);
            this.txtLastName.TabIndex = 31;
            this.txtLastName.Text = "Isaiah";
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMark = "Last Name";
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastName.Click += new System.EventHandler(this.txtLastName_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pbxNewProdImg
            // 
            this.pbxNewProdImg.Image = ((System.Drawing.Image)(resources.GetObject("pbxNewProdImg.Image")));
            this.pbxNewProdImg.Location = new System.Drawing.Point(758, 116);
            this.pbxNewProdImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxNewProdImg.Name = "pbxNewProdImg";
            this.pbxNewProdImg.Size = new System.Drawing.Size(101, 85);
            this.pbxNewProdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNewProdImg.TabIndex = 42;
            this.pbxNewProdImg.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadImage.Image")));
            this.btnUploadImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadImage.Location = new System.Drawing.Point(732, 222);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(180, 29);
            this.btnUploadImage.TabIndex = 36;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.DisplayIcon = true;
            this.TxtEmail.Icon = ((System.Drawing.Image)(resources.GetObject("TxtEmail.Icon")));
            this.TxtEmail.Lines = new string[] {
        "mectro@gmail.com"};
            this.TxtEmail.Location = new System.Drawing.Point(349, 140);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PromptText = "Email";
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(312, 31);
            this.TxtEmail.TabIndex = 32;
            this.TxtEmail.Text = "mectro@gmail.com";
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMark = "Email";
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtEmail.Click += new System.EventHandler(this.TxtEmail_Click);
            // 
            // txtStaffID
            // 
            // 
            // 
            // 
            this.txtStaffID.CustomButton.Image = null;
            this.txtStaffID.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.txtStaffID.CustomButton.Name = "";
            this.txtStaffID.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtStaffID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffID.CustomButton.TabIndex = 1;
            this.txtStaffID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffID.CustomButton.UseSelectable = true;
            this.txtStaffID.CustomButton.Visible = false;
            this.txtStaffID.DisplayIcon = true;
            this.txtStaffID.Icon = ((System.Drawing.Image)(resources.GetObject("txtStaffID.Icon")));
            this.txtStaffID.Lines = new string[] {
        "OD1584"};
            this.txtStaffID.Location = new System.Drawing.Point(347, 192);
            this.txtStaffID.MaxLength = 32767;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.PasswordChar = '\0';
            this.txtStaffID.PromptText = "Staff ID";
            this.txtStaffID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffID.SelectedText = "";
            this.txtStaffID.SelectionLength = 0;
            this.txtStaffID.SelectionStart = 0;
            this.txtStaffID.ShortcutsEnabled = true;
            this.txtStaffID.Size = new System.Drawing.Size(314, 31);
            this.txtStaffID.TabIndex = 34;
            this.txtStaffID.Text = "OD1584";
            this.txtStaffID.UseSelectable = true;
            this.txtStaffID.WaterMark = "Staff ID";
            this.txtStaffID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtStaffID.Click += new System.EventHandler(this.txtStaffID_Click);
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.DisplayIcon = true;
            this.txtPhone.Icon = ((System.Drawing.Image)(resources.GetObject("txtPhone.Icon")));
            this.txtPhone.Lines = new string[] {
        "08163930093"};
            this.txtPhone.Location = new System.Drawing.Point(21, 192);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PromptText = "Phone";
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(291, 31);
            this.txtPhone.TabIndex = 33;
            this.txtPhone.Text = "08163930093";
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMark = "Phone";
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.Click += new System.EventHandler(this.txtPhone_Click);
            // 
            // txtAdd
            // 
            // 
            // 
            // 
            this.txtAdd.CustomButton.Image = null;
            this.txtAdd.CustomButton.Location = new System.Drawing.Point(584, 2);
            this.txtAdd.CustomButton.Name = "";
            this.txtAdd.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.txtAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdd.CustomButton.TabIndex = 1;
            this.txtAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdd.CustomButton.UseSelectable = true;
            this.txtAdd.CustomButton.Visible = false;
            this.txtAdd.DisplayIcon = true;
            this.txtAdd.Icon = ((System.Drawing.Image)(resources.GetObject("txtAdd.Icon")));
            this.txtAdd.Lines = new string[] {
        "28 Isikan Close "};
            this.txtAdd.Location = new System.Drawing.Point(21, 239);
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
            this.txtAdd.Size = new System.Drawing.Size(640, 58);
            this.txtAdd.TabIndex = 35;
            this.txtAdd.Text = "28 Isikan Close ";
            this.txtAdd.UseSelectable = true;
            this.txtAdd.WaterMark = "Address";
            this.txtAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFirstName
            // 
            // 
            // 
            // 
            this.txtFirstName.CustomButton.Image = null;
            this.txtFirstName.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.txtFirstName.CustomButton.Name = "";
            this.txtFirstName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstName.CustomButton.TabIndex = 1;
            this.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstName.CustomButton.UseSelectable = true;
            this.txtFirstName.CustomButton.Visible = false;
            this.txtFirstName.DisplayIcon = true;
            this.txtFirstName.Icon = ((System.Drawing.Image)(resources.GetObject("txtFirstName.Icon")));
            this.txtFirstName.Lines = new string[] {
        "John"};
            this.txtFirstName.Location = new System.Drawing.Point(21, 88);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PromptText = "First Name";
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(291, 31);
            this.txtFirstName.TabIndex = 29;
            this.txtFirstName.Text = "John";
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMark = "First Name";
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstName.Click += new System.EventHandler(this.txtFirstName_Click);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(29, 436);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 17);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.label11_Click);
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 462);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxNewProdImg);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.txtOtherName);
            this.Controls.Add(this.cbxTitle);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNewProdImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxNewProdImg;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnUploadImage;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cboSex;
        public MetroFramework.Controls.MetroTextBox txtOtherName;
        public System.Windows.Forms.ComboBox cbxTitle;
        public MetroFramework.Controls.MetroDateTime dtpDob;
        public MetroFramework.Controls.MetroTextBox TxtEmail;
        public MetroFramework.Controls.MetroTextBox txtStaffID;
        public MetroFramework.Controls.MetroTextBox txtPhone;
        public MetroFramework.Controls.MetroTextBox txtAdd;
        public MetroFramework.Controls.MetroTextBox txtLastName;
        public MetroFramework.Controls.MetroTextBox txtFirstName;
        public System.Windows.Forms.Label lblID;
    }
}