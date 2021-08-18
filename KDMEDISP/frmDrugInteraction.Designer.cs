namespace KDMEDISP
{
    partial class frmDrugInteraction
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label66 = new System.Windows.Forms.Label();
            this.txtRxcui = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetInteraction = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRxCUI = new System.Windows.Forms.Label();
            this.rtxtDisc = new System.Windows.Forms.RichTextBox();
            this.txtSearchHigh = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtxtRes = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label66);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 38);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(973, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 23);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 10);
            this.panel1.TabIndex = 29;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label66.ForeColor = System.Drawing.Color.White;
            this.label66.Location = new System.Drawing.Point(3, 13);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(102, 16);
            this.label66.TabIndex = 28;
            this.label66.Text = "Drug Interaction";
            // 
            // txtRxcui
            // 
            // 
            // 
            // 
            this.txtRxcui.CustomButton.Image = null;
            this.txtRxcui.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtRxcui.CustomButton.Name = "";
            this.txtRxcui.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRxcui.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRxcui.CustomButton.TabIndex = 1;
            this.txtRxcui.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRxcui.CustomButton.UseSelectable = true;
            this.txtRxcui.CustomButton.Visible = false;
            this.txtRxcui.Lines = new string[] {
        "ventolin"};
            this.txtRxcui.Location = new System.Drawing.Point(313, 55);
            this.txtRxcui.MaxLength = 32767;
            this.txtRxcui.Name = "txtRxcui";
            this.txtRxcui.PasswordChar = '\0';
            this.txtRxcui.PromptText = "e.g Chloroquine";
            this.txtRxcui.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRxcui.SelectedText = "";
            this.txtRxcui.SelectionLength = 0;
            this.txtRxcui.SelectionStart = 0;
            this.txtRxcui.ShortcutsEnabled = true;
            this.txtRxcui.Size = new System.Drawing.Size(207, 23);
            this.txtRxcui.TabIndex = 20;
            this.txtRxcui.Text = "ventolin";
            this.txtRxcui.UseSelectable = true;
            this.txtRxcui.WaterMark = "e.g Chloroquine";
            this.txtRxcui.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRxcui.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(202, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name of Drug";
            // 
            // btnGetInteraction
            // 
            this.btnGetInteraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnGetInteraction.FlatAppearance.BorderSize = 0;
            this.btnGetInteraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetInteraction.ForeColor = System.Drawing.Color.White;
            this.btnGetInteraction.Location = new System.Drawing.Point(728, 50);
            this.btnGetInteraction.Name = "btnGetInteraction";
            this.btnGetInteraction.Size = new System.Drawing.Size(172, 28);
            this.btnGetInteraction.TabIndex = 32;
            this.btnGetInteraction.Text = "Get Interaction";
            this.btnGetInteraction.UseVisualStyleBackColor = false;
            this.btnGetInteraction.Click += new System.EventHandler(this.btnGetInteraction_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(32, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Drug RxCui";
            this.label2.Visible = false;
            // 
            // lblRxCUI
            // 
            this.lblRxCUI.AutoSize = true;
            this.lblRxCUI.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblRxCUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblRxCUI.Location = new System.Drawing.Point(111, 381);
            this.lblRxCUI.Name = "lblRxCUI";
            this.lblRxCUI.Size = new System.Drawing.Size(20, 16);
            this.lblRxCUI.TabIndex = 28;
            this.lblRxCUI.Text = "...";
            this.lblRxCUI.Visible = false;
            // 
            // rtxtDisc
            // 
            this.rtxtDisc.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtDisc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDisc.ForeColor = System.Drawing.Color.Purple;
            this.rtxtDisc.Location = new System.Drawing.Point(6, 198);
            this.rtxtDisc.Name = "rtxtDisc";
            this.rtxtDisc.ReadOnly = true;
            this.rtxtDisc.Size = new System.Drawing.Size(193, 160);
            this.rtxtDisc.TabIndex = 35;
            this.rtxtDisc.Text = "....................................";
            // 
            // txtSearchHigh
            // 
            // 
            // 
            // 
            this.txtSearchHigh.CustomButton.Image = null;
            this.txtSearchHigh.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtSearchHigh.CustomButton.Name = "";
            this.txtSearchHigh.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchHigh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchHigh.CustomButton.TabIndex = 1;
            this.txtSearchHigh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchHigh.CustomButton.UseSelectable = true;
            this.txtSearchHigh.CustomButton.Visible = false;
            this.txtSearchHigh.Lines = new string[0];
            this.txtSearchHigh.Location = new System.Drawing.Point(18, 101);
            this.txtSearchHigh.MaxLength = 32767;
            this.txtSearchHigh.Name = "txtSearchHigh";
            this.txtSearchHigh.PasswordChar = '\0';
            this.txtSearchHigh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchHigh.SelectedText = "";
            this.txtSearchHigh.SelectionLength = 0;
            this.txtSearchHigh.SelectionStart = 0;
            this.txtSearchHigh.ShortcutsEnabled = true;
            this.txtSearchHigh.Size = new System.Drawing.Size(172, 23);
            this.txtSearchHigh.TabIndex = 20;
            this.txtSearchHigh.UseSelectable = true;
            this.txtSearchHigh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchHigh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(45, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Search  in Result";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(18, 130);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 28);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(18, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(172, 28);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rtxtRes
            // 
            this.rtxtRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rtxtRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rtxtRes.ForeColor = System.Drawing.Color.White;
            this.rtxtRes.Location = new System.Drawing.Point(205, 82);
            this.rtxtRes.Name = "rtxtRes";
            this.rtxtRes.ReadOnly = true;
            this.rtxtRes.Size = new System.Drawing.Size(741, 426);
            this.rtxtRes.TabIndex = 36;
            this.rtxtRes.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SansSerif", 6.25F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(277, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 10);
            this.label5.TabIndex = 28;
            this.label5.Text = "Type the Name of the target drug or select from  list of  saved drugs";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(526, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // frmDrugInteraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 520);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rtxtRes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtDisc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGetInteraction);
            this.Controls.Add(this.lblRxCUI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchHigh);
            this.Controls.Add(this.txtRxcui);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDrugInteraction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDrugInteraction_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label66;
        private MetroFramework.Controls.MetroTextBox txtRxcui;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnGetInteraction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRxCUI;
        private System.Windows.Forms.RichTextBox rtxtDisc;
        private MetroFramework.Controls.MetroTextBox txtSearchHigh;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtxtRes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button btnExit;
    }
}