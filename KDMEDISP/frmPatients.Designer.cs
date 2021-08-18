namespace KDMEDISP
{
    partial class frmPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatients));
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.dtpDob = new MetroFramework.Controls.MetroDateTime();
            this.cbxTitle = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOtherName = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbxNewProdImg = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.txtMedicalNotes = new MetroFramework.Controls.MetroTextBox();
            this.txtAllergies = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtNextofKin = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtpatientAdd = new MetroFramework.Controls.MetroTextBox();
            this.txtfirstname = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtOrganisation = new MetroFramework.Controls.MetroTextBox();
            this.txtNextofkinPhone = new MetroFramework.Controls.MetroTextBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUniPatientID = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNewProdImg)).BeginInit();
            this.SuspendLayout();
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
        "Joan"};
            this.txtLastName.Location = new System.Drawing.Point(82, 132);
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
            this.txtLastName.TabIndex = 12;
            this.txtLastName.Text = "Joan";
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMark = "Last Name";
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(492, 46);
            this.dtpDob.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(230, 29);
            this.dtpDob.TabIndex = 11;
            // 
            // cbxTitle
            // 
            this.cbxTitle.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cbxTitle.FormattingEnabled = true;
            this.cbxTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss.",
            "Ms.",
            "Dr."});
            this.cbxTitle.Location = new System.Drawing.Point(121, 46);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(89, 27);
            this.cbxTitle.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(81, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(405, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(248, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sex";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(403, 452);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 29);
            this.btnUpdate.TabIndex = 23;
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
            this.btnSave.Location = new System.Drawing.Point(269, 452);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 29);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(778, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Patient Image";
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
        "Bamidele"};
            this.txtOtherName.Location = new System.Drawing.Point(408, 80);
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
            this.txtOtherName.TabIndex = 11;
            this.txtOtherName.Text = "Bamidele";
            this.txtOtherName.UseSelectable = true;
            this.txtOtherName.WaterMark = "Other Name";
            this.txtOtherName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOtherName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(39, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "PATIENT DETAILS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(15)))), ((int)(((byte)(41)))));
            this.panel4.Location = new System.Drawing.Point(1, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 10);
            this.panel4.TabIndex = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pbxNewProdImg
            // 
            this.pbxNewProdImg.Image = ((System.Drawing.Image)(resources.GetObject("pbxNewProdImg.Image")));
            this.pbxNewProdImg.Location = new System.Drawing.Point(781, 78);
            this.pbxNewProdImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxNewProdImg.Name = "pbxNewProdImg";
            this.pbxNewProdImg.Size = new System.Drawing.Size(101, 85);
            this.pbxNewProdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNewProdImg.TabIndex = 18;
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
            this.btnUploadImage.Location = new System.Drawing.Point(755, 184);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(180, 29);
            this.btnUploadImage.TabIndex = 24;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // txtMedicalNotes
            // 
            // 
            // 
            // 
            this.txtMedicalNotes.CustomButton.Image = null;
            this.txtMedicalNotes.CustomButton.Location = new System.Drawing.Point(552, 2);
            this.txtMedicalNotes.CustomButton.Name = "";
            this.txtMedicalNotes.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.txtMedicalNotes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMedicalNotes.CustomButton.TabIndex = 1;
            this.txtMedicalNotes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMedicalNotes.CustomButton.UseSelectable = true;
            this.txtMedicalNotes.CustomButton.Visible = false;
            this.txtMedicalNotes.DisplayIcon = true;
            this.txtMedicalNotes.Icon = ((System.Drawing.Image)(resources.GetObject("txtMedicalNotes.Icon")));
            this.txtMedicalNotes.Lines = new string[] {
        "Patient  is an  Solder and might show..."};
            this.txtMedicalNotes.Location = new System.Drawing.Point(80, 345);
            this.txtMedicalNotes.MaxLength = 32767;
            this.txtMedicalNotes.Multiline = true;
            this.txtMedicalNotes.Name = "txtMedicalNotes";
            this.txtMedicalNotes.PasswordChar = '\0';
            this.txtMedicalNotes.PromptText = "Medical Notes";
            this.txtMedicalNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMedicalNotes.SelectedText = "";
            this.txtMedicalNotes.SelectionLength = 0;
            this.txtMedicalNotes.SelectionStart = 0;
            this.txtMedicalNotes.ShortcutsEnabled = true;
            this.txtMedicalNotes.Size = new System.Drawing.Size(640, 90);
            this.txtMedicalNotes.TabIndex = 21;
            this.txtMedicalNotes.Text = "Patient  is an  Solder and might show...";
            this.txtMedicalNotes.UseSelectable = true;
            this.txtMedicalNotes.WaterMark = "Medical Notes";
            this.txtMedicalNotes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMedicalNotes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAllergies
            // 
            // 
            // 
            // 
            this.txtAllergies.CustomButton.Image = null;
            this.txtAllergies.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txtAllergies.CustomButton.Name = "";
            this.txtAllergies.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.txtAllergies.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAllergies.CustomButton.TabIndex = 1;
            this.txtAllergies.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAllergies.CustomButton.UseSelectable = true;
            this.txtAllergies.CustomButton.Visible = false;
            this.txtAllergies.DisplayIcon = true;
            this.txtAllergies.Icon = ((System.Drawing.Image)(resources.GetObject("txtAllergies.Icon")));
            this.txtAllergies.Lines = new string[] {
        "Peptides"};
            this.txtAllergies.Location = new System.Drawing.Point(408, 278);
            this.txtAllergies.MaxLength = 32767;
            this.txtAllergies.Multiline = true;
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.PasswordChar = '\0';
            this.txtAllergies.PromptText = "Allergies";
            this.txtAllergies.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAllergies.SelectedText = "";
            this.txtAllergies.SelectionLength = 0;
            this.txtAllergies.SelectionStart = 0;
            this.txtAllergies.ShortcutsEnabled = true;
            this.txtAllergies.Size = new System.Drawing.Size(314, 61);
            this.txtAllergies.TabIndex = 19;
            this.txtAllergies.Text = "Peptides";
            this.txtAllergies.UseSelectable = true;
            this.txtAllergies.WaterMark = "Allergies";
            this.txtAllergies.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAllergies.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DisplayIcon = true;
            this.txtEmail.Icon = ((System.Drawing.Image)(resources.GetObject("txtEmail.Icon")));
            this.txtEmail.Lines = new string[] {
        "tola@gmail.com"};
            this.txtEmail.Location = new System.Drawing.Point(80, 237);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(291, 31);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Text = "tola@gmail.com";
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Click += new System.EventHandler(this.metroTextBox6_Click);
            // 
            // txtNextofKin
            // 
            // 
            // 
            // 
            this.txtNextofKin.CustomButton.Image = null;
            this.txtNextofKin.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.txtNextofKin.CustomButton.Name = "";
            this.txtNextofKin.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtNextofKin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNextofKin.CustomButton.TabIndex = 1;
            this.txtNextofKin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNextofKin.CustomButton.UseSelectable = true;
            this.txtNextofKin.CustomButton.Visible = false;
            this.txtNextofKin.DisplayIcon = true;
            this.txtNextofKin.Icon = ((System.Drawing.Image)(resources.GetObject("txtNextofKin.Icon")));
            this.txtNextofKin.Lines = new string[] {
        "Sussan Okon"};
            this.txtNextofKin.Location = new System.Drawing.Point(408, 184);
            this.txtNextofKin.MaxLength = 32767;
            this.txtNextofKin.Name = "txtNextofKin";
            this.txtNextofKin.PasswordChar = '\0';
            this.txtNextofKin.PromptText = "Next of Kin";
            this.txtNextofKin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNextofKin.SelectedText = "";
            this.txtNextofKin.SelectionLength = 0;
            this.txtNextofKin.SelectionStart = 0;
            this.txtNextofKin.ShortcutsEnabled = true;
            this.txtNextofKin.Size = new System.Drawing.Size(314, 31);
            this.txtNextofKin.TabIndex = 15;
            this.txtNextofKin.Text = "Sussan Okon";
            this.txtNextofKin.UseSelectable = true;
            this.txtNextofKin.WaterMark = "Next of Kin";
            this.txtNextofKin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNextofKin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
        "08163930033"};
            this.txtPhone.Location = new System.Drawing.Point(82, 184);
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
            this.txtPhone.TabIndex = 14;
            this.txtPhone.Text = "08163930033";
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMark = "Phone";
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.Click += new System.EventHandler(this.metroTextBox4_Click);
            // 
            // txtpatientAdd
            // 
            // 
            // 
            // 
            this.txtpatientAdd.CustomButton.Image = null;
            this.txtpatientAdd.CustomButton.Location = new System.Drawing.Point(258, 2);
            this.txtpatientAdd.CustomButton.Name = "";
            this.txtpatientAdd.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.txtpatientAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpatientAdd.CustomButton.TabIndex = 1;
            this.txtpatientAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpatientAdd.CustomButton.UseSelectable = true;
            this.txtpatientAdd.CustomButton.Visible = false;
            this.txtpatientAdd.DisplayIcon = true;
            this.txtpatientAdd.Icon = ((System.Drawing.Image)(resources.GetObject("txtpatientAdd.Icon")));
            this.txtpatientAdd.Lines = new string[] {
        "19 Omoko Close Benin"};
            this.txtpatientAdd.Location = new System.Drawing.Point(408, 118);
            this.txtpatientAdd.MaxLength = 32767;
            this.txtpatientAdd.Multiline = true;
            this.txtpatientAdd.Name = "txtpatientAdd";
            this.txtpatientAdd.PasswordChar = '\0';
            this.txtpatientAdd.PromptText = "Address";
            this.txtpatientAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpatientAdd.SelectedText = "";
            this.txtpatientAdd.SelectionLength = 0;
            this.txtpatientAdd.SelectionStart = 0;
            this.txtpatientAdd.ShortcutsEnabled = true;
            this.txtpatientAdd.Size = new System.Drawing.Size(314, 58);
            this.txtpatientAdd.Style = MetroFramework.MetroColorStyle.White;
            this.txtpatientAdd.TabIndex = 13;
            this.txtpatientAdd.Text = "19 Omoko Close Benin";
            this.txtpatientAdd.UseSelectable = true;
            this.txtpatientAdd.WaterMark = "Address";
            this.txtpatientAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpatientAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtfirstname
            // 
            // 
            // 
            // 
            this.txtfirstname.CustomButton.Image = null;
            this.txtfirstname.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.txtfirstname.CustomButton.Name = "";
            this.txtfirstname.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtfirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfirstname.CustomButton.TabIndex = 1;
            this.txtfirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtfirstname.CustomButton.UseSelectable = true;
            this.txtfirstname.CustomButton.Visible = false;
            this.txtfirstname.DisplayIcon = true;
            this.txtfirstname.Icon = ((System.Drawing.Image)(resources.GetObject("txtfirstname.Icon")));
            this.txtfirstname.Lines = new string[] {
        "Tola"};
            this.txtfirstname.Location = new System.Drawing.Point(82, 80);
            this.txtfirstname.MaxLength = 32767;
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.PasswordChar = '\0';
            this.txtfirstname.PromptText = "First Name";
            this.txtfirstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfirstname.SelectedText = "";
            this.txtfirstname.SelectionLength = 0;
            this.txtfirstname.SelectionStart = 0;
            this.txtfirstname.ShortcutsEnabled = true;
            this.txtfirstname.Size = new System.Drawing.Size(291, 31);
            this.txtfirstname.TabIndex = 10;
            this.txtfirstname.Text = "Tola";
            this.txtfirstname.UseSelectable = true;
            this.txtfirstname.WaterMark = "First Name";
            this.txtfirstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfirstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // txtOrganisation
            // 
            // 
            // 
            // 
            this.txtOrganisation.CustomButton.Image = null;
            this.txtOrganisation.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.txtOrganisation.CustomButton.Name = "";
            this.txtOrganisation.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtOrganisation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrganisation.CustomButton.TabIndex = 1;
            this.txtOrganisation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrganisation.CustomButton.UseSelectable = true;
            this.txtOrganisation.CustomButton.Visible = false;
            this.txtOrganisation.DisplayIcon = true;
            this.txtOrganisation.Icon = global::KDMEDISP.Properties.Resources.Worker_20px;
            this.txtOrganisation.Lines = new string[] {
        "Total Plc"};
            this.txtOrganisation.Location = new System.Drawing.Point(80, 278);
            this.txtOrganisation.MaxLength = 32767;
            this.txtOrganisation.Name = "txtOrganisation";
            this.txtOrganisation.PasswordChar = '\0';
            this.txtOrganisation.PromptText = "Organisation";
            this.txtOrganisation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrganisation.SelectedText = "";
            this.txtOrganisation.SelectionLength = 0;
            this.txtOrganisation.SelectionStart = 0;
            this.txtOrganisation.ShortcutsEnabled = true;
            this.txtOrganisation.Size = new System.Drawing.Size(291, 31);
            this.txtOrganisation.TabIndex = 20;
            this.txtOrganisation.Text = "Total Plc";
            this.txtOrganisation.UseSelectable = true;
            this.txtOrganisation.WaterMark = "Organisation";
            this.txtOrganisation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrganisation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOrganisation.Click += new System.EventHandler(this.metroTextBox6_Click);
            // 
            // txtNextofkinPhone
            // 
            // 
            // 
            // 
            this.txtNextofkinPhone.CustomButton.Image = null;
            this.txtNextofkinPhone.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.txtNextofkinPhone.CustomButton.Name = "";
            this.txtNextofkinPhone.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtNextofkinPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNextofkinPhone.CustomButton.TabIndex = 1;
            this.txtNextofkinPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNextofkinPhone.CustomButton.UseSelectable = true;
            this.txtNextofkinPhone.CustomButton.Visible = false;
            this.txtNextofkinPhone.DisplayIcon = true;
            this.txtNextofkinPhone.Icon = ((System.Drawing.Image)(resources.GetObject("txtNextofkinPhone.Icon")));
            this.txtNextofkinPhone.Lines = new string[] {
        "08163662326"};
            this.txtNextofkinPhone.Location = new System.Drawing.Point(408, 237);
            this.txtNextofkinPhone.MaxLength = 32767;
            this.txtNextofkinPhone.Name = "txtNextofkinPhone";
            this.txtNextofkinPhone.PasswordChar = '\0';
            this.txtNextofkinPhone.PromptText = "Phone of Next of Kin";
            this.txtNextofkinPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNextofkinPhone.SelectedText = "";
            this.txtNextofkinPhone.SelectionLength = 0;
            this.txtNextofkinPhone.SelectionStart = 0;
            this.txtNextofkinPhone.ShortcutsEnabled = true;
            this.txtNextofkinPhone.Size = new System.Drawing.Size(314, 31);
            this.txtNextofkinPhone.TabIndex = 17;
            this.txtNextofkinPhone.Text = "08163662326";
            this.txtNextofkinPhone.UseSelectable = true;
            this.txtNextofkinPhone.WaterMark = "Phone of Next of Kin";
            this.txtNextofkinPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNextofkinPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNextofkinPhone.Click += new System.EventHandler(this.metroTextBox4_Click);
            // 
            // cbxSex
            // 
            this.cbxSex.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxSex.Location = new System.Drawing.Point(282, 46);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(89, 27);
            this.cbxSex.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(351, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "PATIENT ID:";
            // 
            // lblUniPatientID
            // 
            this.lblUniPatientID.AutoSize = true;
            this.lblUniPatientID.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblUniPatientID.ForeColor = System.Drawing.Color.Black;
            this.lblUniPatientID.Location = new System.Drawing.Point(431, 5);
            this.lblUniPatientID.Name = "lblUniPatientID";
            this.lblUniPatientID.Size = new System.Drawing.Size(17, 17);
            this.lblUniPatientID.TabIndex = 13;
            this.lblUniPatientID.Text = "...";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblid.ForeColor = System.Drawing.Color.Black;
            this.lblid.Location = new System.Drawing.Point(12, 502);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 17);
            this.lblid.TabIndex = 13;
            this.lblid.Text = "id";
            this.lblid.Visible = false;
            // 
            // frmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 592);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxNewProdImg);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUniPatientID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(this.cbxTitle);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.txtMedicalNotes);
            this.Controls.Add(this.txtAllergies);
            this.Controls.Add(this.txtOrganisation);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNextofKin);
            this.Controls.Add(this.txtNextofkinPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtpatientAdd);
            this.Controls.Add(this.txtOtherName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtfirstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPatients";
            this.Load += new System.EventHandler(this.frmPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNewProdImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox pbxNewProdImg;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnUploadImage;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUniPatientID;
        public MetroFramework.Controls.MetroTextBox txtfirstname;
        public MetroFramework.Controls.MetroTextBox txtLastName;
        public MetroFramework.Controls.MetroTextBox txtNextofKin;
        public MetroFramework.Controls.MetroTextBox txtpatientAdd;
        public MetroFramework.Controls.MetroTextBox txtPhone;
        public MetroFramework.Controls.MetroDateTime dtpDob;
        public MetroFramework.Controls.MetroTextBox txtEmail;
        public MetroFramework.Controls.MetroTextBox txtAllergies;
        public System.Windows.Forms.ComboBox cbxTitle;
        public MetroFramework.Controls.MetroTextBox txtMedicalNotes;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public MetroFramework.Controls.MetroTextBox txtOtherName;
        public MetroFramework.Controls.MetroTextBox txtOrganisation;
        public MetroFramework.Controls.MetroTextBox txtNextofkinPhone;
        public System.Windows.Forms.ComboBox cbxSex;
        public System.Windows.Forms.Label lblid;
    }
}