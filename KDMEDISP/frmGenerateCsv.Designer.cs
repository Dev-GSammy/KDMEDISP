namespace KDMEDISP
{
    partial class frmGenerateCsv
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
            this.dgvExportCsv = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxAnimate = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDisp = new System.Windows.Forms.Label();
            this.btnBrowseCsv = new System.Windows.Forms.Button();
            this.btnSyncStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportCsv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExportCsv
            // 
            this.dgvExportCsv.AllowUserToAddRows = false;
            this.dgvExportCsv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            this.dgvExportCsv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExportCsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExportCsv.BackgroundColor = System.Drawing.Color.White;
            this.dgvExportCsv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExportCsv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvExportCsv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExportCsv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExportCsv.ColumnHeadersHeight = 30;
            this.dgvExportCsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExportCsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExportCsv.EnableHeadersVisualStyles = false;
            this.dgvExportCsv.Location = new System.Drawing.Point(0, 0);
            this.dgvExportCsv.Name = "dgvExportCsv";
            this.dgvExportCsv.ReadOnly = true;
            this.dgvExportCsv.RowHeadersVisible = false;
            this.dgvExportCsv.Size = new System.Drawing.Size(977, 375);
            this.dgvExportCsv.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Export CSV/ Sync Stock";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 25);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(62, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "*Generate a Standard CSV from your Woo  Commerce Store and sync to to upload to W" +
    "oo Commerce Store";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbxAnimate);
            this.panel3.Controls.Add(this.dgvExportCsv);
            this.panel3.Location = new System.Drawing.Point(12, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(977, 375);
            this.panel3.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 35);
            this.panel2.TabIndex = 27;
            // 
            // pbxAnimate
            // 
            this.pbxAnimate.BackColor = System.Drawing.Color.Transparent;
            this.pbxAnimate.Image = global::KDMEDISP.Properties.Resources._3gif;
            this.pbxAnimate.Location = new System.Drawing.Point(372, 141);
            this.pbxAnimate.Name = "pbxAnimate";
            this.pbxAnimate.Size = new System.Drawing.Size(219, 158);
            this.pbxAnimate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAnimate.TabIndex = 21;
            this.pbxAnimate.TabStop = false;
            this.pbxAnimate.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KDMEDISP.Properties.Resources.ExportCSV_20px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(308, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Displayed Data:";
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Font = new System.Drawing.Font("Segoe UI", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDisp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDisp.Location = new System.Drawing.Point(437, 63);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(21, 19);
            this.lblDisp.TabIndex = 10;
            this.lblDisp.Text = "...";
            // 
            // btnBrowseCsv
            // 
            this.btnBrowseCsv.BackColor = System.Drawing.Color.DimGray;
            this.btnBrowseCsv.FlatAppearance.BorderSize = 0;
            this.btnBrowseCsv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBrowseCsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBrowseCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseCsv.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnBrowseCsv.ForeColor = System.Drawing.Color.Transparent;
            this.btnBrowseCsv.Image = global::KDMEDISP.Properties.Resources.ExtensionsFolder_20px;
            this.btnBrowseCsv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseCsv.Location = new System.Drawing.Point(162, 466);
            this.btnBrowseCsv.Name = "btnBrowseCsv";
            this.btnBrowseCsv.Size = new System.Drawing.Size(146, 36);
            this.btnBrowseCsv.TabIndex = 25;
            this.btnBrowseCsv.Text = "Browse  Old CSV";
            this.btnBrowseCsv.UseVisualStyleBackColor = false;
            this.btnBrowseCsv.Click += new System.EventHandler(this.btnBrowseCsv_Click);
            // 
            // btnSyncStock
            // 
            this.btnSyncStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSyncStock.FlatAppearance.BorderSize = 0;
            this.btnSyncStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSyncStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSyncStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyncStock.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnSyncStock.ForeColor = System.Drawing.Color.Transparent;
            this.btnSyncStock.Image = global::KDMEDISP.Properties.Resources.Network_20px;
            this.btnSyncStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSyncStock.Location = new System.Drawing.Point(384, 466);
            this.btnSyncStock.Name = "btnSyncStock";
            this.btnSyncStock.Size = new System.Drawing.Size(146, 36);
            this.btnSyncStock.TabIndex = 26;
            this.btnSyncStock.Text = "Sync Stock ";
            this.btnSyncStock.UseVisualStyleBackColor = false;
            this.btnSyncStock.Click += new System.EventHandler(this.btnSyncStock_Click);
            // 
            // frmGenerateCsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 524);
            this.Controls.Add(this.lblDisp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBrowseCsv);
            this.Controls.Add(this.btnSyncStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGenerateCsv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGenerateCsv";
            this.Load += new System.EventHandler(this.frmGenerateCsv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportCsv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExportCsv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowseCsv;
        private System.Windows.Forms.Button btnSyncStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.PictureBox pbxAnimate;
    }
}