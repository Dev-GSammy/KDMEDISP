namespace KDMEDISP
{
    partial class FrmGsUpdate
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
            this.pnEditQty = new System.Windows.Forms.Panel();
            this.btnAction = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnEditQty.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnEditQty
            // 
            this.pnEditQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnEditQty.Controls.Add(this.btnAction);
            this.pnEditQty.Controls.Add(this.txtEdit);
            this.pnEditQty.Controls.Add(this.lblTitle);
            this.pnEditQty.Location = new System.Drawing.Point(-1, -1);
            this.pnEditQty.Name = "pnEditQty";
            this.pnEditQty.Size = new System.Drawing.Size(229, 86);
            this.pnEditQty.TabIndex = 16;
            this.pnEditQty.Paint += new System.Windows.Forms.PaintEventHandler(this.pnEditQty_Paint);
            // 
            // btnAction
            // 
            this.btnAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAction.Image = global::KDMEDISP.Properties.Resources.icons8_Discount_20px;
            this.btnAction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAction.Location = new System.Drawing.Point(140, 25);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(65, 23);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "...";
            this.btnAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnNewDiscount_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEdit.Location = new System.Drawing.Point(17, 25);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(117, 25);
            this.txtEdit.TabIndex = 0;
            this.txtEdit.TextChanged += new System.EventHandler(this.txtEdit_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(42, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(17, 17);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "...";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmGsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 81);
            this.Controls.Add(this.pnEditQty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmGsUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditCartQty";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmGsUpdate_KeyPress);
            this.pnEditQty.ResumeLayout(false);
            this.pnEditQty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEditQty;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Label lblTitle;
    }
}