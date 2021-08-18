namespace KDMEDISP
{
    partial class frmTheme
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.pbxStockLevel = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnminMaxClose = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnButtons = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStockLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnminMaxClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnTop.Controls.Add(this.pbxStockLevel);
            this.pnTop.Controls.Add(this.label2);
            this.pnTop.Controls.Add(this.pbxLogo);
            this.pnTop.Controls.Add(this.pnminMaxClose);
            this.pnTop.Controls.Add(this.lblLowStock);
            this.pnTop.Controls.Add(this.lblDate);
            this.pnTop.Controls.Add(this.lblTime);
            this.pnTop.Controls.Add(this.label66);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(520, 56);
            this.pnTop.TabIndex = 2;
            // 
            // pbxStockLevel
            // 
            this.pbxStockLevel.Image = global::KDMEDISP.Properties.Resources.alert45;
            this.pbxStockLevel.Location = new System.Drawing.Point(1021, 2);
            this.pbxStockLevel.Name = "pbxStockLevel";
            this.pbxStockLevel.Size = new System.Drawing.Size(53, 34);
            this.pbxStockLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxStockLevel.TabIndex = 1;
            this.pbxStockLevel.TabStop = false;
            this.pbxStockLevel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "KDMEDISP POS & Inventory Suite";
            // 
            // pbxLogo
            // 
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
            this.pnminMaxClose.Location = new System.Drawing.Point(1136, 0);
            this.pnminMaxClose.Name = "pnminMaxClose";
            this.pnminMaxClose.Size = new System.Drawing.Size(61, 29);
            this.pnminMaxClose.TabIndex = 26;
            // 
            // btnMin
            // 
            this.btnMin.Image = global::KDMEDISP.Properties.Resources.icons8_Minimize_Window_32px_1;
            this.btnMin.Location = new System.Drawing.Point(3, 7);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 23);
            this.btnMin.TabIndex = 0;
            this.btnMin.Text = "--";
            this.btnMin.UseVisualStyleBackColor = true;
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
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(692, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(20, 16);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "...";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Perpetua", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(687, 6);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(25, 23);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "...";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label66.ForeColor = System.Drawing.Color.White;
            this.label66.Location = new System.Drawing.Point(225, 33);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(265, 16);
            this.label66.TabIndex = 28;
            this.label66.Text = "Complete Business Solution Module [premium]";
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnLeft.Location = new System.Drawing.Point(0, 58);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(102, 232);
            this.pnLeft.TabIndex = 3;
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.Color.Purple;
            this.btnTop.FlatAppearance.BorderSize = 0;
            this.btnTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnTop.ForeColor = System.Drawing.Color.White;
            this.btnTop.Image = global::KDMEDISP.Properties.Resources.ware;
            this.btnTop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTop.Location = new System.Drawing.Point(193, 116);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(175, 26);
            this.btnTop.TabIndex = 43;
            this.btnTop.Text = "Top Panel Color";
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Purple;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.Image = global::KDMEDISP.Properties.Resources.ware;
            this.btnLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeft.Location = new System.Drawing.Point(193, 150);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(175, 26);
            this.btnLeft.TabIndex = 43;
            this.btnLeft.Text = "Left Panel Color";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnButtons
            // 
            this.btnButtons.BackColor = System.Drawing.Color.Purple;
            this.btnButtons.FlatAppearance.BorderSize = 0;
            this.btnButtons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnButtons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButtons.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnButtons.ForeColor = System.Drawing.Color.White;
            this.btnButtons.Image = global::KDMEDISP.Properties.Resources.ware;
            this.btnButtons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnButtons.Location = new System.Drawing.Point(193, 184);
            this.btnButtons.Name = "btnButtons";
            this.btnButtons.Size = new System.Drawing.Size(175, 26);
            this.btnButtons.TabIndex = 43;
            this.btnButtons.Text = "Button Color";
            this.btnButtons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnButtons.UseVisualStyleBackColor = false;
            this.btnButtons.Click += new System.EventHandler(this.btnButtons_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Purple;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = global::KDMEDISP.Properties.Resources.ware;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(333, 252);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(175, 26);
            this.btnReturn.TabIndex = 43;
            this.btnReturn.Text = " Return";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 290);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnButtons);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTheme";
            this.Load += new System.EventHandler(this.frmTheme_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStockLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnminMaxClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.PictureBox pbxStockLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnminMaxClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnButtons;
        private System.Windows.Forms.Button btnReturn;
    }
}