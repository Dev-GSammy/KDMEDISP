namespace KDMEDISP
{
    partial class frmAddSig
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
            this.txtSigTrans = new MetroFramework.Controls.MetroTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSigHow = new System.Windows.Forms.ComboBox();
            this.cbxSigHowMuch = new System.Windows.Forms.ComboBox();
            this.cbxSigOften = new System.Windows.Forms.ComboBox();
            this.cbxSigWhen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAssignMedication = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedicationDetails = new System.Windows.Forms.Label();
            this.cbxDaw = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSigQty = new MetroFramework.Controls.MetroTextBox();
            this.lblDaw = new System.Windows.Forms.Label();
            this.txtDispense = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRefill = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPresID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.lblDrugPCode = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSigTrans
            // 
            // 
            // 
            // 
            this.txtSigTrans.CustomButton.Image = null;
            this.txtSigTrans.CustomButton.Location = new System.Drawing.Point(495, 2);
            this.txtSigTrans.CustomButton.Name = "";
            this.txtSigTrans.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.txtSigTrans.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSigTrans.CustomButton.TabIndex = 1;
            this.txtSigTrans.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSigTrans.CustomButton.UseSelectable = true;
            this.txtSigTrans.CustomButton.Visible = false;
            this.txtSigTrans.DisplayIcon = true;
            this.txtSigTrans.Lines = new string[0];
            this.txtSigTrans.Location = new System.Drawing.Point(93, 144);
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
            this.txtSigTrans.Size = new System.Drawing.Size(553, 60);
            this.txtSigTrans.TabIndex = 43;
            this.txtSigTrans.UseSelectable = true;
            this.txtSigTrans.WaterMark = "Interpretation of Sig";
            this.txtSigTrans.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSigTrans.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(181, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(565, 3);
            this.panel4.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(522, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "How?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(152, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "How Much ?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(405, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "When?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(302, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Often?";
            // 
            // cbxSigHow
            // 
            this.cbxSigHow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.cbxSigHow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSigHow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxSigHow.ForeColor = System.Drawing.Color.White;
            this.cbxSigHow.FormattingEnabled = true;
            this.cbxSigHow.Location = new System.Drawing.Point(492, 113);
            this.cbxSigHow.Name = "cbxSigHow";
            this.cbxSigHow.Size = new System.Drawing.Size(110, 25);
            this.cbxSigHow.TabIndex = 33;
            this.cbxSigHow.SelectedIndexChanged += new System.EventHandler(this.cbxSigHow_SelectedIndexChanged);
            // 
            // cbxSigHowMuch
            // 
            this.cbxSigHowMuch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.cbxSigHowMuch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSigHowMuch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxSigHowMuch.ForeColor = System.Drawing.Color.White;
            this.cbxSigHowMuch.FormattingEnabled = true;
            this.cbxSigHowMuch.Location = new System.Drawing.Point(144, 113);
            this.cbxSigHowMuch.Name = "cbxSigHowMuch";
            this.cbxSigHowMuch.Size = new System.Drawing.Size(110, 25);
            this.cbxSigHowMuch.TabIndex = 34;
            this.cbxSigHowMuch.SelectedIndexChanged += new System.EventHandler(this.cbxSigHowMuch_SelectedIndexChanged);
            // 
            // cbxSigOften
            // 
            this.cbxSigOften.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.cbxSigOften.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSigOften.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxSigOften.ForeColor = System.Drawing.Color.White;
            this.cbxSigOften.FormattingEnabled = true;
            this.cbxSigOften.Location = new System.Drawing.Point(260, 113);
            this.cbxSigOften.Name = "cbxSigOften";
            this.cbxSigOften.Size = new System.Drawing.Size(110, 25);
            this.cbxSigOften.TabIndex = 35;
            this.cbxSigOften.SelectedIndexChanged += new System.EventHandler(this.cbxSigOften_SelectedIndexChanged);
            // 
            // cbxSigWhen
            // 
            this.cbxSigWhen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.cbxSigWhen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSigWhen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxSigWhen.ForeColor = System.Drawing.Color.White;
            this.cbxSigWhen.FormattingEnabled = true;
            this.cbxSigWhen.Location = new System.Drawing.Point(376, 113);
            this.cbxSigWhen.Name = "cbxSigWhen";
            this.cbxSigWhen.Size = new System.Drawing.Size(110, 25);
            this.cbxSigWhen.TabIndex = 36;
            this.cbxSigWhen.SelectedIndexChanged += new System.EventHandler(this.cbxSigWhen_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Medication  Sig /Addendum";
            // 
            // btnAssignMedication
            // 
            this.btnAssignMedication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAssignMedication.FlatAppearance.BorderSize = 0;
            this.btnAssignMedication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignMedication.ForeColor = System.Drawing.Color.White;
            this.btnAssignMedication.Location = new System.Drawing.Point(123, 279);
            this.btnAssignMedication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssignMedication.Name = "btnAssignMedication";
            this.btnAssignMedication.Size = new System.Drawing.Size(245, 33);
            this.btnAssignMedication.TabIndex = 44;
            this.btnAssignMedication.Text = " Assign to Medication and Add to Dispense Cart";
            this.btnAssignMedication.UseVisualStyleBackColor = false;
            this.btnAssignMedication.Click += new System.EventHandler(this.btnAssignMedication_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name of Medication";
            // 
            // lblMedicationDetails
            // 
            this.lblMedicationDetails.AutoSize = true;
            this.lblMedicationDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.lblMedicationDetails.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblMedicationDetails.ForeColor = System.Drawing.Color.White;
            this.lblMedicationDetails.Location = new System.Drawing.Point(262, 43);
            this.lblMedicationDetails.Name = "lblMedicationDetails";
            this.lblMedicationDetails.Size = new System.Drawing.Size(20, 17);
            this.lblMedicationDetails.TabIndex = 31;
            this.lblMedicationDetails.Text = "...";
            // 
            // cbxDaw
            // 
            this.cbxDaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.cbxDaw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDaw.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxDaw.ForeColor = System.Drawing.Color.White;
            this.cbxDaw.FormattingEnabled = true;
            this.cbxDaw.Location = new System.Drawing.Point(144, 210);
            this.cbxDaw.Name = "cbxDaw";
            this.cbxDaw.Size = new System.Drawing.Size(110, 25);
            this.cbxDaw.TabIndex = 34;
            this.cbxDaw.SelectedIndexChanged += new System.EventHandler(this.cbxDaw_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(97, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "DAW";
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
            this.txtSigQty.Location = new System.Drawing.Point(93, 113);
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
            this.txtSigQty.TabIndex = 42;
            this.txtSigQty.UseSelectable = true;
            this.txtSigQty.WaterMark = "Qty";
            this.txtSigQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSigQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSigQty.Click += new System.EventHandler(this.txtSigQty_Click);
            // 
            // lblDaw
            // 
            this.lblDaw.AutoSize = true;
            this.lblDaw.BackColor = System.Drawing.Color.White;
            this.lblDaw.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDaw.Location = new System.Drawing.Point(288, 213);
            this.lblDaw.Name = "lblDaw";
            this.lblDaw.Size = new System.Drawing.Size(17, 17);
            this.lblDaw.TabIndex = 38;
            this.lblDaw.Text = "...";
            // 
            // txtDispense
            // 
            // 
            // 
            // 
            this.txtDispense.CustomButton.Image = null;
            this.txtDispense.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.txtDispense.CustomButton.Name = "";
            this.txtDispense.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDispense.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDispense.CustomButton.TabIndex = 1;
            this.txtDispense.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDispense.CustomButton.UseSelectable = true;
            this.txtDispense.CustomButton.Visible = false;
            this.txtDispense.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtDispense.Lines = new string[0];
            this.txtDispense.Location = new System.Drawing.Point(165, 247);
            this.txtDispense.MaxLength = 32767;
            this.txtDispense.Name = "txtDispense";
            this.txtDispense.PasswordChar = '\0';
            this.txtDispense.PromptText = "Dispense Qty";
            this.txtDispense.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDispense.SelectedText = "";
            this.txtDispense.SelectionLength = 0;
            this.txtDispense.SelectionStart = 0;
            this.txtDispense.ShortcutsEnabled = true;
            this.txtDispense.Size = new System.Drawing.Size(89, 25);
            this.txtDispense.TabIndex = 42;
            this.txtDispense.UseSelectable = true;
            this.txtDispense.WaterMark = "Dispense Qty";
            this.txtDispense.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDispense.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDispense.Click += new System.EventHandler(this.txtSigQty_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Dispense";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(97, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Specify Refill";
            // 
            // txtRefill
            // 
            // 
            // 
            // 
            this.txtRefill.CustomButton.Image = null;
            this.txtRefill.CustomButton.Location = new System.Drawing.Point(43, 1);
            this.txtRefill.CustomButton.Name = "";
            this.txtRefill.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRefill.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRefill.CustomButton.TabIndex = 1;
            this.txtRefill.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRefill.CustomButton.UseSelectable = true;
            this.txtRefill.CustomButton.Visible = false;
            this.txtRefill.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtRefill.Lines = new string[0];
            this.txtRefill.Location = new System.Drawing.Point(187, 278);
            this.txtRefill.MaxLength = 32767;
            this.txtRefill.Name = "txtRefill";
            this.txtRefill.PasswordChar = '\0';
            this.txtRefill.PromptText = "Refill";
            this.txtRefill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRefill.SelectedText = "";
            this.txtRefill.SelectionLength = 0;
            this.txtRefill.SelectionStart = 0;
            this.txtRefill.ShortcutsEnabled = true;
            this.txtRefill.Size = new System.Drawing.Size(67, 25);
            this.txtRefill.TabIndex = 42;
            this.txtRefill.UseSelectable = true;
            this.txtRefill.WaterMark = "Refill";
            this.txtRefill.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRefill.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRefill.Click += new System.EventHandler(this.txtSigQty_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 25);
            this.panel1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Step 2:  Specify Sig and Dispense Parameters";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAssignMedication);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblStaffID);
            this.panel2.Controls.Add(this.lblPatientID);
            this.panel2.Controls.Add(this.lblDrugPCode);
            this.panel2.Controls.Add(this.lblPresID);
            this.panel2.Location = new System.Drawing.Point(2, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 331);
            this.panel2.TabIndex = 41;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.lblStaffID.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblStaffID.ForeColor = System.Drawing.Color.White;
            this.lblStaffID.Location = new System.Drawing.Point(564, 288);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(20, 17);
            this.lblStaffID.TabIndex = 31;
            this.lblStaffID.Text = "...";
            this.lblStaffID.Visible = false;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.lblPatientID.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPatientID.ForeColor = System.Drawing.Color.White;
            this.lblPatientID.Location = new System.Drawing.Point(564, 249);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(20, 17);
            this.lblPatientID.TabIndex = 31;
            this.lblPatientID.Text = "...";
            this.lblPatientID.Visible = false;
            // 
            // lblPresID
            // 
            this.lblPresID.AutoSize = true;
            this.lblPresID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.lblPresID.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPresID.ForeColor = System.Drawing.Color.White;
            this.lblPresID.Location = new System.Drawing.Point(564, 222);
            this.lblPresID.Name = "lblPresID";
            this.lblPresID.Size = new System.Drawing.Size(20, 17);
            this.lblPresID.TabIndex = 31;
            this.lblPresID.Text = "...";
            this.lblPresID.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::KDMEDISP.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(735, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 18);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 45;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDrugPCode
            // 
            this.lblDrugPCode.AutoSize = true;
            this.lblDrugPCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.lblDrugPCode.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblDrugPCode.ForeColor = System.Drawing.Color.White;
            this.lblDrugPCode.Location = new System.Drawing.Point(564, 185);
            this.lblDrugPCode.Name = "lblDrugPCode";
            this.lblDrugPCode.Size = new System.Drawing.Size(20, 17);
            this.lblDrugPCode.TabIndex = 31;
            this.lblDrugPCode.Text = "...";
            this.lblDrugPCode.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(399, 279);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(245, 33);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update Medication";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmAddSig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 367);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSigTrans);
            this.Controls.Add(this.txtRefill);
            this.Controls.Add(this.txtDispense);
            this.Controls.Add(this.txtSigQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDaw);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxSigHow);
            this.Controls.Add(this.cbxDaw);
            this.Controls.Add(this.cbxSigHowMuch);
            this.Controls.Add(this.cbxSigOften);
            this.Controls.Add(this.cbxSigWhen);
            this.Controls.Add(this.lblMedicationDetails);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddSig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddSig";
            this.Load += new System.EventHandler(this.frmAddSig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroTextBox txtSigTrans;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbxSigHow;
        public System.Windows.Forms.ComboBox cbxSigHowMuch;
        public System.Windows.Forms.ComboBox cbxSigOften;
        public System.Windows.Forms.ComboBox cbxSigWhen;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnAssignMedication;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblMedicationDetails;
        public System.Windows.Forms.ComboBox cbxDaw;
        public System.Windows.Forms.Label label3;
        public MetroFramework.Controls.MetroTextBox txtSigQty;
        public System.Windows.Forms.Label lblDaw;
        public MetroFramework.Controls.MetroTextBox txtDispense;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public MetroFramework.Controls.MetroTextBox txtRefill;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExit;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblStaffID;
        public System.Windows.Forms.Label lblPatientID;
        public System.Windows.Forms.Label lblPresID;
        public System.Windows.Forms.Label lblDrugPCode;
        public System.Windows.Forms.Button btnUpdate;
    }
}