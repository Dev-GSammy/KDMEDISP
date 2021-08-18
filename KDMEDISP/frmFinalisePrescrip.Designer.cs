namespace KDMEDISP
{
    partial class frmFinalisePrescrip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalisePrescrip));
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrescriptionID = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPatientFullName = new System.Windows.Forms.Label();
            this.lblPatientAdd = new System.Windows.Forms.Label();
            this.lblPatientPh = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvFinalMedication = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPresEmail = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblPrescrPhone = new System.Windows.Forms.Label();
            this.lblPrescriberAdd = new System.Windows.Forms.Label();
            this.lblPrescFullName = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddDrugtoPres = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.bgwPrescription = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnGeneratePresPDF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxAutoOpen = new System.Windows.Forms.PictureBox();
            this.pbxDefaultFolder = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalMedication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAutoOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDefaultFolder)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "E-Prescription Module";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel1.Location = new System.Drawing.Point(90, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 3);
            this.panel1.TabIndex = 61;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(995, 630);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "label2";
            this.lblID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Medications";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(15)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblPrescriptionID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 40);
            this.panel2.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(745, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prescription ID:";
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPrescriptionID.ForeColor = System.Drawing.Color.White;
            this.lblPrescriptionID.Location = new System.Drawing.Point(847, 18);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(20, 17);
            this.lblPrescriptionID.TabIndex = 37;
            this.lblPrescriptionID.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Underline);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(419, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "Patient Details";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(15, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Full Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(588, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "Address:";
            // 
            // lblPatientFullName
            // 
            this.lblPatientFullName.AutoSize = true;
            this.lblPatientFullName.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPatientFullName.Location = new System.Drawing.Point(107, 61);
            this.lblPatientFullName.Name = "lblPatientFullName";
            this.lblPatientFullName.Size = new System.Drawing.Size(20, 17);
            this.lblPatientFullName.TabIndex = 37;
            this.lblPatientFullName.Text = "...";
            // 
            // lblPatientAdd
            // 
            this.lblPatientAdd.AutoSize = true;
            this.lblPatientAdd.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPatientAdd.Location = new System.Drawing.Point(664, 93);
            this.lblPatientAdd.Name = "lblPatientAdd";
            this.lblPatientAdd.Size = new System.Drawing.Size(20, 17);
            this.lblPatientAdd.TabIndex = 37;
            this.lblPatientAdd.Text = "...";
            // 
            // lblPatientPh
            // 
            this.lblPatientPh.AutoSize = true;
            this.lblPatientPh.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPatientPh.Location = new System.Drawing.Point(451, 61);
            this.lblPatientPh.Name = "lblPatientPh";
            this.lblPatientPh.Size = new System.Drawing.Size(20, 17);
            this.lblPatientPh.TabIndex = 37;
            this.lblPatientPh.Text = "...";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(394, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 17);
            this.label21.TabIndex = 37;
            this.label21.Text = "Phone:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(394, 93);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 17);
            this.label23.TabIndex = 37;
            this.label23.Text = "Email:";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.d.Location = new System.Drawing.Point(451, 93);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(20, 17);
            this.d.TabIndex = 37;
            this.d.Text = "...";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(588, 61);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 17);
            this.label25.TabIndex = 37;
            this.label25.Text = "Patient ID:";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPatientID.Location = new System.Drawing.Point(664, 61);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(20, 17);
            this.lblPatientID.TabIndex = 37;
            this.lblPatientID.Text = "...";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvFinalMedication);
            this.panel5.Location = new System.Drawing.Point(19, 155);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1005, 174);
            this.panel5.TabIndex = 77;
            // 
            // dgvFinalMedication
            // 
            this.dgvFinalMedication.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Thistle;
            this.dgvFinalMedication.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFinalMedication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinalMedication.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinalMedication.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvFinalMedication.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinalMedication.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFinalMedication.ColumnHeadersHeight = 30;
            this.dgvFinalMedication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFinalMedication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.pcode,
            this.medication,
            this.sig,
            this.dispense,
            this.refill,
            this.daw,
            this.Edit,
            this.Delete});
            this.dgvFinalMedication.EnableHeadersVisualStyles = false;
            this.dgvFinalMedication.Location = new System.Drawing.Point(0, 0);
            this.dgvFinalMedication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFinalMedication.Name = "dgvFinalMedication";
            this.dgvFinalMedication.RowHeadersVisible = false;
            this.dgvFinalMedication.Size = new System.Drawing.Size(1005, 171);
            this.dgvFinalMedication.TabIndex = 11;
            this.dgvFinalMedication.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinalMedication_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.Width = 37;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // pcode
            // 
            this.pcode.HeaderText = "pcode";
            this.pcode.Name = "pcode";
            this.pcode.Visible = false;
            // 
            // medication
            // 
            this.medication.HeaderText = "Medication";
            this.medication.Name = "medication";
            // 
            // sig
            // 
            this.sig.HeaderText = "Sig";
            this.sig.Name = "sig";
            // 
            // dispense
            // 
            this.dispense.HeaderText = "Dispense";
            this.dispense.Name = "dispense";
            // 
            // refill
            // 
            this.refill.HeaderText = "Refill";
            this.refill.Name = "refill";
            // 
            // daw
            // 
            this.daw.HeaderText = "DAW";
            this.daw.Name = "daw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(654, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Prescriber Details";
            // 
            // lblPresEmail
            // 
            this.lblPresEmail.AutoSize = true;
            this.lblPresEmail.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPresEmail.Location = new System.Drawing.Point(846, 399);
            this.lblPresEmail.Name = "lblPresEmail";
            this.lblPresEmail.Size = new System.Drawing.Size(20, 17);
            this.lblPresEmail.TabIndex = 79;
            this.lblPresEmail.Text = "...";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblStaffID.Location = new System.Drawing.Point(654, 382);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(20, 17);
            this.lblStaffID.TabIndex = 80;
            this.lblStaffID.Text = "...";
            // 
            // lblPrescrPhone
            // 
            this.lblPrescrPhone.AutoSize = true;
            this.lblPrescrPhone.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPrescrPhone.Location = new System.Drawing.Point(654, 399);
            this.lblPrescrPhone.Name = "lblPrescrPhone";
            this.lblPrescrPhone.Size = new System.Drawing.Size(20, 17);
            this.lblPrescrPhone.TabIndex = 81;
            this.lblPrescrPhone.Text = "...";
            // 
            // lblPrescriberAdd
            // 
            this.lblPrescriberAdd.AutoSize = true;
            this.lblPrescriberAdd.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPrescriberAdd.Location = new System.Drawing.Point(654, 419);
            this.lblPrescriberAdd.Name = "lblPrescriberAdd";
            this.lblPrescriberAdd.Size = new System.Drawing.Size(20, 17);
            this.lblPrescriberAdd.TabIndex = 82;
            this.lblPrescriberAdd.Text = "...";
            // 
            // lblPrescFullName
            // 
            this.lblPrescFullName.AutoSize = true;
            this.lblPrescFullName.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblPrescFullName.Location = new System.Drawing.Point(654, 365);
            this.lblPrescFullName.Name = "lblPrescFullName";
            this.lblPrescFullName.Size = new System.Drawing.Size(20, 17);
            this.lblPrescFullName.TabIndex = 83;
            this.lblPrescFullName.Text = "...";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(527, 419);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 17);
            this.label27.TabIndex = 84;
            this.label27.Text = "Address:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(794, 399);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 17);
            this.label28.TabIndex = 85;
            this.label28.Text = "Email:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label30.Location = new System.Drawing.Point(527, 383);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(124, 17);
            this.label30.TabIndex = 87;
            this.label30.Text = "StaffID/License ID:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label31.Location = new System.Drawing.Point(527, 400);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(51, 17);
            this.label31.TabIndex = 88;
            this.label31.Text = "Phone:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label32.Location = new System.Drawing.Point(527, 365);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(75, 17);
            this.label32.TabIndex = 89;
            this.label32.Text = "Full Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(14, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "Prescriber";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel3.Location = new System.Drawing.Point(83, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 3);
            this.panel3.TabIndex = 62;
            // 
            // btnAddDrugtoPres
            // 
            this.btnAddDrugtoPres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAddDrugtoPres.FlatAppearance.BorderSize = 0;
            this.btnAddDrugtoPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDrugtoPres.ForeColor = System.Drawing.Color.White;
            this.btnAddDrugtoPres.Location = new System.Drawing.Point(735, 123);
            this.btnAddDrugtoPres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddDrugtoPres.Name = "btnAddDrugtoPres";
            this.btnAddDrugtoPres.Size = new System.Drawing.Size(132, 31);
            this.btnAddDrugtoPres.TabIndex = 34;
            this.btnAddDrugtoPres.Text = "Add Drug";
            this.btnAddDrugtoPres.UseVisualStyleBackColor = false;
            this.btnAddDrugtoPres.ClientSizeChanged += new System.EventHandler(this.btnAddDrugtoPres_ClientSizeChanged);
            this.btnAddDrugtoPres.Click += new System.EventHandler(this.btnAddDrugtoPres_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Date of Birth:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblDob.Location = new System.Drawing.Point(107, 86);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(20, 17);
            this.lblDob.TabIndex = 37;
            this.lblDob.Text = "...";
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.Location = new System.Drawing.Point(918, 123);
            this.btnClearCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(111, 31);
            this.btnClearCart.TabIndex = 34;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // bgwPrescription
            // 
            this.bgwPrescription.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwPrescription_RunWorkerCompleted);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 5;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // btnGeneratePresPDF
            // 
            this.btnGeneratePresPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnGeneratePresPDF.FlatAppearance.BorderSize = 0;
            this.btnGeneratePresPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePresPDF.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePresPDF.Image = global::KDMEDISP.Properties.Resources.ExportPdf_30px;
            this.btnGeneratePresPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneratePresPDF.Location = new System.Drawing.Point(247, 8);
            this.btnGeneratePresPDF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGeneratePresPDF.Name = "btnGeneratePresPDF";
            this.btnGeneratePresPDF.Size = new System.Drawing.Size(154, 44);
            this.btnGeneratePresPDF.TabIndex = 34;
            this.btnGeneratePresPDF.Text = "Generate PDF";
            this.btnGeneratePresPDF.UseVisualStyleBackColor = false;
            this.btnGeneratePresPDF.Click += new System.EventHandler(this.btnGeneratePresPDF_Click);
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
            // pbxAutoOpen
            // 
            this.pbxAutoOpen.Image = global::KDMEDISP.Properties.Resources.Toggle_Off_20px;
            this.pbxAutoOpen.Location = new System.Drawing.Point(136, 20);
            this.pbxAutoOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxAutoOpen.Name = "pbxAutoOpen";
            this.pbxAutoOpen.Size = new System.Drawing.Size(73, 27);
            this.pbxAutoOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAutoOpen.TabIndex = 96;
            this.pbxAutoOpen.TabStop = false;
            this.pbxAutoOpen.Click += new System.EventHandler(this.pbxAutoOpen_Click);
            // 
            // pbxDefaultFolder
            // 
            this.pbxDefaultFolder.Image = global::KDMEDISP.Properties.Resources.Toggle_Off_20px;
            this.pbxDefaultFolder.Location = new System.Drawing.Point(16, 20);
            this.pbxDefaultFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxDefaultFolder.Name = "pbxDefaultFolder";
            this.pbxDefaultFolder.Size = new System.Drawing.Size(73, 27);
            this.pbxDefaultFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDefaultFolder.TabIndex = 97;
            this.pbxDefaultFolder.TabStop = false;
            this.pbxDefaultFolder.Click += new System.EventHandler(this.pbxDefaultFolder_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(130, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "Auto Open ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 95;
            this.label9.Text = "Default Folder";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel4.Controls.Add(this.pbxDefaultFolder);
            this.panel4.Controls.Add(this.pbxAutoOpen);
            this.panel4.Controls.Add(this.btnGeneratePresPDF);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(511, 449);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 59);
            this.panel4.TabIndex = 98;
            // 
            // frmFinalisePrescrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 542);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblPresEmail);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.lblPrescrPhone);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblPatientAdd);
            this.Controls.Add(this.lblPrescriberAdd);
            this.Controls.Add(this.lblPrescFullName);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnAddDrugtoPres);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.d);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblPatientPh);
            this.Controls.Add(this.lblPatientFullName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFinalisePrescrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFinalisePrescrip";
            this.Load += new System.EventHandler(this.frmFinalisePrescrip_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalMedication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAutoOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDefaultFolder)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Button btnGeneratePresPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnAddDrugtoPres;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        public System.Windows.Forms.DataGridView dgvFinalMedication;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblPrescriptionID;
        public System.Windows.Forms.Label lblPatientFullName;
        public System.Windows.Forms.Label lblPatientAdd;
        public System.Windows.Forms.Label lblPatientPh;
        public System.Windows.Forms.Label d;
        public System.Windows.Forms.Label lblPatientID;
        public System.Windows.Forms.Label lblPresEmail;
        public System.Windows.Forms.Label lblStaffID;
        public System.Windows.Forms.Label lblPrescrPhone;
        public System.Windows.Forms.Label lblPrescriberAdd;
        public System.Windows.Forms.Label lblPrescFullName;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn medication;
        private System.Windows.Forms.DataGridViewTextBoxColumn sig;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispense;
        private System.Windows.Forms.DataGridViewTextBoxColumn refill;
        private System.Windows.Forms.DataGridViewTextBoxColumn daw;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        public System.Windows.Forms.Button btnClearCart;
        private System.ComponentModel.BackgroundWorker bgwPrescription;
        private System.Windows.Forms.PictureBox pbxAutoOpen;
        private System.Windows.Forms.PictureBox pbxDefaultFolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
    }
}