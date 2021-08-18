namespace KDMEDISP
{
    partial class frmDrug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrug));
            this.lblID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProdExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboClassofDrug = new System.Windows.Forms.ComboBox();
            this.dtpExpiry = new MetroFramework.Controls.MetroDateTime();
            this.txtprimary = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGeneric = new MetroFramework.Controls.MetroTextBox();
            this.txtstrength = new MetroFramework.Controls.MetroTextBox();
            this.txtUnit = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtReorderLevel = new MetroFramework.Controls.MetroTextBox();
            this.txtIniQty = new MetroFramework.Controls.MetroTextBox();
            this.txtPcode = new MetroFramework.Controls.MetroTextBox();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtDrugAddInfo = new MetroFramework.Controls.MetroTextBox();
            this.cboManufacturers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPackage = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSigTrans = new MetroFramework.Controls.MetroTextBox();
            this.cbxSigWhen = new System.Windows.Forms.ComboBox();
            this.cbxSigHowMuch = new System.Windows.Forms.ComboBox();
            this.cbxSigOften = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxSigHow = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSigQty = new MetroFramework.Controls.MetroTextBox();
            this.cboSupplier = new MetroFramework.Controls.MetroComboBox();
            this.btnLoadDrugs = new System.Windows.Forms.Button();
            this.txtStorageLocation = new MetroFramework.Controls.MetroTextBox();
            this.txtBarCode = new MetroFramework.Controls.MetroTextBox();
            this.pbxNewProdImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNewProdImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(972, 540);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 17);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "label2";
            this.lblID.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(500, 465);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 33);
            this.btnUpdate.TabIndex = 7;
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
            this.btnSave.Location = new System.Drawing.Point(351, 465);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(15)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.btnProdExit);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 40);
            this.panel2.TabIndex = 9;
            // 
            // btnProdExit
            // 
            this.btnProdExit.ForeColor = System.Drawing.Color.Red;
            this.btnProdExit.Location = new System.Drawing.Point(995, 4);
            this.btnProdExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProdExit.Name = "btnProdExit";
            this.btnProdExit.Size = new System.Drawing.Size(22, 26);
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
            this.label7.Location = new System.Drawing.Point(40, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Drugs Entry Module";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label5.Location = new System.Drawing.Point(432, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Supplier";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(822, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Product Image";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.Location = new System.Drawing.Point(930, 142);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(75, 28);
            this.btnUploadImage.TabIndex = 8;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(430, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Expiry Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(516, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Class";
            // 
            // cboClassofDrug
            // 
            this.cboClassofDrug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboClassofDrug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassofDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClassofDrug.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.cboClassofDrug.FormattingEnabled = true;
            this.cboClassofDrug.Items.AddRange(new object[] {
            "oral drugs",
            "injectable drugs",
            "infusion fluids",
            "vaccines, immunoglobulins and antisera",
            "drugs for external use and antiseptics",
            "disinfectants",
            "Controlled Substances"});
            this.cboClassofDrug.Location = new System.Drawing.Point(560, 60);
            this.cboClassofDrug.Name = "cboClassofDrug";
            this.cboClassofDrug.Size = new System.Drawing.Size(247, 27);
            this.cboClassofDrug.TabIndex = 23;
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Location = new System.Drawing.Point(513, 290);
            this.dtpExpiry.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(230, 29);
            this.dtpExpiry.TabIndex = 21;
            // 
            // txtprimary
            // 
            this.txtprimary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            // 
            // 
            // 
            this.txtprimary.CustomButton.Image = null;
            this.txtprimary.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txtprimary.CustomButton.Name = "";
            this.txtprimary.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtprimary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtprimary.CustomButton.TabIndex = 1;
            this.txtprimary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtprimary.CustomButton.UseSelectable = true;
            this.txtprimary.CustomButton.Visible = false;
            this.txtprimary.DisplayIcon = true;
            this.txtprimary.Lines = new string[0];
            this.txtprimary.Location = new System.Drawing.Point(25, 65);
            this.txtprimary.MaxLength = 32767;
            this.txtprimary.Name = "txtprimary";
            this.txtprimary.PasswordChar = '\0';
            this.txtprimary.PromptText = "Brand Name e.g Aspirin 500mg";
            this.txtprimary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtprimary.SelectedText = "";
            this.txtprimary.SelectionLength = 0;
            this.txtprimary.SelectionStart = 0;
            this.txtprimary.ShortcutsEnabled = true;
            this.txtprimary.Size = new System.Drawing.Size(240, 30);
            this.txtprimary.TabIndex = 27;
            this.txtprimary.UseSelectable = true;
            this.txtprimary.WaterMark = "Brand Name e.g Aspirin 500mg";
            this.txtprimary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtprimary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel1.Location = new System.Drawing.Point(71, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 3);
            this.panel1.TabIndex = 28;
            // 
            // txtGeneric
            // 
            // 
            // 
            // 
            this.txtGeneric.CustomButton.Image = null;
            this.txtGeneric.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.txtGeneric.CustomButton.Name = "";
            this.txtGeneric.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtGeneric.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGeneric.CustomButton.TabIndex = 1;
            this.txtGeneric.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGeneric.CustomButton.UseSelectable = true;
            this.txtGeneric.CustomButton.Visible = false;
            this.txtGeneric.DisplayIcon = true;
            this.txtGeneric.Lines = new string[0];
            this.txtGeneric.Location = new System.Drawing.Point(25, 123);
            this.txtGeneric.MaxLength = 32767;
            this.txtGeneric.Name = "txtGeneric";
            this.txtGeneric.PasswordChar = '\0';
            this.txtGeneric.PromptText = "Generic";
            this.txtGeneric.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGeneric.SelectedText = "";
            this.txtGeneric.SelectionLength = 0;
            this.txtGeneric.SelectionStart = 0;
            this.txtGeneric.ShortcutsEnabled = true;
            this.txtGeneric.Size = new System.Drawing.Size(279, 30);
            this.txtGeneric.TabIndex = 27;
            this.txtGeneric.UseSelectable = true;
            this.txtGeneric.WaterMark = "Generic";
            this.txtGeneric.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGeneric.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtstrength
            // 
            // 
            // 
            // 
            this.txtstrength.CustomButton.Image = null;
            this.txtstrength.CustomButton.Location = new System.Drawing.Point(125, 2);
            this.txtstrength.CustomButton.Name = "";
            this.txtstrength.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtstrength.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtstrength.CustomButton.TabIndex = 1;
            this.txtstrength.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtstrength.CustomButton.UseSelectable = true;
            this.txtstrength.CustomButton.Visible = false;
            this.txtstrength.Lines = new string[0];
            this.txtstrength.Location = new System.Drawing.Point(351, 65);
            this.txtstrength.MaxLength = 32767;
            this.txtstrength.Name = "txtstrength";
            this.txtstrength.PasswordChar = '\0';
            this.txtstrength.PromptText = "Strength eg. 80mg";
            this.txtstrength.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtstrength.SelectedText = "";
            this.txtstrength.SelectionLength = 0;
            this.txtstrength.SelectionStart = 0;
            this.txtstrength.ShortcutsEnabled = true;
            this.txtstrength.Size = new System.Drawing.Size(153, 30);
            this.txtstrength.TabIndex = 29;
            this.txtstrength.UseSelectable = true;
            this.txtstrength.WaterMark = "Strength eg. 80mg";
            this.txtstrength.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtstrength.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUnit
            // 
            // 
            // 
            // 
            this.txtUnit.CustomButton.Image = null;
            this.txtUnit.CustomButton.Location = new System.Drawing.Point(125, 2);
            this.txtUnit.CustomButton.Name = "";
            this.txtUnit.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnit.CustomButton.TabIndex = 1;
            this.txtUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnit.CustomButton.UseSelectable = true;
            this.txtUnit.CustomButton.Visible = false;
            this.txtUnit.Lines = new string[0];
            this.txtUnit.Location = new System.Drawing.Point(351, 102);
            this.txtUnit.MaxLength = 32767;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PasswordChar = '\0';
            this.txtUnit.PromptText = "units e.g Tablets";
            this.txtUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnit.SelectedText = "";
            this.txtUnit.SelectionLength = 0;
            this.txtUnit.SelectionStart = 0;
            this.txtUnit.ShortcutsEnabled = true;
            this.txtUnit.Size = new System.Drawing.Size(153, 30);
            this.txtUnit.TabIndex = 29;
            this.txtUnit.UseSelectable = true;
            this.txtUnit.WaterMark = "units e.g Tablets";
            this.txtUnit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(1, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Others";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel3.Location = new System.Drawing.Point(53, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 3);
            this.panel3.TabIndex = 28;
            // 
            // txtReorderLevel
            // 
            // 
            // 
            // 
            this.txtReorderLevel.CustomButton.Image = null;
            this.txtReorderLevel.CustomButton.Location = new System.Drawing.Point(125, 2);
            this.txtReorderLevel.CustomButton.Name = "";
            this.txtReorderLevel.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtReorderLevel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReorderLevel.CustomButton.TabIndex = 1;
            this.txtReorderLevel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReorderLevel.CustomButton.UseSelectable = true;
            this.txtReorderLevel.CustomButton.Visible = false;
            this.txtReorderLevel.Lines = new string[0];
            this.txtReorderLevel.Location = new System.Drawing.Point(251, 333);
            this.txtReorderLevel.MaxLength = 32767;
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.PasswordChar = '\0';
            this.txtReorderLevel.PromptText = "Reorder Level 300";
            this.txtReorderLevel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReorderLevel.SelectedText = "";
            this.txtReorderLevel.SelectionLength = 0;
            this.txtReorderLevel.SelectionStart = 0;
            this.txtReorderLevel.ShortcutsEnabled = true;
            this.txtReorderLevel.Size = new System.Drawing.Size(153, 30);
            this.txtReorderLevel.TabIndex = 29;
            this.txtReorderLevel.UseSelectable = true;
            this.txtReorderLevel.WaterMark = "Reorder Level 300";
            this.txtReorderLevel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReorderLevel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIniQty
            // 
            // 
            // 
            // 
            this.txtIniQty.CustomButton.Image = null;
            this.txtIniQty.CustomButton.Location = new System.Drawing.Point(125, 2);
            this.txtIniQty.CustomButton.Name = "";
            this.txtIniQty.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtIniQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIniQty.CustomButton.TabIndex = 1;
            this.txtIniQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIniQty.CustomButton.UseSelectable = true;
            this.txtIniQty.CustomButton.Visible = false;
            this.txtIniQty.Lines = new string[0];
            this.txtIniQty.Location = new System.Drawing.Point(251, 290);
            this.txtIniQty.MaxLength = 32767;
            this.txtIniQty.Name = "txtIniQty";
            this.txtIniQty.PasswordChar = '\0';
            this.txtIniQty.PromptText = "Entry Stock Qty";
            this.txtIniQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIniQty.SelectedText = "";
            this.txtIniQty.SelectionLength = 0;
            this.txtIniQty.SelectionStart = 0;
            this.txtIniQty.ShortcutsEnabled = true;
            this.txtIniQty.Size = new System.Drawing.Size(153, 30);
            this.txtIniQty.TabIndex = 29;
            this.txtIniQty.UseSelectable = true;
            this.txtIniQty.WaterMark = "Entry Stock Qty";
            this.txtIniQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIniQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPcode
            // 
            // 
            // 
            // 
            this.txtPcode.CustomButton.Image = null;
            this.txtPcode.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtPcode.CustomButton.Name = "";
            this.txtPcode.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPcode.CustomButton.TabIndex = 1;
            this.txtPcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPcode.CustomButton.UseSelectable = true;
            this.txtPcode.CustomButton.Visible = false;
            this.txtPcode.Enabled = false;
            this.txtPcode.Lines = new string[0];
            this.txtPcode.Location = new System.Drawing.Point(25, 293);
            this.txtPcode.MaxLength = 32767;
            this.txtPcode.Name = "txtPcode";
            this.txtPcode.PasswordChar = '\0';
            this.txtPcode.PromptText = "Product Code";
            this.txtPcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPcode.SelectedText = "";
            this.txtPcode.SelectionLength = 0;
            this.txtPcode.SelectionStart = 0;
            this.txtPcode.ShortcutsEnabled = true;
            this.txtPcode.Size = new System.Drawing.Size(194, 30);
            this.txtPcode.TabIndex = 29;
            this.txtPcode.UseSelectable = true;
            this.txtPcode.WaterMark = "Product Code";
            this.txtPcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(125, 2);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(857, 333);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PromptText = "Price eg. 200";
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(153, 30);
            this.txtPrice.TabIndex = 29;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMark = "Price eg. 200";
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress_1);
            // 
            // txtDrugAddInfo
            // 
            // 
            // 
            // 
            this.txtDrugAddInfo.CustomButton.Image = null;
            this.txtDrugAddInfo.CustomButton.Location = new System.Drawing.Point(644, 2);
            this.txtDrugAddInfo.CustomButton.Name = "";
            this.txtDrugAddInfo.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.txtDrugAddInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDrugAddInfo.CustomButton.TabIndex = 1;
            this.txtDrugAddInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDrugAddInfo.CustomButton.UseSelectable = true;
            this.txtDrugAddInfo.CustomButton.Visible = false;
            this.txtDrugAddInfo.DisplayIcon = true;
            this.txtDrugAddInfo.Lines = new string[0];
            this.txtDrugAddInfo.Location = new System.Drawing.Point(242, 374);
            this.txtDrugAddInfo.MaxLength = 32767;
            this.txtDrugAddInfo.Multiline = true;
            this.txtDrugAddInfo.Name = "txtDrugAddInfo";
            this.txtDrugAddInfo.PasswordChar = '\0';
            this.txtDrugAddInfo.PromptText = "Additional Notes";
            this.txtDrugAddInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDrugAddInfo.SelectedText = "";
            this.txtDrugAddInfo.SelectionLength = 0;
            this.txtDrugAddInfo.SelectionStart = 0;
            this.txtDrugAddInfo.ShortcutsEnabled = true;
            this.txtDrugAddInfo.Size = new System.Drawing.Size(726, 84);
            this.txtDrugAddInfo.TabIndex = 30;
            this.txtDrugAddInfo.UseSelectable = true;
            this.txtDrugAddInfo.WaterMark = "Additional Notes";
            this.txtDrugAddInfo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDrugAddInfo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboManufacturers
            // 
            this.cboManufacturers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboManufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManufacturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboManufacturers.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboManufacturers.FormattingEnabled = true;
            this.cboManufacturers.Items.AddRange(new object[] {
            "oral drugs",
            "injectable drugs",
            "infusion fluids",
            "vaccines, immunoglobulins and antisera",
            "drugs for external use and antiseptics",
            "disinfectants",
            "Controlled Substances"});
            this.cboManufacturers.Location = new System.Drawing.Point(608, 105);
            this.cboManufacturers.Name = "cboManufacturers";
            this.cboManufacturers.Size = new System.Drawing.Size(199, 25);
            this.cboManufacturers.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(516, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Manufacturer";
            // 
            // cboPackage
            // 
            this.cboPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.ItemHeight = 23;
            this.cboPackage.Items.AddRange(new object[] {
            "Vials",
            "Bottles",
            "Blister pack",
            "Sachets",
            "Syringes",
            "Ampoules",
            "Others"});
            this.cboPackage.Location = new System.Drawing.Point(815, 296);
            this.cboPackage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(190, 29);
            this.cboPackage.TabIndex = 31;
            this.cboPackage.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label3.Location = new System.Drawing.Point(753, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Package";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(-3, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Default Sig";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel4.Location = new System.Drawing.Point(80, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(915, 3);
            this.panel4.TabIndex = 28;
            // 
            // txtSigTrans
            // 
            // 
            // 
            // 
            this.txtSigTrans.CustomButton.Image = null;
            this.txtSigTrans.CustomButton.Location = new System.Drawing.Point(762, 2);
            this.txtSigTrans.CustomButton.Name = "";
            this.txtSigTrans.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtSigTrans.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSigTrans.CustomButton.TabIndex = 1;
            this.txtSigTrans.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSigTrans.CustomButton.UseSelectable = true;
            this.txtSigTrans.CustomButton.Visible = false;
            this.txtSigTrans.DisplayIcon = true;
            this.txtSigTrans.Lines = new string[0];
            this.txtSigTrans.Location = new System.Drawing.Point(80, 235);
            this.txtSigTrans.MaxLength = 32767;
            this.txtSigTrans.Multiline = true;
            this.txtSigTrans.Name = "txtSigTrans";
            this.txtSigTrans.PasswordChar = '\0';
            this.txtSigTrans.PromptText = "Interpretation of Sig";
            this.txtSigTrans.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSigTrans.SelectedText = "";
            this.txtSigTrans.SelectionLength = 0;
            this.txtSigTrans.SelectionStart = 0;
            this.txtSigTrans.ShortcutsEnabled = true;
            this.txtSigTrans.Size = new System.Drawing.Size(804, 44);
            this.txtSigTrans.TabIndex = 30;
            this.txtSigTrans.UseSelectable = true;
            this.txtSigTrans.WaterMark = "Interpretation of Sig";
            this.txtSigTrans.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSigTrans.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxSigWhen
            // 
            this.cbxSigWhen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.cbxSigWhen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSigWhen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxSigWhen.ForeColor = System.Drawing.Color.White;
            this.cbxSigWhen.FormattingEnabled = true;
            this.cbxSigWhen.Location = new System.Drawing.Point(513, 201);
            this.cbxSigWhen.Name = "cbxSigWhen";
            this.cbxSigWhen.Size = new System.Drawing.Size(138, 25);
            this.cbxSigWhen.TabIndex = 23;
            this.cbxSigWhen.SelectedIndexChanged += new System.EventHandler(this.cbxSigWhen_SelectedIndexChanged);
            // 
            // cbxSigHowMuch
            // 
            this.cbxSigHowMuch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.cbxSigHowMuch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSigHowMuch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxSigHowMuch.ForeColor = System.Drawing.Color.White;
            this.cbxSigHowMuch.FormattingEnabled = true;
            this.cbxSigHowMuch.Location = new System.Drawing.Point(149, 201);
            this.cbxSigHowMuch.Name = "cbxSigHowMuch";
            this.cbxSigHowMuch.Size = new System.Drawing.Size(186, 25);
            this.cbxSigHowMuch.TabIndex = 23;
            this.cbxSigHowMuch.SelectedIndexChanged += new System.EventHandler(this.cbxSigHowMuch_SelectedIndexChanged);
            // 
            // cbxSigOften
            // 
            this.cbxSigOften.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.cbxSigOften.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSigOften.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxSigOften.ForeColor = System.Drawing.Color.White;
            this.cbxSigOften.FormattingEnabled = true;
            this.cbxSigOften.Location = new System.Drawing.Point(351, 200);
            this.cbxSigOften.Name = "cbxSigOften";
            this.cbxSigOften.Size = new System.Drawing.Size(138, 25);
            this.cbxSigOften.TabIndex = 23;
            this.cbxSigOften.SelectedIndexChanged += new System.EventHandler(this.cbxSigOften_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(406, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Often?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(593, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "When?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(193, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "How Much ?";
            // 
            // cbxSigHow
            // 
            this.cbxSigHow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.cbxSigHow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSigHow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxSigHow.ForeColor = System.Drawing.Color.White;
            this.cbxSigHow.FormattingEnabled = true;
            this.cbxSigHow.Location = new System.Drawing.Point(673, 201);
            this.cbxSigHow.Name = "cbxSigHow";
            this.cbxSigHow.Size = new System.Drawing.Size(211, 25);
            this.cbxSigHow.TabIndex = 23;
            this.cbxSigHow.SelectedIndexChanged += new System.EventHandler(this.cbxSigHow_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(753, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "How?";
            // 
            // txtSigQty
            // 
            // 
            // 
            // 
            this.txtSigQty.CustomButton.Image = null;
            this.txtSigQty.CustomButton.Location = new System.Drawing.Point(21, 1);
            this.txtSigQty.CustomButton.Name = "";
            this.txtSigQty.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSigQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSigQty.CustomButton.TabIndex = 1;
            this.txtSigQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSigQty.CustomButton.UseSelectable = true;
            this.txtSigQty.CustomButton.Visible = false;
            this.txtSigQty.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtSigQty.Lines = new string[0];
            this.txtSigQty.Location = new System.Drawing.Point(90, 201);
            this.txtSigQty.MaxLength = 32767;
            this.txtSigQty.Name = "txtSigQty";
            this.txtSigQty.PasswordChar = '\0';
            this.txtSigQty.PromptText = "Qty";
            this.txtSigQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSigQty.SelectedText = "";
            this.txtSigQty.SelectionLength = 0;
            this.txtSigQty.SelectionStart = 0;
            this.txtSigQty.ShortcutsEnabled = true;
            this.txtSigQty.Size = new System.Drawing.Size(45, 25);
            this.txtSigQty.TabIndex = 29;
            this.txtSigQty.UseSelectable = true;
            this.txtSigQty.WaterMark = "Qty";
            this.txtSigQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSigQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSigQty.TextChanged += new System.EventHandler(this.txtSigQty_TextChanged);
            // 
            // cboSupplier
            // 
            this.cboSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.ItemHeight = 23;
            this.cboSupplier.Location = new System.Drawing.Point(513, 333);
            this.cboSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(202, 29);
            this.cboSupplier.TabIndex = 13;
            this.cboSupplier.UseSelectable = true;
            // 
            // btnLoadDrugs
            // 
            this.btnLoadDrugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnLoadDrugs.FlatAppearance.BorderSize = 0;
            this.btnLoadDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDrugs.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.btnLoadDrugs.ForeColor = System.Drawing.Color.White;
            this.btnLoadDrugs.Location = new System.Drawing.Point(271, 60);
            this.btnLoadDrugs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadDrugs.Name = "btnLoadDrugs";
            this.btnLoadDrugs.Size = new System.Drawing.Size(50, 35);
            this.btnLoadDrugs.TabIndex = 8;
            this.btnLoadDrugs.Text = "load";
            this.btnLoadDrugs.UseVisualStyleBackColor = false;
            this.btnLoadDrugs.Click += new System.EventHandler(this.btnLoadDrugs_Click);
            // 
            // txtStorageLocation
            // 
            // 
            // 
            // 
            this.txtStorageLocation.CustomButton.Image = null;
            this.txtStorageLocation.CustomButton.Location = new System.Drawing.Point(108, 2);
            this.txtStorageLocation.CustomButton.Name = "";
            this.txtStorageLocation.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.txtStorageLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStorageLocation.CustomButton.TabIndex = 1;
            this.txtStorageLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStorageLocation.CustomButton.UseSelectable = true;
            this.txtStorageLocation.CustomButton.Visible = false;
            this.txtStorageLocation.DisplayIcon = true;
            this.txtStorageLocation.Icon = global::KDMEDISP.Properties.Resources.ware;
            this.txtStorageLocation.Lines = new string[0];
            this.txtStorageLocation.Location = new System.Drawing.Point(25, 370);
            this.txtStorageLocation.MaxLength = 32767;
            this.txtStorageLocation.Multiline = true;
            this.txtStorageLocation.Name = "txtStorageLocation";
            this.txtStorageLocation.PasswordChar = '\0';
            this.txtStorageLocation.PromptText = "Storage Location";
            this.txtStorageLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStorageLocation.SelectedText = "";
            this.txtStorageLocation.SelectionLength = 0;
            this.txtStorageLocation.SelectionStart = 0;
            this.txtStorageLocation.ShortcutsEnabled = true;
            this.txtStorageLocation.Size = new System.Drawing.Size(194, 88);
            this.txtStorageLocation.TabIndex = 30;
            this.txtStorageLocation.UseSelectable = true;
            this.txtStorageLocation.WaterMark = "Storage Location";
            this.txtStorageLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStorageLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBarCode
            // 
            // 
            // 
            // 
            this.txtBarCode.CustomButton.Image = null;
            this.txtBarCode.CustomButton.Location = new System.Drawing.Point(162, 2);
            this.txtBarCode.CustomButton.Name = "";
            this.txtBarCode.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtBarCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarCode.CustomButton.TabIndex = 1;
            this.txtBarCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarCode.CustomButton.UseSelectable = true;
            this.txtBarCode.CustomButton.Visible = false;
            this.txtBarCode.DisplayIcon = true;
            this.txtBarCode.Icon = ((System.Drawing.Image)(resources.GetObject("txtBarCode.Icon")));
            this.txtBarCode.Lines = new string[0];
            this.txtBarCode.Location = new System.Drawing.Point(25, 329);
            this.txtBarCode.MaxLength = 32767;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.PasswordChar = '\0';
            this.txtBarCode.PromptText = "Barcode";
            this.txtBarCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarCode.SelectedText = "";
            this.txtBarCode.SelectionLength = 0;
            this.txtBarCode.SelectionStart = 0;
            this.txtBarCode.ShortcutsEnabled = true;
            this.txtBarCode.Size = new System.Drawing.Size(194, 34);
            this.txtBarCode.TabIndex = 30;
            this.txtBarCode.UseSelectable = true;
            this.txtBarCode.WaterMark = "Barcode";
            this.txtBarCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbxNewProdImg
            // 
            this.pbxNewProdImg.Location = new System.Drawing.Point(825, 72);
            this.pbxNewProdImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxNewProdImg.Name = "pbxNewProdImg";
            this.pbxNewProdImg.Size = new System.Drawing.Size(101, 96);
            this.pbxNewProdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNewProdImg.TabIndex = 14;
            this.pbxNewProdImg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KDMEDISP.Properties.Resources.drug1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 567);
            this.Controls.Add(this.cboPackage);
            this.Controls.Add(this.txtIniQty);
            this.Controls.Add(this.txtSigTrans);
            this.Controls.Add(this.txtDrugAddInfo);
            this.Controls.Add(this.txtStorageLocation);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.txtPcode);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtReorderLevel);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtSigQty);
            this.Controls.Add(this.txtstrength);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtGeneric);
            this.Controls.Add(this.txtprimary);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxSigHow);
            this.Controls.Add(this.cbxSigHowMuch);
            this.Controls.Add(this.cbxSigOften);
            this.Controls.Add(this.cbxSigWhen);
            this.Controls.Add(this.cboManufacturers);
            this.Controls.Add(this.cboClassofDrug);
            this.Controls.Add(this.dtpExpiry);
            this.Controls.Add(this.pbxNewProdImg);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.btnLoadDrugs);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDrug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNewProdImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnProdExit;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroTextBox txtPcode;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox pbxNewProdImg;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox cboClassofDrug;
        public MetroFramework.Controls.MetroDateTime dtpExpiry;
        public MetroFramework.Controls.MetroTextBox txtprimary;
        public MetroFramework.Controls.MetroTextBox txtGeneric;
        public MetroFramework.Controls.MetroTextBox txtstrength;
        public MetroFramework.Controls.MetroTextBox txtUnit;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Panel panel3;
        public MetroFramework.Controls.MetroTextBox txtBarCode;
        public MetroFramework.Controls.MetroTextBox txtReorderLevel;
        public MetroFramework.Controls.MetroTextBox txtIniQty;
        public MetroFramework.Controls.MetroTextBox txtPrice;
        public MetroFramework.Controls.MetroTextBox txtDrugAddInfo;
        public System.Windows.Forms.ComboBox cboManufacturers;
        public System.Windows.Forms.Label label2;
        public MetroFramework.Controls.MetroComboBox cboPackage;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel4;
        public MetroFramework.Controls.MetroTextBox txtSigTrans;
        public System.Windows.Forms.ComboBox cbxSigWhen;
        public System.Windows.Forms.ComboBox cbxSigHowMuch;
        public System.Windows.Forms.ComboBox cbxSigOften;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cbxSigHow;
        public System.Windows.Forms.Label label14;
        public MetroFramework.Controls.MetroTextBox txtSigQty;
        public MetroFramework.Controls.MetroTextBox txtStorageLocation;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroComboBox cboSupplier;
        public System.Windows.Forms.Button btnLoadDrugs;
    }
}