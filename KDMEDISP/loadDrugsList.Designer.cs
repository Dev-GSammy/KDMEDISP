namespace KDMEDISP
{
    partial class loadDrugsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadDrugsList));
            this.dgvDrugLists = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbSearch = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtGenericName = new MetroFramework.Controls.MetroTextBox();
            this.tbDefault = new System.Windows.Forms.TabPage();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.btnLoadDefault = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Strength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugLists)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbDefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDrugLists
            // 
            this.dgvDrugLists.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            this.dgvDrugLists.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrugLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrugLists.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrugLists.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDrugLists.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrugLists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dgvDrugLists, "dgvDrugLists");
            this.dgvDrugLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDrugLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.generic,
            this.Strength,
            this.DrugClass,
            this.add});
            this.dgvDrugLists.EnableHeadersVisualStyles = false;
            this.dgvDrugLists.Name = "dgvDrugLists";
            this.dgvDrugLists.RowHeadersVisible = false;
            this.dgvDrugLists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrugLists_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbSearch);
            this.tabControl1.Controls.Add(this.tbDefault);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Controls.Add(this.panel2);
            this.tbSearch.Controls.Add(this.dgvDrugLists);
            resources.ApplyResources(this.tbSearch, "tbSearch");
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtGenericName);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtGenericName
            // 
            // 
            // 
            // 
            this.txtGenericName.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtGenericName.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtGenericName.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin")));
            this.txtGenericName.CustomButton.Name = "";
            this.txtGenericName.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtGenericName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGenericName.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtGenericName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGenericName.CustomButton.UseSelectable = true;
            this.txtGenericName.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txtGenericName.DisplayIcon = true;
            this.txtGenericName.Icon = global::KDMEDISP.Properties.Resources.search;
            this.txtGenericName.Lines = new string[0];
            resources.ApplyResources(this.txtGenericName, "txtGenericName");
            this.txtGenericName.MaxLength = 32767;
            this.txtGenericName.Name = "txtGenericName";
            this.txtGenericName.PasswordChar = '\0';
            this.txtGenericName.PromptText = "Name of Drug";
            this.txtGenericName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGenericName.SelectedText = "";
            this.txtGenericName.SelectionLength = 0;
            this.txtGenericName.SelectionStart = 0;
            this.txtGenericName.ShortcutsEnabled = true;
            this.txtGenericName.UseSelectable = true;
            this.txtGenericName.WaterMark = "Name of Drug";
            this.txtGenericName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGenericName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbDefault
            // 
            this.tbDefault.Controls.Add(this.lblSelectedFile);
            this.tbDefault.Controls.Add(this.btnLoadDefault);
            resources.ApplyResources(this.tbDefault, "tbDefault");
            this.tbDefault.Name = "tbDefault";
            this.tbDefault.UseVisualStyleBackColor = true;
            // 
            // lblSelectedFile
            // 
            resources.ApplyResources(this.lblSelectedFile, "lblSelectedFile");
            this.lblSelectedFile.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedFile.Name = "lblSelectedFile";
            // 
            // btnLoadDefault
            // 
            this.btnLoadDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLoadDefault.Image = global::KDMEDISP.Properties.Resources.Pills_30px;
            resources.ApplyResources(this.btnLoadDefault, "btnLoadDefault");
            this.btnLoadDefault.Name = "btnLoadDefault";
            this.btnLoadDefault.UseVisualStyleBackColor = true;
            this.btnLoadDefault.Click += new System.EventHandler(this.btnLoadDefault_Click);
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // generic
            // 
            resources.ApplyResources(this.generic, "generic");
            this.generic.Name = "generic";
            this.generic.ReadOnly = true;
            // 
            // Strength
            // 
            resources.ApplyResources(this.Strength, "Strength");
            this.Strength.Name = "Strength";
            this.Strength.ReadOnly = true;
            // 
            // DrugClass
            // 
            resources.ApplyResources(this.DrugClass, "DrugClass");
            this.DrugClass.Name = "DrugClass";
            this.DrugClass.ReadOnly = true;
            // 
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.add, "add");
            this.add.Image = global::KDMEDISP.Properties.Resources.AddNew_22px;
            this.add.Name = "add";
            // 
            // loadDrugsList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loadDrugsList";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.loadDrugsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugLists)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbSearch.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tbDefault.ResumeLayout(false);
            this.tbDefault.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDrugLists;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbSearch;
        public MetroFramework.Controls.MetroTextBox txtGenericName;
        private System.Windows.Forms.TabPage tbDefault;
        private System.Windows.Forms.Button btnLoadDefault;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn generic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Strength;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugClass;
        private System.Windows.Forms.DataGridViewImageColumn add;
    }
}