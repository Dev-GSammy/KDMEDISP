namespace KDMEDISP
{
    partial class frmRecords
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label66 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCashierAnalytics = new System.Windows.Forms.Button();
            this.btnSoldItems = new System.Windows.Forms.Button();
            this.btnTopSelling = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label66);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 38);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 10);
            this.panel1.TabIndex = 29;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label66.ForeColor = System.Drawing.Color.White;
            this.label66.Location = new System.Drawing.Point(3, 13);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(129, 16);
            this.label66.TabIndex = 28;
            this.label66.Text = "Records and Analytics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KDMEDISP.Properties.Resources.kdmedlogosm1;
            this.pictureBox1.Location = new System.Drawing.Point(434, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnCashierAnalytics
            // 
            this.btnCashierAnalytics.FlatAppearance.BorderSize = 0;
            this.btnCashierAnalytics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCashierAnalytics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCashierAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashierAnalytics.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnCashierAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCashierAnalytics.Image = global::KDMEDISP.Properties.Resources.icons8_User_Groups_48px;
            this.btnCashierAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashierAnalytics.Location = new System.Drawing.Point(368, 79);
            this.btnCashierAnalytics.Name = "btnCashierAnalytics";
            this.btnCashierAnalytics.Size = new System.Drawing.Size(252, 108);
            this.btnCashierAnalytics.TabIndex = 6;
            this.btnCashierAnalytics.Text = "Cashier Analytics";
            this.btnCashierAnalytics.UseVisualStyleBackColor = true;
            this.btnCashierAnalytics.Click += new System.EventHandler(this.btnCashierAnalytics_Click);
            // 
            // btnSoldItems
            // 
            this.btnSoldItems.FlatAppearance.BorderSize = 0;
            this.btnSoldItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSoldItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSoldItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoldItems.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnSoldItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSoldItems.Image = global::KDMEDISP.Properties.Resources.category;
            this.btnSoldItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoldItems.Location = new System.Drawing.Point(713, 79);
            this.btnSoldItems.Name = "btnSoldItems";
            this.btnSoldItems.Size = new System.Drawing.Size(244, 108);
            this.btnSoldItems.TabIndex = 7;
            this.btnSoldItems.Text = "Sold Items";
            this.btnSoldItems.UseVisualStyleBackColor = true;
            this.btnSoldItems.Click += new System.EventHandler(this.btnSoldItems_Click);
            // 
            // btnTopSelling
            // 
            this.btnTopSelling.FlatAppearance.BorderSize = 0;
            this.btnTopSelling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnTopSelling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTopSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopSelling.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnTopSelling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTopSelling.Image = global::KDMEDISP.Properties.Resources.googlepre;
            this.btnTopSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopSelling.Location = new System.Drawing.Point(52, 79);
            this.btnTopSelling.Name = "btnTopSelling";
            this.btnTopSelling.Size = new System.Drawing.Size(252, 108);
            this.btnTopSelling.TabIndex = 9;
            this.btnTopSelling.Text = "Top Selling Products";
            this.btnTopSelling.UseVisualStyleBackColor = true;
            this.btnTopSelling.Click += new System.EventHandler(this.btnTopSelling_Click);
            // 
            // frmRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCashierAnalytics);
            this.Controls.Add(this.btnSoldItems);
            this.Controls.Add(this.btnTopSelling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button btnCashierAnalytics;
        private System.Windows.Forms.Button btnSoldItems;
        private System.Windows.Forms.Button btnTopSelling;
        private System.Windows.Forms.Panel panel1;
    }
}