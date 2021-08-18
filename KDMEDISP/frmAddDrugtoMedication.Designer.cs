namespace KDMEDISP
{
    partial class frmAddDrugtoMedication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDrugtoMedication));
            this.dgvLookupProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nprimary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addtocart = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbldrugFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCloseProduct = new System.Windows.Forms.PictureBox();
            this.txtSearchProduct = new MetroFramework.Controls.MetroTextBox();
            this.pbxPatientImg = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookupProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPatientImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLookupProduct
            // 
            this.dgvLookupProduct.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            this.dgvLookupProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLookupProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLookupProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvLookupProduct.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvLookupProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLookupProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLookupProduct.ColumnHeadersHeight = 30;
            this.dgvLookupProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLookupProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.nprimary,
            this.generic,
            this.strength,
            this.units,
            this.dclass,
            this.manufacturer,
            this.pcode,
            this.barcode,
            this.storageloc,
            this.qty,
            this.reorderQty,
            this.expirydate,
            this.supplier,
            this.package,
            this.price,
            this.additionalInfo,
            this.addtocart});
            this.dgvLookupProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLookupProduct.EnableHeadersVisualStyles = false;
            this.dgvLookupProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvLookupProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvLookupProduct.Name = "dgvLookupProduct";
            this.dgvLookupProduct.RowHeadersVisible = false;
            this.dgvLookupProduct.Size = new System.Drawing.Size(1015, 366);
            this.dgvLookupProduct.TabIndex = 10;
            this.dgvLookupProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLookupProduct_CellContentClick);
            this.dgvLookupProduct.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLookupProduct_RowEnter);
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
            // nprimary
            // 
            this.nprimary.HeaderText = "Primary";
            this.nprimary.Name = "nprimary";
            // 
            // generic
            // 
            this.generic.HeaderText = "Generic";
            this.generic.Name = "generic";
            // 
            // strength
            // 
            this.strength.HeaderText = "Strength";
            this.strength.Name = "strength";
            // 
            // units
            // 
            this.units.HeaderText = "units";
            this.units.Name = "units";
            // 
            // dclass
            // 
            this.dclass.HeaderText = "Class";
            this.dclass.Name = "dclass";
            // 
            // manufacturer
            // 
            this.manufacturer.HeaderText = "Manufacturer";
            this.manufacturer.Name = "manufacturer";
            // 
            // pcode
            // 
            this.pcode.HeaderText = "PCode";
            this.pcode.Name = "pcode";
            this.pcode.Visible = false;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.Visible = false;
            // 
            // storageloc
            // 
            this.storageloc.HeaderText = "Location";
            this.storageloc.Name = "storageloc";
            this.storageloc.Visible = false;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.Visible = false;
            // 
            // reorderQty
            // 
            this.reorderQty.HeaderText = "reorder Qty";
            this.reorderQty.Name = "reorderQty";
            this.reorderQty.Visible = false;
            // 
            // expirydate
            // 
            this.expirydate.HeaderText = "expirydate";
            this.expirydate.Name = "expirydate";
            this.expirydate.Visible = false;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Supplier";
            this.supplier.Name = "supplier";
            this.supplier.Visible = false;
            // 
            // package
            // 
            this.package.HeaderText = "Package";
            this.package.Name = "package";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.Visible = false;
            // 
            // additionalInfo
            // 
            this.additionalInfo.HeaderText = "Additional Info";
            this.additionalInfo.Name = "additionalInfo";
            this.additionalInfo.Visible = false;
            // 
            // addtocart
            // 
            this.addtocart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addtocart.HeaderText = "";
            this.addtocart.Image = global::KDMEDISP.Properties.Resources.Checkmark_16px;
            this.addtocart.Name = "addtocart";
            this.addtocart.Width = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(194, 79);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(16, 13);
            this.lblPrice.TabIndex = 75;
            this.lblPrice.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Price:";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.ForeColor = System.Drawing.Color.White;
            this.lblExpiryDate.Location = new System.Drawing.Point(194, 58);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(16, 13);
            this.lblExpiryDate.TabIndex = 76;
            this.lblExpiryDate.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(115, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "ExpiryDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(478, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 80;
            this.label9.Text = "Drug Details";
            // 
            // lbldrugFullName
            // 
            this.lbldrugFullName.AutoSize = true;
            this.lbldrugFullName.ForeColor = System.Drawing.Color.White;
            this.lbldrugFullName.Location = new System.Drawing.Point(194, 42);
            this.lbldrugFullName.Name = "lbldrugFullName";
            this.lbldrugFullName.Size = new System.Drawing.Size(16, 13);
            this.lbldrugFullName.TabIndex = 82;
            this.lbldrugFullName.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Drug Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLookupProduct);
            this.panel2.Location = new System.Drawing.Point(-3, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 366);
            this.panel2.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 24);
            this.panel1.TabIndex = 87;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 21);
            this.panel3.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Step 1:  Select Target Drug";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // btnCloseProduct
            // 
            this.btnCloseProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseProduct.Image")));
            this.btnCloseProduct.Location = new System.Drawing.Point(974, 74);
            this.btnCloseProduct.Name = "btnCloseProduct";
            this.btnCloseProduct.Size = new System.Drawing.Size(20, 18);
            this.btnCloseProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseProduct.TabIndex = 86;
            this.btnCloseProduct.TabStop = false;
            this.btnCloseProduct.Click += new System.EventHandler(this.btnCloseProduct_Click_2);
            // 
            // txtSearchProduct
            // 
            // 
            // 
            // 
            this.txtSearchProduct.CustomButton.Image = null;
            this.txtSearchProduct.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.txtSearchProduct.CustomButton.Name = "";
            this.txtSearchProduct.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSearchProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchProduct.CustomButton.TabIndex = 1;
            this.txtSearchProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchProduct.CustomButton.UseSelectable = true;
            this.txtSearchProduct.CustomButton.Visible = false;
            this.txtSearchProduct.DisplayIcon = true;
            this.txtSearchProduct.Icon = global::KDMEDISP.Properties.Resources.search;
            this.txtSearchProduct.Lines = new string[0];
            this.txtSearchProduct.Location = new System.Drawing.Point(749, 33);
            this.txtSearchProduct.MaxLength = 32767;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PromptText = "Search Here";
            this.txtSearchProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.SelectionLength = 0;
            this.txtSearchProduct.SelectionStart = 0;
            this.txtSearchProduct.ShortcutsEnabled = true;
            this.txtSearchProduct.Size = new System.Drawing.Size(231, 25);
            this.txtSearchProduct.TabIndex = 72;
            this.txtSearchProduct.UseSelectable = true;
            this.txtSearchProduct.WaterMark = "Search Here";
            this.txtSearchProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbxPatientImg
            // 
            this.pbxPatientImg.Image = global::KDMEDISP.Properties.Resources.kdmedlogosm1;
            this.pbxPatientImg.Location = new System.Drawing.Point(-4, 31);
            this.pbxPatientImg.Name = "pbxPatientImg";
            this.pbxPatientImg.Size = new System.Drawing.Size(110, 72);
            this.pbxPatientImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPatientImg.TabIndex = 74;
            this.pbxPatientImg.TabStop = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // frmAddDrugtoMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1017, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCloseProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.pbxPatientImg);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbldrugFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddDrugtoMedication";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddDrugtoMedication";
            this.Load += new System.EventHandler(this.frmAddDrugtoMedication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookupProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPatientImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCloseProduct;
        private System.Windows.Forms.DataGridView dgvLookupProduct;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private MetroFramework.Controls.MetroTextBox txtSearchProduct;
        private System.Windows.Forms.PictureBox pbxPatientImg;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbldrugFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nprimary;
        private System.Windows.Forms.DataGridViewTextBoxColumn generic;
        private System.Windows.Forms.DataGridViewTextBoxColumn strength;
        private System.Windows.Forms.DataGridViewTextBoxColumn units;
        private System.Windows.Forms.DataGridViewTextBoxColumn dclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn package;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfo;
        private System.Windows.Forms.DataGridViewImageColumn addtocart;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label7;
    }
}