namespace KDMEDISP
{
    partial class frmDiscount
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
            this.btnDiscExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscPercent = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lbldiscountAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewDiscount = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnDiscExit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 36);
            this.panel2.TabIndex = 11;
            // 
            // btnDiscExit
            // 
            this.btnDiscExit.ForeColor = System.Drawing.Color.Red;
            this.btnDiscExit.Location = new System.Drawing.Point(340, 9);
            this.btnDiscExit.Name = "btnDiscExit";
            this.btnDiscExit.Size = new System.Drawing.Size(24, 23);
            this.btnDiscExit.TabIndex = 0;
            this.btnDiscExit.Text = "X";
            this.btnDiscExit.UseVisualStyleBackColor = true;
            this.btnDiscExit.Click += new System.EventHandler(this.btnDiscExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Add Discounts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product Price";
            // 
            // txtDiscPrice
            // 
            this.txtDiscPrice.Enabled = false;
            this.txtDiscPrice.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtDiscPrice.Location = new System.Drawing.Point(115, 50);
            this.txtDiscPrice.Name = "txtDiscPrice";
            this.txtDiscPrice.Size = new System.Drawing.Size(232, 24);
            this.txtDiscPrice.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Discount %";
            // 
            // txtDiscPercent
            // 
            this.txtDiscPercent.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtDiscPercent.Location = new System.Drawing.Point(115, 80);
            this.txtDiscPercent.Name = "txtDiscPercent";
            this.txtDiscPercent.Size = new System.Drawing.Size(84, 24);
            this.txtDiscPercent.TabIndex = 13;
            this.txtDiscPercent.TextChanged += new System.EventHandler(this.txtDiscPercent_TextChanged);
            this.txtDiscPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscPercent_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblID.Location = new System.Drawing.Point(3, 158);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 17);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "id";
            this.lblID.Visible = false;
            // 
            // lbldiscountAmount
            // 
            this.lbldiscountAmount.AutoSize = true;
            this.lbldiscountAmount.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbldiscountAmount.Location = new System.Drawing.Point(112, 120);
            this.lbldiscountAmount.Name = "lbldiscountAmount";
            this.lbldiscountAmount.Size = new System.Drawing.Size(17, 17);
            this.lbldiscountAmount.TabIndex = 12;
            this.lbldiscountAmount.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Disc Amt:";
            // 
            // btnNewDiscount
            // 
            this.btnNewDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNewDiscount.Image = global::KDMEDISP.Properties.Resources.icons8_Discount_20px;
            this.btnNewDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDiscount.Location = new System.Drawing.Point(299, 146);
            this.btnNewDiscount.Name = "btnNewDiscount";
            this.btnNewDiscount.Size = new System.Drawing.Size(65, 23);
            this.btnNewDiscount.TabIndex = 0;
            this.btnNewDiscount.Text = "Apply";
            this.btnNewDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewDiscount.UseVisualStyleBackColor = true;
            this.btnNewDiscount.Click += new System.EventHandler(this.btnNewDiscount_Click);
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 175);
            this.ControlBox = false;
            this.Controls.Add(this.btnNewDiscount);
            this.Controls.Add(this.txtDiscPercent);
            this.Controls.Add(this.txtDiscPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbldiscountAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDiscount_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDiscExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDiscPrice;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDiscPercent;
        private System.Windows.Forms.Button btnNewDiscount;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbldiscountAmount;
        private System.Windows.Forms.Label label4;
    }
}