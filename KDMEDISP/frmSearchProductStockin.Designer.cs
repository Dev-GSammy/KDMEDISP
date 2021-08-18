namespace KDMEDISP
{
    partial class frmSearchProductStockin
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchProduct = new MetroFramework.Controls.MetroTextBox();
            this.btnSearchexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxStockProd = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvStockProductList = new System.Windows.Forms.DataGridView();
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
            this.status = new System.Windows.Forms.DataGridViewImageColumn();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStockProd)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSearchProduct);
            this.panel2.Controls.Add(this.btnSearchexit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 45);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Drugs/ Supply List";
            // 
            // txtSearchProduct
            // 
            // 
            // 
            // 
            this.txtSearchProduct.CustomButton.Image = null;
            this.txtSearchProduct.CustomButton.Location = new System.Drawing.Point(325, 1);
            this.txtSearchProduct.CustomButton.Name = "";
            this.txtSearchProduct.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSearchProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchProduct.CustomButton.TabIndex = 1;
            this.txtSearchProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchProduct.CustomButton.UseSelectable = true;
            this.txtSearchProduct.CustomButton.Visible = false;
            this.txtSearchProduct.DisplayIcon = true;
            this.txtSearchProduct.Icon = global::KDMEDISP.Properties.Resources.search;
            this.txtSearchProduct.Lines = new string[0];
            this.txtSearchProduct.Location = new System.Drawing.Point(521, 6);
            this.txtSearchProduct.MaxLength = 32767;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PromptText = "Search Here";
            this.txtSearchProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.SelectionLength = 0;
            this.txtSearchProduct.SelectionStart = 0;
            this.txtSearchProduct.ShortcutsEnabled = true;
            this.txtSearchProduct.Size = new System.Drawing.Size(355, 31);
            this.txtSearchProduct.TabIndex = 13;
            this.txtSearchProduct.UseSelectable = true;
            this.txtSearchProduct.WaterMark = "Search Here";
            this.txtSearchProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            this.txtSearchProduct.Click += new System.EventHandler(this.txtSearchProduct_Click);
            this.txtSearchProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchProduct_KeyPress);
            // 
            // btnSearchexit
            // 
            this.btnSearchexit.ForeColor = System.Drawing.Color.Red;
            this.btnSearchexit.Location = new System.Drawing.Point(882, 7);
            this.btnSearchexit.Name = "btnSearchexit";
            this.btnSearchexit.Size = new System.Drawing.Size(48, 28);
            this.btnSearchexit.TabIndex = 0;
            this.btnSearchexit.Text = "X";
            this.btnSearchexit.UseVisualStyleBackColor = true;
            this.btnSearchexit.Click += new System.EventHandler(this.btnBrandexit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbxStockProd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 71);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbxStockProd
            // 
            this.pbxStockProd.Image = global::KDMEDISP.Properties.Resources.kdmedlogosm;
            this.pbxStockProd.Location = new System.Drawing.Point(431, 8);
            this.pbxStockProd.Name = "pbxStockProd";
            this.pbxStockProd.Size = new System.Drawing.Size(101, 57);
            this.pbxStockProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxStockProd.TabIndex = 27;
            this.pbxStockProd.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvStockProductList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 403);
            this.panel3.TabIndex = 16;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "STATUS";
            this.dataGridViewImageColumn1.Image = global::KDMEDISP.Properties.Resources.alert16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::KDMEDISP.Properties.Resources.Checkmark_16px;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dgvStockProductList
            // 
            this.dgvStockProductList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            this.dgvStockProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockProductList.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockProductList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvStockProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockProductList.ColumnHeadersHeight = 30;
            this.dgvStockProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStockProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.status,
            this.select});
            this.dgvStockProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockProductList.EnableHeadersVisualStyles = false;
            this.dgvStockProductList.Location = new System.Drawing.Point(0, 0);
            this.dgvStockProductList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStockProductList.Name = "dgvStockProductList";
            this.dgvStockProductList.RowHeadersVisible = false;
            this.dgvStockProductList.Size = new System.Drawing.Size(933, 403);
            this.dgvStockProductList.TabIndex = 11;
            this.dgvStockProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockProductList_CellContentClick);
            this.dgvStockProductList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockProductList_RowEnter);
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
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Image = global::KDMEDISP.Properties.Resources.alert16;
            this.status.Name = "status";
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.select.HeaderText = "";
            this.select.Image = global::KDMEDISP.Properties.Resources.Checkmark_16px;
            this.select.Name = "select";
            this.select.Width = 5;
            // 
            // frmSearchProductStockin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSearchProductStockin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxStockProd)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchexit;
        private MetroFramework.Controls.MetroTextBox txtSearchProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxStockProd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView dgvStockProductList;
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
        private System.Windows.Forms.DataGridViewImageColumn status;
        private System.Windows.Forms.DataGridViewImageColumn select;
    }
}