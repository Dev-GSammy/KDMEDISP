namespace KDMEDISP
{
    partial class frmBarcode
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnminMaxClose = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label66 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.txtProdDesc = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchBar = new MetroFramework.Controls.MetroTextBox();
            this.cboBarcodeMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBarcode = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.print = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbxQr = new System.Windows.Forms.PictureBox();
            this.pbxBarcode = new System.Windows.Forms.PictureBox();
            this.btnGenerateRandom = new System.Windows.Forms.Button();
            this.btnCreateBar = new System.Windows.Forms.Button();
            this.btnGenerateBarcode = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnminMaxClose.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pnminMaxClose);
            this.panel2.Controls.Add(this.label66);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 59);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KDMEDISP.Properties.Resources.Barcode_Scanner_96px;
            this.pictureBox1.Location = new System.Drawing.Point(266, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnminMaxClose
            // 
            this.pnminMaxClose.Controls.Add(this.btnMin);
            this.pnminMaxClose.Controls.Add(this.btnMax);
            this.pnminMaxClose.Controls.Add(this.btnExit);
            this.pnminMaxClose.Location = new System.Drawing.Point(1073, 0);
            this.pnminMaxClose.Name = "pnminMaxClose";
            this.pnminMaxClose.Size = new System.Drawing.Size(124, 39);
            this.pnminMaxClose.TabIndex = 26;
            // 
            // btnMin
            // 
            this.btnMin.Image = global::KDMEDISP.Properties.Resources.icons8_Minimize_Window_32px_1;
            this.btnMin.Location = new System.Drawing.Point(3, 6);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(34, 22);
            this.btnMin.TabIndex = 0;
            this.btnMin.Text = "--";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            this.btnMax.Image = global::KDMEDISP.Properties.Resources.icons8_Maximize_Window_32px;
            this.btnMax.Location = new System.Drawing.Point(43, 6);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(34, 22);
            this.btnMax.TabIndex = 0;
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(83, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 22);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label66.ForeColor = System.Drawing.Color.White;
            this.label66.Location = new System.Drawing.Point(825, 42);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(265, 16);
            this.label66.TabIndex = 28;
            this.label66.Text = "Complete Business Solution Module [premium]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "BarCode and Qr Code Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 34);
            this.label2.TabIndex = 27;
            this.label2.Text = "KDMEDISP ";
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = null;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(276, 2);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCode.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(25, 261);
            this.txtCode.MaxLength = 50;
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PromptText = "Bar/ Qr Code";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(312, 38);
            this.txtCode.TabIndex = 31;
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMark = "Bar/ Qr Code";
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtCode.Click += new System.EventHandler(this.txtProdDesc_Click);
            // 
            // txtProdDesc
            // 
            // 
            // 
            // 
            this.txtProdDesc.CustomButton.Image = null;
            this.txtProdDesc.CustomButton.Location = new System.Drawing.Point(276, 2);
            this.txtProdDesc.CustomButton.Name = "";
            this.txtProdDesc.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtProdDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProdDesc.CustomButton.TabIndex = 1;
            this.txtProdDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProdDesc.CustomButton.UseSelectable = true;
            this.txtProdDesc.CustomButton.Visible = false;
            this.txtProdDesc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProdDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtProdDesc.Lines = new string[0];
            this.txtProdDesc.Location = new System.Drawing.Point(25, 305);
            this.txtProdDesc.MaxLength = 20;
            this.txtProdDesc.Multiline = true;
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.PasswordChar = '\0';
            this.txtProdDesc.PromptText = "Brand Name of Drug";
            this.txtProdDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProdDesc.SelectedText = "";
            this.txtProdDesc.SelectionLength = 0;
            this.txtProdDesc.SelectionStart = 0;
            this.txtProdDesc.ShortcutsEnabled = true;
            this.txtProdDesc.Size = new System.Drawing.Size(312, 38);
            this.txtProdDesc.TabIndex = 31;
            this.txtProdDesc.UseSelectable = true;
            this.txtProdDesc.WaterMark = "Brand Name of Drug";
            this.txtProdDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProdDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtProdDesc.Click += new System.EventHandler(this.txtProdDesc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchBar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cboBarcodeMode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 60);
            this.panel1.TabIndex = 36;
            // 
            // txtSearchBar
            // 
            // 
            // 
            // 
            this.txtSearchBar.CustomButton.Image = null;
            this.txtSearchBar.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.txtSearchBar.CustomButton.Name = "";
            this.txtSearchBar.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSearchBar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchBar.CustomButton.TabIndex = 1;
            this.txtSearchBar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchBar.CustomButton.UseSelectable = true;
            this.txtSearchBar.CustomButton.Visible = false;
            this.txtSearchBar.DisplayIcon = true;
            this.txtSearchBar.Icon = global::KDMEDISP.Properties.Resources.search;
            this.txtSearchBar.Lines = new string[0];
            this.txtSearchBar.Location = new System.Drawing.Point(864, 11);
            this.txtSearchBar.MaxLength = 32767;
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.PasswordChar = '\0';
            this.txtSearchBar.PromptText = "Search Here";
            this.txtSearchBar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchBar.SelectedText = "";
            this.txtSearchBar.SelectionLength = 0;
            this.txtSearchBar.SelectionStart = 0;
            this.txtSearchBar.ShortcutsEnabled = true;
            this.txtSearchBar.Size = new System.Drawing.Size(296, 31);
            this.txtSearchBar.TabIndex = 36;
            this.txtSearchBar.UseSelectable = true;
            this.txtSearchBar.WaterMark = "Search Here";
            this.txtSearchBar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchBar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            // 
            // cboBarcodeMode
            // 
            this.cboBarcodeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarcodeMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBarcodeMode.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold);
            this.cboBarcodeMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cboBarcodeMode.FormattingEnabled = true;
            this.cboBarcodeMode.Items.AddRange(new object[] {
            "Barcode ",
            "QR Code"});
            this.cboBarcodeMode.Location = new System.Drawing.Point(149, 11);
            this.cboBarcodeMode.Name = "cboBarcodeMode";
            this.cboBarcodeMode.Size = new System.Drawing.Size(105, 29);
            this.cboBarcodeMode.TabIndex = 39;
            this.cboBarcodeMode.SelectedIndexChanged += new System.EventHandler(this.cboBarcodeMode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(662, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Search Codes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Select Mode";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBarcode);
            this.panel3.Location = new System.Drawing.Point(476, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(721, 412);
            this.panel3.TabIndex = 37;
            // 
            // dgvBarcode
            // 
            this.dgvBarcode.AllowUserToAddRows = false;
            this.dgvBarcode.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            this.dgvBarcode.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBarcode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarcode.BackgroundColor = System.Drawing.Color.White;
            this.dgvBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBarcode.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvBarcode.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarcode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBarcode.ColumnHeadersHeight = 30;
            this.dgvBarcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBarcode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.description,
            this.open,
            this.Delete,
            this.print});
            this.dgvBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBarcode.EnableHeadersVisualStyles = false;
            this.dgvBarcode.Location = new System.Drawing.Point(0, 0);
            this.dgvBarcode.Name = "dgvBarcode";
            this.dgvBarcode.RowHeadersVisible = false;
            this.dgvBarcode.Size = new System.Drawing.Size(721, 412);
            this.dgvBarcode.TabIndex = 37;
            this.dgvBarcode.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarcode_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 37;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 20F;
            this.Column7.HeaderText = "BARCODE";
            this.Column7.MinimumWidth = 90;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.description.FillWeight = 10F;
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 400;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 400;
            // 
            // open
            // 
            this.open.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.open.HeaderText = "";
            this.open.Image = global::KDMEDISP.Properties.Resources.Opened_Folder_20px;
            this.open.Name = "open";
            this.open.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.FillWeight = 10F;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::KDMEDISP.Properties.Resources.icons8_Trash_16px;
            this.Delete.MinimumWidth = 10;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 10;
            // 
            // print
            // 
            this.print.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.print.HeaderText = "";
            this.print.Image = global::KDMEDISP.Properties.Resources.Print_16px;
            this.print.Name = "print";
            this.print.Width = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.FillWeight = 10F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::KDMEDISP.Properties.Resources.icons8_Pencil_Drawing_16px;
            this.dataGridViewImageColumn1.MinimumWidth = 10;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.FillWeight = 10F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::KDMEDISP.Properties.Resources.icons8_Trash_16px;
            this.dataGridViewImageColumn2.MinimumWidth = 10;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::KDMEDISP.Properties.Resources.Print_16px;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // pbxQr
            // 
            this.pbxQr.BackColor = System.Drawing.SystemColors.Control;
            this.pbxQr.Location = new System.Drawing.Point(138, 170);
            this.pbxQr.Name = "pbxQr";
            this.pbxQr.Size = new System.Drawing.Size(63, 54);
            this.pbxQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxQr.TabIndex = 34;
            this.pbxQr.TabStop = false;
            this.pbxQr.Visible = false;
            this.pbxQr.Click += new System.EventHandler(this.pbxQr_Click);
            // 
            // pbxBarcode
            // 
            this.pbxBarcode.BackColor = System.Drawing.SystemColors.Control;
            this.pbxBarcode.Location = new System.Drawing.Point(84, 170);
            this.pbxBarcode.Name = "pbxBarcode";
            this.pbxBarcode.Size = new System.Drawing.Size(170, 54);
            this.pbxBarcode.TabIndex = 34;
            this.pbxBarcode.TabStop = false;
            // 
            // btnGenerateRandom
            // 
            this.btnGenerateRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenerateRandom.FlatAppearance.BorderSize = 0;
            this.btnGenerateRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenerateRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenerateRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateRandom.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnGenerateRandom.ForeColor = System.Drawing.Color.White;
            this.btnGenerateRandom.Image = global::KDMEDISP.Properties.Resources.QR_Code_20px;
            this.btnGenerateRandom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateRandom.Location = new System.Drawing.Point(223, 267);
            this.btnGenerateRandom.Name = "btnGenerateRandom";
            this.btnGenerateRandom.Size = new System.Drawing.Size(106, 27);
            this.btnGenerateRandom.TabIndex = 33;
            this.btnGenerateRandom.Text = "Generate";
            this.btnGenerateRandom.UseVisualStyleBackColor = false;
            this.btnGenerateRandom.Click += new System.EventHandler(this.btnGenerateRandom_Click);
            // 
            // btnCreateBar
            // 
            this.btnCreateBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.btnCreateBar.FlatAppearance.BorderSize = 0;
            this.btnCreateBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBar.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnCreateBar.ForeColor = System.Drawing.Color.White;
            this.btnCreateBar.Image = global::KDMEDISP.Properties.Resources.Save_20px;
            this.btnCreateBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateBar.Location = new System.Drawing.Point(252, 363);
            this.btnCreateBar.Name = "btnCreateBar";
            this.btnCreateBar.Size = new System.Drawing.Size(85, 39);
            this.btnCreateBar.TabIndex = 33;
            this.btnCreateBar.Text = "Save";
            this.btnCreateBar.UseVisualStyleBackColor = false;
            this.btnCreateBar.Click += new System.EventHandler(this.btnCreateBar_Click);
            // 
            // btnGenerateBarcode
            // 
            this.btnGenerateBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.btnGenerateBarcode.FlatAppearance.BorderSize = 0;
            this.btnGenerateBarcode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenerateBarcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenerateBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBarcode.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnGenerateBarcode.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBarcode.Image = global::KDMEDISP.Properties.Resources.QR_Code_20px;
            this.btnGenerateBarcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateBarcode.Location = new System.Drawing.Point(25, 363);
            this.btnGenerateBarcode.Name = "btnGenerateBarcode";
            this.btnGenerateBarcode.Size = new System.Drawing.Size(207, 39);
            this.btnGenerateBarcode.TabIndex = 33;
            this.btnGenerateBarcode.Text = "Create BarCode/ QR code";
            this.btnGenerateBarcode.UseVisualStyleBackColor = false;
            this.btnGenerateBarcode.Click += new System.EventHandler(this.btnGenerateBarcode_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KDMEDISP.Properties.Resources.kdmedlogosm;
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // frmBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1200, 553);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxQr);
            this.Controls.Add(this.pbxBarcode);
            this.Controls.Add(this.btnGenerateRandom);
            this.Controls.Add(this.btnCreateBar);
            this.Controls.Add(this.btnGenerateBarcode);
            this.Controls.Add(this.txtProdDesc);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBarcode";
            this.Load += new System.EventHandler(this.frmBarcode_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnminMaxClose.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnminMaxClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private System.Windows.Forms.Button btnGenerateBarcode;
        private System.Windows.Forms.PictureBox pbxBarcode;
        private System.Windows.Forms.PictureBox pbxQr;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private MetroFramework.Controls.MetroTextBox txtProdDesc;
        private System.Windows.Forms.Button btnGenerateRandom;
        private System.Windows.Forms.Button btnCreateBar;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtSearchBar;
        private System.Windows.Forms.ComboBox cboBarcodeMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewImageColumn open;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn print;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}