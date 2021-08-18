namespace KDMEDISP
{
    partial class frmPatientList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextofkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextofkinphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblallergies = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnok = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.lblNextofKinPhone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPatientFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbxPatientImg = new System.Windows.Forms.PictureBox();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPatientImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnNewPatient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 45);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "PATIENTS ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            this.dgvPatientList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPatientList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatientList.ColumnHeadersHeight = 30;
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.title,
            this.firstname,
            this.lastname,
            this.othername,
            this.phone,
            this.nextofkin,
            this.nextofkinphone,
            this.dob,
            this.patientID,
            this.allergies,
            this.address,
            this.Edit,
            this.Delete});
            this.dgvPatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientList.EnableHeadersVisualStyles = false;
            this.dgvPatientList.Location = new System.Drawing.Point(0, 0);
            this.dgvPatientList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.RowHeadersVisible = false;
            this.dgvPatientList.Size = new System.Drawing.Size(1047, 399);
            this.dgvPatientList.TabIndex = 10;
            this.dgvPatientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientList_CellContentClick);
            this.dgvPatientList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientList_RowEnter);
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
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 53;
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // othername
            // 
            this.othername.HeaderText = "Other Name";
            this.othername.Name = "othername";
            this.othername.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone No";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // nextofkin
            // 
            this.nextofkin.HeaderText = "Next of Kin";
            this.nextofkin.Name = "nextofkin";
            this.nextofkin.ReadOnly = true;
            // 
            // nextofkinphone
            // 
            this.nextofkinphone.HeaderText = "Phone No[Next of Kin]";
            this.nextofkinphone.Name = "nextofkinphone";
            this.nextofkinphone.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.HeaderText = "Date of Birth";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // patientID
            // 
            this.patientID.HeaderText = "patientID";
            this.patientID.Name = "patientID";
            this.patientID.Visible = false;
            // 
            // allergies
            // 
            this.allergies.HeaderText = "allergies";
            this.allergies.Name = "allergies";
            this.allergies.Visible = false;
            // 
            // address
            // 
            this.address.HeaderText = "address";
            this.address.Name = "address";
            this.address.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPatientList);
            this.panel2.Location = new System.Drawing.Point(3, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 399);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblallergies
            // 
            this.lblallergies.AutoSize = true;
            this.lblallergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblallergies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblallergies.Location = new System.Drawing.Point(248, 106);
            this.lblallergies.Name = "lblallergies";
            this.lblallergies.Size = new System.Drawing.Size(19, 13);
            this.lblallergies.TabIndex = 23;
            this.lblallergies.Text = "...";
            this.lblallergies.Click += new System.EventHandler(this.lblallergies_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl.Location = new System.Drawing.Point(193, 106);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(55, 13);
            this.lbl.TabIndex = 24;
            this.lbl.Text = "Allergies";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAdress.Location = new System.Drawing.Point(92, 85);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(19, 13);
            this.lblAdress.TabIndex = 25;
            this.lblAdress.Text = "...";
            this.lblAdress.Click += new System.EventHandler(this.lblAdress_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblnok
            // 
            this.lblnok.AutoSize = true;
            this.lblnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblnok.Location = new System.Drawing.Point(742, 90);
            this.lblnok.Name = "lblnok";
            this.lblnok.Size = new System.Drawing.Size(19, 13);
            this.lblnok.TabIndex = 27;
            this.lblnok.Text = "...";
            this.lblnok.Click += new System.EventHandler(this.lblnok_Click);
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblx.Location = new System.Drawing.Point(670, 90);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(70, 13);
            this.lblx.TabIndex = 28;
            this.lblx.Text = "Next of Kin";
            this.lblx.Click += new System.EventHandler(this.lblx_Click);
            // 
            // lblNextofKinPhone
            // 
            this.lblNextofKinPhone.AutoSize = true;
            this.lblNextofKinPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextofKinPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNextofKinPhone.Location = new System.Drawing.Point(742, 111);
            this.lblNextofKinPhone.Name = "lblNextofKinPhone";
            this.lblNextofKinPhone.Size = new System.Drawing.Size(19, 13);
            this.lblNextofKinPhone.TabIndex = 30;
            this.lblNextofKinPhone.Text = "...";
            this.lblNextofKinPhone.Click += new System.EventHandler(this.lblNextofKinPhone_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(670, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Phone";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblPatientFullName
            // 
            this.lblPatientFullName.AutoSize = true;
            this.lblPatientFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPatientFullName.Location = new System.Drawing.Point(92, 69);
            this.lblPatientFullName.Name = "lblPatientFullName";
            this.lblPatientFullName.Size = new System.Drawing.Size(19, 13);
            this.lblPatientFullName.TabIndex = 34;
            this.lblPatientFullName.Text = "...";
            this.lblPatientFullName.Click += new System.EventHandler(this.lblPatientFullName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Patient Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPhone.Location = new System.Drawing.Point(92, 106);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(19, 13);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "...";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(705, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Next of Kin";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(202, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Patient  Info";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(307, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Email:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(351, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "...";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            // pbxPatientImg
            // 
            this.pbxPatientImg.Image = global::KDMEDISP.Properties.Resources.kdmedlogosm1;
            this.pbxPatientImg.Location = new System.Drawing.Point(484, 45);
            this.pbxPatientImg.Name = "pbxPatientImg";
            this.pbxPatientImg.Size = new System.Drawing.Size(110, 74);
            this.pbxPatientImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPatientImg.TabIndex = 22;
            this.pbxPatientImg.TabStop = false;
            this.pbxPatientImg.Click += new System.EventHandler(this.pbxPatientImg_Click);
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
            // btnNewPatient
            // 
            this.btnNewPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.btnNewPatient.FlatAppearance.BorderSize = 0;
            this.btnNewPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNewPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPatient.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnNewPatient.ForeColor = System.Drawing.Color.White;
            this.btnNewPatient.Image = global::KDMEDISP.Properties.Resources.newpatient22;
            this.btnNewPatient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewPatient.Location = new System.Drawing.Point(949, 0);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(86, 39);
            this.btnNewPatient.TabIndex = 37;
            this.btnNewPatient.Text = "New Patient";
            this.btnNewPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewPatient.UseVisualStyleBackColor = false;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // frmPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 500);
            this.Controls.Add(this.lblallergies);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblnok);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.lblNextofKinPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPatientFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxPatientImg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPatientList";
            this.Load += new System.EventHandler(this.frmPatientList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPatientImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView dgvPatientList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblallergies;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnok;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lblNextofKinPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPatientFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxPatientImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn othername;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextofkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextofkinphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergies;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNewPatient;
    }
}