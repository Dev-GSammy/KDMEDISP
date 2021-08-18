namespace KDMEDISP
{
    partial class frmQty
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
            this.label66 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProdFound = new System.Windows.Forms.Label();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCloseProduct = new System.Windows.Forms.PictureBox();
            this.lblCurQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.pbxFoundProd = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoundProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.Color.White;
            this.label66.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Bold);
            this.label66.ForeColor = System.Drawing.Color.Black;
            this.label66.Location = new System.Drawing.Point(3, 8);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(206, 12);
            this.label66.TabIndex = 29;
            this.label66.Text = "Enter  Qty Here  and  Press Enter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Product:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProdFound
            // 
            this.lblProdFound.AutoSize = true;
            this.lblProdFound.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblProdFound.ForeColor = System.Drawing.Color.Purple;
            this.lblProdFound.Location = new System.Drawing.Point(64, 26);
            this.lblProdFound.Name = "lblProdFound";
            this.lblProdFound.Size = new System.Drawing.Size(20, 16);
            this.lblProdFound.TabIndex = 29;
            this.lblProdFound.Text = "...";
            this.lblProdFound.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.btnAddtoCart.FlatAppearance.BorderSize = 0;
            this.btnAddtoCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoCart.Font = new System.Drawing.Font("Consolas", 8F);
            this.btnAddtoCart.ForeColor = System.Drawing.Color.White;
            this.btnAddtoCart.Image = global::KDMEDISP.Properties.Resources.Buy_30px;
            this.btnAddtoCart.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddtoCart.Location = new System.Drawing.Point(241, 110);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(109, 54);
            this.btnAddtoCart.TabIndex = 36;
            this.btnAddtoCart.Text = "Add to  Dispense Cart";
            this.btnAddtoCart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddtoCart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddtoCart.UseVisualStyleBackColor = false;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel3.Controls.Add(this.btnCloseProduct);
            this.panel3.Controls.Add(this.label66);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 24);
            this.panel3.TabIndex = 39;
            // 
            // btnCloseProduct
            // 
            this.btnCloseProduct.BackColor = System.Drawing.Color.White;
            this.btnCloseProduct.Image = global::KDMEDISP.Properties.Resources.close;
            this.btnCloseProduct.Location = new System.Drawing.Point(330, 6);
            this.btnCloseProduct.Name = "btnCloseProduct";
            this.btnCloseProduct.Size = new System.Drawing.Size(24, 14);
            this.btnCloseProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseProduct.TabIndex = 34;
            this.btnCloseProduct.TabStop = false;
            this.btnCloseProduct.Click += new System.EventHandler(this.btnCloseProduct_Click);
            // 
            // lblCurQty
            // 
            this.lblCurQty.AutoSize = true;
            this.lblCurQty.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblCurQty.ForeColor = System.Drawing.Color.Purple;
            this.lblCurQty.Location = new System.Drawing.Point(2, 43);
            this.lblCurQty.Name = "lblCurQty";
            this.lblCurQty.Size = new System.Drawing.Size(20, 16);
            this.lblCurQty.TabIndex = 29;
            this.lblCurQty.Text = "...";
            this.lblCurQty.Visible = false;
            this.lblCurQty.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.txtQty.ForeColor = System.Drawing.Color.Purple;
            this.txtQty.Location = new System.Drawing.Point(5, 110);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(209, 54);
            this.txtQty.TabIndex = 31;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // pbxFoundProd
            // 
            this.pbxFoundProd.Location = new System.Drawing.Point(95, 47);
            this.pbxFoundProd.Name = "pbxFoundProd";
            this.pbxFoundProd.Size = new System.Drawing.Size(98, 57);
            this.pbxFoundProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoundProd.TabIndex = 33;
            this.pbxFoundProd.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 16);
            this.panel1.TabIndex = 40;
            // 
            // frmQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 195);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pbxFoundProd);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblCurQty);
            this.Controls.Add(this.lblProdFound);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQty";
            this.Load += new System.EventHandler(this.frmQty_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoundProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblProdFound;
        private System.Windows.Forms.PictureBox btnCloseProduct;
        public System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblCurQty;
        private System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.PictureBox pbxFoundProd;
        private System.Windows.Forms.Panel panel1;
    }
}