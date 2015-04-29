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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxWtvAlgorithm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxFilters = new System.Windows.Forms.CheckedListBox();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.buttonOpenFilters = new System.Windows.Forms.Button();
            this.comboBoxExportType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFiltersCount = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFilesCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBoxFiles = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxFilterExports = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelSelectAllFiles = new System.Windows.Forms.LinkLabel();
            this.buttonAddFiles = new WorkflowApp.SplitButton();
            this.checkBoxCalculateWtv = new System.Windows.Forms.CheckBox();
            this.contextMenuStripAddDataScoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClear.Location = new System.Drawing.Point(151, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(81, 27);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear Files";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(843, 29);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 25);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Minimum Wear Minutes Per Day:";
            // 
            // comboBoxWtvAlgorithm
            // 
            this.comboBoxWtvAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWtvAlgorithm.FormattingEnabled = true;
            this.comboBoxWtvAlgorithm.Location = new System.Drawing.Point(477, 29);
            this.comboBoxWtvAlgorithm.Name = "comboBoxWtvAlgorithm";
            this.comboBoxWtvAlgorithm.Size = new System.Drawing.Size(121, 25);
            this.comboBoxWtvAlgorithm.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wear Time Validation Algorithm:";
            // 
            // checkedListBoxFilters
            // 
            this.checkedListBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxFilters.CheckOnClick = true;
            this.checkedListBoxFilters.FormattingEnabled = true;
            this.checkedListBoxFilters.Location = new System.Drawing.Point(313, 57);
            this.checkedListBoxFilters.Name = "checkedListBoxFilters";
            this.checkedListBoxFilters.Size = new System.Drawing.Size(461, 304);
            this.checkedListBoxFilters.TabIndex = 10;
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.AutoSize = true;
            this.buttonClearFilters.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClearFilters.Location = new System.Drawing.Point(218, 3);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(86, 27);
            this.buttonClearFilters.TabIndex = 9;
            this.buttonClearFilters.Text = "Clear Filters";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFilters
            // 
            this.buttonOpenFilters.AutoSize = true;
            this.buttonOpenFilters.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOpenFilters.Location = new System.Drawing.Point(3, 3);
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
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1281, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Files and Filters to Calculate";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonOpenFilters);
            this.flowLayoutPanel2.Controls.Add(this.labelFiltersCount);
            this.flowLayoutPanel2.Controls.Add(this.buttonClearFilters);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(26, 69);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(558, 34);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // labelFiltersCount
            // 
            this.labelFiltersCount.AutoSize = true;
            this.labelFiltersCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFiltersCount.Location = new System.Drawing.Point(212, 0);
            this.labelFiltersCount.Name = "labelFiltersCount";
            this.labelFiltersCount.Size = new System.Drawing.Size(0, 33);
            this.labelFiltersCount.TabIndex = 11;
            this.labelFiltersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonAddFiles);
            this.flowLayoutPanel1.Controls.Add(this.labelFilesCount);
            this.flowLayoutPanel1.Controls.Add(this.buttonClear);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(558, 34);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // labelFilesCount
            // 
            this.labelFilesCount.AutoSize = true;
            this.labelFilesCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFilesCount.Location = new System.Drawing.Point(145, 0);
            this.labelFilesCount.Name = "labelFilesCount";
            this.labelFilesCount.Size = new System.Drawing.Size(0, 33);
            this.labelFilesCount.TabIndex = 5;
            this.labelFilesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxCalculateWtv);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxWtvAlgorithm);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1281, 67);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Wear Time Validation Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabelSelectAllFiles);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.checkedListBoxFiles);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.listBoxFilterExports);
            this.groupBox3.Controls.Add(this.checkedListBoxFilters);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1281, 376);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Filters for Each Export";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(950, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Files to Use for Each Export";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Global Date/Time Filters to Use for Each Export";
            // 
            // checkedListBoxFiles
            // 
            this.checkedListBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxFiles.CheckOnClick = true;
            this.checkedListBoxFiles.FormattingEnabled = true;
            this.checkedListBoxFiles.Location = new System.Drawing.Point(794, 57);
            this.checkedListBoxFiles.Name = "checkedListBoxFiles";
            this.checkedListBoxFiles.Size = new System.Drawing.Size(481, 304);
            this.checkedListBoxFiles.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Exports";
            // 
            // listBoxFilterExports
            // 
            this.listBoxFilterExports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFilterExports.FormattingEnabled = true;
            this.listBoxFilterExports.ItemHeight = 17;
            this.listBoxFilterExports.Location = new System.Drawing.Point(26, 57);
            this.listBoxFilterExports.Name = "listBoxFilterExports";
            this.listBoxFilterExports.Size = new System.Drawing.Size(255, 293);
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
            this.groupBox4.Location = new System.Drawing.Point(10, 596);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1281, 104);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Location to Save Results";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 700);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 56);
            this.panel1.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculate.AutoSize = true;
            this.buttonCalculate.Location = new System.Drawing.Point(1173, 715);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(118, 27);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate and Export!";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorkspaceToolStripMenuItem,
            this.saveWorkspaceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1281, 26);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openWorkspaceToolStripMenuItem
            // 
            this.openWorkspaceToolStripMenuItem.Image = global::WorkflowApp.Properties.Resources.document_inspector_16px;
            this.openWorkspaceToolStripMenuItem.Name = "openWorkspaceToolStripMenuItem";
            this.openWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.openWorkspaceToolStripMenuItem.Text = "Open Workspace...";
            // 
            // saveWorkspaceToolStripMenuItem
            // 
            this.saveWorkspaceToolStripMenuItem.Image = global::WorkflowApp.Properties.Resources.save_as_16px;
            this.saveWorkspaceToolStripMenuItem.Name = "saveWorkspaceToolStripMenuItem";
            this.saveWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.saveWorkspaceToolStripMenuItem.Text = "Save Workspace...";
            // 
            // linkLabelSelectAllFiles
            // 
            this.linkLabelSelectAllFiles.AutoSize = true;
            this.linkLabelSelectAllFiles.Location = new System.Drawing.Point(791, 34);
            this.linkLabelSelectAllFiles.Name = "linkLabelSelectAllFiles";
            this.linkLabelSelectAllFiles.Size = new System.Drawing.Size(89, 17);
            this.linkLabelSelectAllFiles.TabIndex = 15;
            this.linkLabelSelectAllFiles.TabStop = true;
            this.linkLabelSelectAllFiles.Text = "Select All Files";
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.AutoSize = true;
            this.buttonAddFiles.ContextMenuStrip = this.contextMenuStripAddDataScoring;
            this.buttonAddFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddFiles.Location = new System.Drawing.Point(3, 3);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(136, 27);
            this.buttonAddFiles.SplitMenuStrip = this.contextMenuStripAddDataScoring;
            this.buttonAddFiles.TabIndex = 4;
            this.buttonAddFiles.Text = "Add AGD File(s)...";
            this.buttonAddFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxCalculateWtv
            // 
            this.checkBoxCalculateWtv.AutoSize = true;
            this.checkBoxCalculateWtv.Checked = true;
            this.checkBoxCalculateWtv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCalculateWtv.Location = new System.Drawing.Point(26, 31);
            this.checkBoxCalculateWtv.Name = "checkBoxCalculateWtv";
            this.checkBoxCalculateWtv.Size = new System.Drawing.Size(208, 21);
            this.checkBoxCalculateWtv.TabIndex = 9;
            this.checkBoxCalculateWtv.Text = "Calculate Wear Time Validation";
            this.checkBoxCalculateWtv.UseVisualStyleBackColor = true;
            // 
            // WorkFlowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 766);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "WorkFlowForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "This Does Everything!";
            this.contextMenuStripAddDataScoring.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ContextMenuStrip contextMenuStripAddDataScoring;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuAddFiles;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuAddDirectory;
        private SplitButton buttonAddFiles;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxWtvAlgorithm;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorkspaceToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelFiltersCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelFilesCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBoxFiles;
        private System.Windows.Forms.LinkLabel linkLabelSelectAllFiles;
        private System.Windows.Forms.CheckBox checkBoxCalculateWtv;

    }
}

