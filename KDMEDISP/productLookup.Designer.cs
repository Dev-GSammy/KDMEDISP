namespace KDMEDISP
{
    partial class productLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productLookup));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearchProduct = new MetroFramework.Controls.MetroTextBox();
            this.pbxDrugImage = new System.Windows.Forms.PictureBox();
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
            this.lblStorageLoc = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdditionalInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblManufact = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblx = new System.Windows.Forms.Label();
            this.btnCloseProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDrugImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookupProduct)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProduct)).BeginInit();
            this.SuspendLayout();
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
            this.txtSearchProduct.Location = new System.Drawing.Point(703, 4);
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
            this.txtSearchProduct.TabIndex = 56;
            this.txtSearchProduct.UseSelectable = true;
            this.txtSearchProduct.WaterMark = "Search Here";
            this.txtSearchProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchProduct.Click += new System.EventHandler(this.txtSearchProduct_Click);
            // 
            // pbxDrugImage
            // 
            this.pbxDrugImage.Image = global::KDMEDISP.Properties.Resources.kdmedlogosm1;
            this.pbxDrugImage.Location = new System.Drawing.Point(12, 9);
            this.pbxDrugImage.Name = "pbxDrugImage";
            this.pbxDrugImage.Size = new System.Drawing.Size(99, 55);
            this.pbxDrugImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDrugImage.TabIndex = 59;
            this.pbxDrugImage.TabStop = false;
            this.pbxDrugImage.Click += new System.EventHandler(this.pbxPatientImg_Click);
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
            this.dgvLookupProduct.EnableHeadersVisualStyles = false;
            this.dgvLookupProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvLookupProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvLookupProduct.Name = "dgvLookupProduct";
            this.dgvLookupProduct.RowHeadersVisible = false;
            this.dgvLookupProduct.Size = new System.Drawing.Size(954, 366);
            this.dgvLookupProduct.TabIndex = 10;
            this.dgvLookupProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLookupProduct_CellContentClick);
            this.dgvLookupProduct.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLookupProduct_RowEnter_1);
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
            this.manufacturer.Visible = false;
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
            // lblStorageLoc
            // 
            this.lblStorageLoc.AutoSize = true;
            this.lblStorageLoc.ForeColor = System.Drawing.Color.White;
            this.lblStorageLoc.Location = new System.Drawing.Point(623, 30);
            this.lblStorageLoc.Name = "lblStorageLoc";
            this.lblStorageLoc.Size = new System.Drawing.Size(16, 13);
            this.lblStorageLoc.TabIndex = 68;
            this.lblStorageLoc.Text = "...";
            this.lblStorageLoc.Click += new System.EventHandler(this.lblStorageLoc_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(197, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(16, 13);
            this.lblPrice.TabIndex = 60;
            this.lblPrice.Text = "...";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Price:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.ForeColor = System.Drawing.Color.White;
            this.lblExpiryDate.Location = new System.Drawing.Point(197, 26);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(16, 13);
            this.lblExpiryDate.TabIndex = 61;
            this.lblExpiryDate.Text = "...";
            this.lblExpiryDate.Click += new System.EventHandler(this.lblExpiryDate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(118, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "ExpiryDate";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAdditionalInfo
            // 
            this.lblAdditionalInfo.AutoSize = true;
            this.lblAdditionalInfo.ForeColor = System.Drawing.Color.White;
            this.lblAdditionalInfo.Location = new System.Drawing.Point(623, 50);
            this.lblAdditionalInfo.Name = "lblAdditionalInfo";
            this.lblAdditionalInfo.Size = new System.Drawing.Size(16, 13);
            this.lblAdditionalInfo.TabIndex = 64;
            this.lblAdditionalInfo.Text = "...";
            this.lblAdditionalInfo.Click += new System.EventHandler(this.lblAdditionalInfo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(481, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Drug Details";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblManufact
            // 
            this.lblManufact.AutoSize = true;
            this.lblManufact.ForeColor = System.Drawing.Color.White;
            this.lblManufact.Location = new System.Drawing.Point(197, 9);
            this.lblManufact.Name = "lblManufact";
            this.lblManufact.Size = new System.Drawing.Size(16, 13);
            this.lblManufact.TabIndex = 67;
            this.lblManufact.Text = "...";
            this.lblManufact.Click += new System.EventHandler(this.lbldrugFullName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(529, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Storage Location";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Manufacturer:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLookupProduct);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 366);
            this.panel2.TabIndex = 58;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.ForeColor = System.Drawing.Color.White;
            this.lblx.Location = new System.Drawing.Point(529, 50);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(77, 13);
            this.lblx.TabIndex = 66;
            this.lblx.Text = "Additional Info:";
            this.lblx.Click += new System.EventHandler(this.lblx_Click);
            // 
            // btnCloseProduct
            // 
            this.btnCloseProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseProduct.Image")));
            this.btnCloseProduct.Location = new System.Drawing.Point(934, 42);
            this.btnCloseProduct.Name = "btnCloseProduct";
            this.btnCloseProduct.Size = new System.Drawing.Size(20, 18);
            this.btnCloseProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseProduct.TabIndex = 71;
            this.btnCloseProduct.TabStop = false;
            this.btnCloseProduct.Click += new System.EventHandler(this.btnCloseProduct_Click_1);
            // 
            // productLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.btnCloseProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.pbxDrugImage);
            this.Controls.Add(this.lblStorageLoc);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAdditionalInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblManufact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productLookup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productLookup";
            this.Load += new System.EventHandler(this.productLookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDrugImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookupProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private MetroFramework.Controls.MetroTextBox txtSearchProduct;
        private System.Windows.Forms.PictureBox pbxDrugImage;
        private System.Windows.Forms.DataGridView dgvLookupProduct;
        private System.Windows.Forms.Label lblStorageLoc;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdditionalInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblManufact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.PictureBox btnCloseProduct;
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
    }
}