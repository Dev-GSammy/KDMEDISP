namespace KDMEDISP
{
    partial class frmDrugList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrugList));
            this.lblStorageLoc = new System.Windows.Forms.Label();
            this.dgvDrugList = new System.Windows.Forms.DataGridView();
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdditionalInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.lbldrugFullName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbxPatientImg = new System.Windows.Forms.PictureBox();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNewPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPatientImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStorageLoc
            // 
            this.lblStorageLoc.AutoSize = true;
            this.lblStorageLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblStorageLoc.Location = new System.Drawing.Point(643, 63);
            this.lblStorageLoc.Name = "lblStorageLoc";
            this.lblStorageLoc.Size = new System.Drawing.Size(19, 13);
            this.lblStorageLoc.TabIndex = 53;
            this.lblStorageLoc.Text = "...";
            // 
            // dgvDrugList
            // 
            this.dgvDrugList.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Thistle;
            this.dgvDrugList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDrugList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrugList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrugList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDrugList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrugList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDrugList.ColumnHeadersHeight = 30;
            this.dgvDrugList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDrugList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Edit,
            this.Delete});
            this.dgvDrugList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrugList.EnableHeadersVisualStyles = false;
            this.dgvDrugList.Location = new System.Drawing.Point(0, 0);
            this.dgvDrugList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDrugList.Name = "dgvDrugList";
            this.dgvDrugList.RowHeadersVisible = false;
            this.dgvDrugList.Size = new System.Drawing.Size(1019, 384);
            this.dgvDrugList.TabIndex = 10;
            this.dgvDrugList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrugList_CellContentClick);
            this.dgvDrugList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrugList_RowEnter);
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
            // 
            // expirydate
            // 
            this.expirydate.HeaderText = "expirydate";
            this.expirydate.Name = "expirydate";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "DRUG/ SUPPLIES";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPrice.Location = new System.Drawing.Point(200, 84);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(19, 13);
            this.lblPrice.TabIndex = 43;
            this.lblPrice.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(121, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Price:";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblExpiryDate.Location = new System.Drawing.Point(200, 63);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(19, 13);
            this.lblExpiryDate.TabIndex = 44;
            this.lblExpiryDate.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(121, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "ExpiryDate";
            // 
            // lblAdditionalInfo
            // 
            this.lblAdditionalInfo.AutoSize = true;
            this.lblAdditionalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAdditionalInfo.Location = new System.Drawing.Point(643, 83);
            this.lblAdditionalInfo.Name = "lblAdditionalInfo";
            this.lblAdditionalInfo.Size = new System.Drawing.Size(19, 13);
            this.lblAdditionalInfo.TabIndex = 47;
            this.lblAdditionalInfo.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(436, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Drug Details";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblx.Location = new System.Drawing.Point(533, 83);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(93, 13);
            this.lblx.TabIndex = 49;
            this.lblx.Text = "Additional Info:";
            // 
            // lbldrugFullName
            // 
            this.lbldrugFullName.AutoSize = true;
            this.lbldrugFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldrugFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbldrugFullName.Location = new System.Drawing.Point(200, 47);
            this.lbldrugFullName.Name = "lbldrugFullName";
            this.lbldrugFullName.Size = new System.Drawing.Size(19, 13);
            this.lbldrugFullName.TabIndex = 52;
            this.lbldrugFullName.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(533, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Storage Location";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDrugList);
            this.panel2.Location = new System.Drawing.Point(1, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 384);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnNewPatient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 44);
            this.panel1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(120, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Drug Name:";
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
            this.pbxPatientImg.Location = new System.Drawing.Point(3, 49);
            this.pbxPatientImg.Name = "pbxPatientImg";
            this.pbxPatientImg.Size = new System.Drawing.Size(80, 61);
            this.pbxPatientImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPatientImg.TabIndex = 40;
            this.pbxPatientImg.TabStop = false;
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
            this.btnNewPatient.Image = global::KDMEDISP.Properties.Resources.PilBottle_22px;
            this.btnNewPatient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewPatient.Location = new System.Drawing.Point(920, 2);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(97, 39);
            this.btnNewPatient.TabIndex = 58;
            this.btnNewPatient.Text = "New Drug";
            this.btnNewPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewPatient.UseVisualStyleBackColor = false;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // frmDrugList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 500);
            this.Controls.Add(this.pbxPatientImg);
            this.Controls.Add(this.lblStorageLoc);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAdditionalInfo);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.lbldrugFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "frmDrugList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDrugList";
            this.Load += new System.EventHandler(this.frmDrugList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPatientImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox pbxPatientImg;
        private System.Windows.Forms.Label lblStorageLoc;
        private System.Windows.Forms.DataGridView dgvDrugList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdditionalInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lbldrugFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewPatient;
    }
}