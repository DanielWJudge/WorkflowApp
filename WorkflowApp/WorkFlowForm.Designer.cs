namespace WorkflowApp
{
    partial class WorkFlowForm
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
            this.contextMenuStripAddDataScoring = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuAddFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAddDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxWtvAlgorith = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxFilters = new System.Windows.Forms.CheckedListBox();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.buttonOpenFilters = new System.Windows.Forms.Button();
            this.comboBoxExportType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddFiles = new WorkflowApp.SplitButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxFilterExports = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.contextMenuStripAddDataScoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripAddDataScoring
            // 
            this.contextMenuStripAddDataScoring.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAddFiles,
            this.toolStripMenuAddDirectory});
            this.contextMenuStripAddDataScoring.Name = "contextMenuStripAddWTV";
            this.contextMenuStripAddDataScoring.Size = new System.Drawing.Size(148, 48);
            // 
            // toolStripMenuAddFiles
            // 
            this.toolStripMenuAddFiles.Name = "toolStripMenuAddFiles";
            this.toolStripMenuAddFiles.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuAddFiles.Text = "Add File(s)";
            // 
            // toolStripMenuAddDirectory
            // 
            this.toolStripMenuAddDirectory.Name = "toolStripMenuAddDirectory";
            this.toolStripMenuAddDirectory.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuAddDirectory.Text = "Add Directory";
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.Location = new System.Drawing.Point(196, 24);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(81, 27);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear Files";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 17;
            this.listBoxFiles.Location = new System.Drawing.Point(26, 57);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(859, 123);
            this.listBoxFiles.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(594, 28);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 25);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Minimum Wear Minutes Per Day:";
            // 
            // comboBoxWtvAlgorith
            // 
            this.comboBoxWtvAlgorith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWtvAlgorith.FormattingEnabled = true;
            this.comboBoxWtvAlgorith.Items.AddRange(new object[] {
            "Troiano",
            "Choi"});
            this.comboBoxWtvAlgorith.Location = new System.Drawing.Point(228, 28);
            this.comboBoxWtvAlgorith.Name = "comboBoxWtvAlgorith";
            this.comboBoxWtvAlgorith.Size = new System.Drawing.Size(121, 25);
            this.comboBoxWtvAlgorith.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wear Time Validation Algorithm:";
            // 
            // checkedListBoxFilters
            // 
            this.checkedListBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxFilters.CheckOnClick = true;
            this.checkedListBoxFilters.FormattingEnabled = true;
            this.checkedListBoxFilters.Location = new System.Drawing.Point(424, 57);
            this.checkedListBoxFilters.Name = "checkedListBoxFilters";
            this.checkedListBoxFilters.Size = new System.Drawing.Size(461, 264);
            this.checkedListBoxFilters.TabIndex = 10;
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.AutoSize = true;
            this.buttonClearFilters.Location = new System.Drawing.Point(649, 24);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(86, 27);
            this.buttonClearFilters.TabIndex = 9;
            this.buttonClearFilters.Text = "Clear Filters";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFilters
            // 
            this.buttonOpenFilters.AutoSize = true;
            this.buttonOpenFilters.Location = new System.Drawing.Point(424, 24);
            this.buttonOpenFilters.Name = "buttonOpenFilters";
            this.buttonOpenFilters.Size = new System.Drawing.Size(203, 27);
            this.buttonOpenFilters.TabIndex = 7;
            this.buttonOpenFilters.Text = "Open Global Date/Time Filters...";
            this.buttonOpenFilters.UseVisualStyleBackColor = true;
            // 
            // comboBoxExportType
            // 
            this.comboBoxExportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExportType.FormattingEnabled = true;
            this.comboBoxExportType.Items.AddRange(new object[] {
            "CSV",
            "Excel"});
            this.comboBoxExportType.Location = new System.Drawing.Point(210, 64);
            this.comboBoxExportType.Name = "comboBoxExportType";
            this.comboBoxExportType.Size = new System.Drawing.Size(121, 25);
            this.comboBoxExportType.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Export Type:";
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(210, 33);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(675, 25);
            this.textBoxDirectory.TabIndex = 11;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.AutoSize = true;
            this.buttonSelectFolder.Location = new System.Drawing.Point(26, 31);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(178, 27);
            this.buttonSelectFolder.TabIndex = 10;
            this.buttonSelectFolder.Text = "Select Folder to Save Files...";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonAddFiles);
            this.groupBox1.Controls.Add(this.listBoxFiles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Files to Calculate";
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.AutoSize = true;
            this.buttonAddFiles.ContextMenuStrip = this.contextMenuStripAddDataScoring;
            this.buttonAddFiles.Location = new System.Drawing.Point(26, 24);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(147, 27);
            this.buttonAddFiles.SplitMenuStrip = this.contextMenuStripAddDataScoring;
            this.buttonAddFiles.TabIndex = 4;
            this.buttonAddFiles.Text = "Add AGD File(s)...";
            this.buttonAddFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxWtvAlgorith);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Wear Time Validation Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.listBoxFilterExports);
            this.groupBox3.Controls.Add(this.checkedListBoxFilters);
            this.groupBox3.Controls.Add(this.buttonOpenFilters);
            this.groupBox3.Controls.Add(this.buttonClearFilters);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(906, 339);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Filters for Each Export";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filter Exports";
            // 
            // listBoxFilterExports
            // 
            this.listBoxFilterExports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFilterExports.FormattingEnabled = true;
            this.listBoxFilterExports.ItemHeight = 17;
            this.listBoxFilterExports.Location = new System.Drawing.Point(26, 57);
            this.listBoxFilterExports.Name = "listBoxFilterExports";
            this.listBoxFilterExports.Size = new System.Drawing.Size(373, 259);
            this.listBoxFilterExports.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxExportType);
            this.groupBox4.Controls.Add(this.buttonSelectFolder);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBoxDirectory);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 634);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(906, 104);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Location to Save Results";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 738);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 56);
            this.panel1.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculate.AutoSize = true;
            this.buttonCalculate.Location = new System.Drawing.Point(799, 753);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(117, 27);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate Everything!";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // WorkFlowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 804);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WorkFlowForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "This Does Everything!";
            this.contextMenuStripAddDataScoring.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ContextMenuStrip contextMenuStripAddDataScoring;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuAddFiles;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuAddDirectory;
        private SplitButton buttonAddFiles;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxWtvAlgorith;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOpenFilters;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.ComboBox comboBoxExportType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.CheckedListBox checkedListBoxFilters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxFilterExports;

    }
}

