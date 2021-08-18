namespace KDMEDISP
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pbxStockLevel = new System.Windows.Forms.PictureBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnminMaxClose = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnManufacturer = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnNewPres = new System.Windows.Forms.Button();
            this.btnNewDispense = new System.Windows.Forms.Button();
            this.btnDrugs = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStockLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnminMaxClose.SuspendLayout();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(348, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 0);
            this.panel1.TabIndex = 0;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(15)))), ((int)(((byte)(41)))));
            this.pnTop.Controls.Add(this.pbxStockLevel);
            this.pnTop.Controls.Add(this.btnRecord);
            this.pnTop.Controls.Add(this.pbxLogo);
            this.pnTop.Controls.Add(this.pnminMaxClose);
            this.pnTop.Controls.Add(this.lblLowStock);
            this.pnTop.Controls.Add(this.label2);
            this.pnTop.Controls.Add(this.lblDate);
            this.pnTop.Controls.Add(this.lblTime);
            this.pnTop.Controls.Add(this.label5);
            this.pnTop.Controls.Add(this.label6);
            this.pnTop.Controls.Add(this.label66);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1199, 55);
            this.pnTop.TabIndex = 1;
            this.pnTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTop_Paint);
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            // 
            // pbxStockLevel
            // 
            this.pbxStockLevel.Image = ((System.Drawing.Image)(resources.GetObject("pbxStockLevel.Image")));
            this.pbxStockLevel.Location = new System.Drawing.Point(1021, 2);
            this.pbxStockLevel.Name = "pbxStockLevel";
            this.pbxStockLevel.Size = new System.Drawing.Size(53, 34);
            this.pbxStockLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxStockLevel.TabIndex = 1;
            this.pbxStockLevel.TabStop = false;
            this.pbxStockLevel.Visible = false;
            // 
            // btnRecord
            // 
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.Location = new System.Drawing.Point(746, 13);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(138, 29);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "     Records";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Visible = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(3, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(63, 50);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 4;
            this.pbxLogo.TabStop = false;
            // 
            // pnminMaxClose
            // 
            this.pnminMaxClose.Controls.Add(this.btnMin);
            this.pnminMaxClose.Controls.Add(this.btnExit);
            this.pnminMaxClose.Location = new System.Drawing.Point(1122, 8);
            this.pnminMaxClose.Name = "pnminMaxClose";
            this.pnminMaxClose.Size = new System.Drawing.Size(61, 29);
            this.pnminMaxClose.TabIndex = 26;
            // 
            // btnMin
            // 
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(3, 7);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 23);
            this.btnMin.TabIndex = 0;
            this.btnMin.Text = "--";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(34, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Perpetua", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLowStock.ForeColor = System.Drawing.Color.White;
            this.lblLowStock.Location = new System.Drawing.Point(1018, 38);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(76, 13);
            this.lblLowStock.TabIndex = 28;
            this.lblLowStock.Text = "Low Stock Alert!";
            this.lblLowStock.Visible = false;
            this.lblLowStock.Click += new System.EventHandler(this.label66_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(145, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dispensing and Inventory Suite";
            this.label2.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(707, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(20, 16);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "...";
            this.lblDate.Click += new System.EventHandler(this.label66_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Perpetua", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(702, 6);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(25, 23);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "...";
            this.lblTime.Click += new System.EventHandler(this.label66_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(486, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Rx";
            this.label5.Click += new System.EventHandler(this.label66_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(517, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Solution [premium]";
            this.label6.Click += new System.EventHandler(this.label66_Click);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label66.ForeColor = System.Drawing.Color.White;
            this.label66.Location = new System.Drawing.Point(424, 33);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(62, 16);
            this.label66.TabIndex = 28;
            this.label66.Text = "Complete ";
            this.label66.Click += new System.EventHandler(this.label66_Click);
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(15)))), ((int)(((byte)(41)))));
            this.pnLeft.Controls.Add(this.panel4);
            this.pnLeft.Controls.Add(this.panel2);
            this.pnLeft.Controls.Add(this.btnSuppliers);
            this.pnLeft.Controls.Add(this.btnManufacturer);
            this.pnLeft.Controls.Add(this.btnStock);
            this.pnLeft.Controls.Add(this.btnPatient);
            this.pnLeft.Controls.Add(this.pictureBox2);
            this.pnLeft.Controls.Add(this.label11);
            this.pnLeft.Controls.Add(this.label1);
            this.pnLeft.Controls.Add(this.lblUsername);
            this.pnLeft.Controls.Add(this.btnLogout);
            this.pnLeft.Controls.Add(this.btnSettings);
            this.pnLeft.Controls.Add(this.btnDoctors);
            this.pnLeft.Controls.Add(this.btnNewPres);
            this.pnLeft.Controls.Add(this.btnNewDispense);
            this.pnLeft.Controls.Add(this.btnDrugs);
            this.pnLeft.Controls.Add(this.btnHome);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.ForeColor = System.Drawing.Color.White;
            this.pnLeft.Location = new System.Drawing.Point(0, 55);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(162, 545);
            this.pnLeft.TabIndex = 2;
            this.pnLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.p);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(6, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 1);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 5);
            this.panel2.TabIndex = 0;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("btnSuppliers.Image")));
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 400);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(162, 29);
            this.btnSuppliers.TabIndex = 0;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnManufacturer
            // 
            this.btnManufacturer.FlatAppearance.BorderSize = 0;
            this.btnManufacturer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnManufacturer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManufacturer.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnManufacturer.ForeColor = System.Drawing.Color.White;
            this.btnManufacturer.Image = global::KDMEDISP.Properties.Resources.Manufacturing_25px;
            this.btnManufacturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManufacturer.Location = new System.Drawing.Point(6, 365);
            this.btnManufacturer.Name = "btnManufacturer";
            this.btnManufacturer.Size = new System.Drawing.Size(156, 29);
            this.btnManufacturer.TabIndex = 0;
            this.btnManufacturer.Text = "    Manufacturer";
            this.btnManufacturer.UseVisualStyleBackColor = true;
            this.btnManufacturer.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnStock
            // 
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 330);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(138, 29);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "       Inventory";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnPatient.Image")));
            this.btnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.Location = new System.Drawing.Point(4, 259);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(138, 29);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "           Patients";
            this.btnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(5, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Welcome ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administrator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(87, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(20, 17);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "...";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 518);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 27);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "     Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(6, 435);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(138, 29);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "  Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.FlatAppearance.BorderSize = 0;
            this.btnDoctors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDoctors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctors.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnDoctors.ForeColor = System.Drawing.Color.White;
            this.btnDoctors.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctors.Image")));
            this.btnDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctors.Location = new System.Drawing.Point(0, 295);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(144, 29);
            this.btnDoctors.TabIndex = 0;
            this.btnDoctors.Text = "   Doctors";
            this.btnDoctors.UseVisualStyleBackColor = true;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnNewPres
            // 
            this.btnNewPres.FlatAppearance.BorderSize = 0;
            this.btnNewPres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNewPres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNewPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPres.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnNewPres.ForeColor = System.Drawing.Color.White;
            this.btnNewPres.Image = ((System.Drawing.Image)(resources.GetObject("btnNewPres.Image")));
            this.btnNewPres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPres.Location = new System.Drawing.Point(6, 159);
            this.btnNewPres.Name = "btnNewPres";
            this.btnNewPres.Size = new System.Drawing.Size(157, 29);
            this.btnNewPres.TabIndex = 0;
            this.btnNewPres.Text = "          New Prescription";
            this.btnNewPres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPres.UseVisualStyleBackColor = true;
            this.btnNewPres.Click += new System.EventHandler(this.btnNewPres_Click);
            // 
            // btnNewDispense
            // 
            this.btnNewDispense.FlatAppearance.BorderSize = 0;
            this.btnNewDispense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNewDispense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNewDispense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDispense.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnNewDispense.ForeColor = System.Drawing.Color.White;
            this.btnNewDispense.Image = global::KDMEDISP.Properties.Resources.Sell_32px;
            this.btnNewDispense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDispense.Location = new System.Drawing.Point(3, 193);
            this.btnNewDispense.Name = "btnNewDispense";
            this.btnNewDispense.Size = new System.Drawing.Size(160, 29);
            this.btnNewDispense.TabIndex = 0;
            this.btnNewDispense.Text = "           New Dispense";
            this.btnNewDispense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDispense.UseVisualStyleBackColor = true;
            this.btnNewDispense.Click += new System.EventHandler(this.btnNewDispense_Click);
            // 
            // btnDrugs
            // 
            this.btnDrugs.FlatAppearance.BorderSize = 0;
            this.btnDrugs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDrugs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrugs.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnDrugs.ForeColor = System.Drawing.Color.White;
            this.btnDrugs.Image = ((System.Drawing.Image)(resources.GetObject("btnDrugs.Image")));
            this.btnDrugs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrugs.Location = new System.Drawing.Point(0, 226);
            this.btnDrugs.Name = "btnDrugs";
            this.btnDrugs.Size = new System.Drawing.Size(160, 29);
            this.btnDrugs.TabIndex = 0;
            this.btnDrugs.Text = "           Drugs/Supplies";
            this.btnDrugs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrugs.UseVisualStyleBackColor = true;
            this.btnDrugs.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(8, 122);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(154, 29);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "          Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnDashboard
            // 
            this.pnDashboard.BackColor = System.Drawing.Color.Gray;
            this.pnDashboard.Controls.Add(this.pictureBox1);
            this.pnDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDashboard.Location = new System.Drawing.Point(162, 55);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(1037, 545);
            this.pnDashboard.TabIndex = 3;
            this.pnDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDashboard_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(423, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(162, 573);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 27);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(529, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 16);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(479, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 16);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(423, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 16);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(369, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(46, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(810, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Copyright \"Kadosh Mechatronics\" 2020 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Licensed to \"College of Health Tech Akure\" 2020 ";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnDashboard);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4W";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStockLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnminMaxClose.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnManufacturer;
        private System.Windows.Forms.Button btnDrugs;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnminMaxClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnNewPres;
        private System.Windows.Forms.PictureBox pbxStockLevel;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewDispense;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}