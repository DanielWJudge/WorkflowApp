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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.contextMenuStripAddDataScoring = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuAddFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAddDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.wizardPages1 = new WorkflowApp.WizardPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.buttonAddFiles = new WorkflowApp.SplitButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxWtvAlgorith = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.listBoxFilters = new System.Windows.Forms.ListBox();
            this.buttonOpenFilters = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.comboBoxExportType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contextMenuStripAddDataScoring.SuspendLayout();
            this.wizardPages1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 45);
            this.panel1.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.AutoSize = true;
            this.buttonBack.Enabled = false;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(427, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(83, 27);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.AutoSize = true;
            this.buttonNext.Location = new System.Drawing.Point(516, 6);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(83, 27);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Next >";
            this.buttonNext.UseVisualStyleBackColor = true;
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
            // wizardPages1
            // 
            this.wizardPages1.Controls.Add(this.tabPage1);
            this.wizardPages1.Controls.Add(this.tabPage2);
            this.wizardPages1.Controls.Add(this.tabPage3);
            this.wizardPages1.Controls.Add(this.tabPage4);
            this.wizardPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPages1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardPages1.Location = new System.Drawing.Point(0, 0);
            this.wizardPages1.Name = "wizardPages1";
            this.wizardPages1.SelectedIndex = 0;
            this.wizardPages1.Size = new System.Drawing.Size(613, 326);
            this.wizardPages1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.listBoxFiles);
            this.tabPage1.Controls.Add(this.buttonAddFiles);
            this.tabPage1.Controls.Add(this.lblHeader);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(605, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.Location = new System.Drawing.Point(196, 44);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(77, 27);
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
            this.listBoxFiles.Location = new System.Drawing.Point(34, 77);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(562, 191);
            this.listBoxFiles.TabIndex = 5;
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.AutoSize = true;
            this.buttonAddFiles.ContextMenuStrip = this.contextMenuStripAddDataScoring;
            this.buttonAddFiles.Location = new System.Drawing.Point(34, 44);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(136, 27);
            this.buttonAddFiles.SplitMenuStrip = this.contextMenuStripAddDataScoring;
            this.buttonAddFiles.TabIndex = 4;
            this.buttonAddFiles.Text = "Add AGD File(s)...";
            this.buttonAddFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHeader.Location = new System.Drawing.Point(8, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(171, 21);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Select Files to Calculate";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.comboBoxWtvAlgorith);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(605, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(250, 96);
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
            this.label5.Location = new System.Drawing.Point(45, 100);
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
            this.comboBoxWtvAlgorith.Location = new System.Drawing.Point(250, 51);
            this.comboBoxWtvAlgorith.Name = "comboBoxWtvAlgorith";
            this.comboBoxWtvAlgorith.Size = new System.Drawing.Size(121, 25);
            this.comboBoxWtvAlgorith.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wear Time Validation Algorithm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Wear Time Validation Options";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonClearFilters);
            this.tabPage3.Controls.Add(this.listBoxFilters);
            this.tabPage3.Controls.Add(this.buttonOpenFilters);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(605, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.AutoSize = true;
            this.buttonClearFilters.Location = new System.Drawing.Point(261, 44);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(86, 27);
            this.buttonClearFilters.TabIndex = 9;
            this.buttonClearFilters.Text = "Clear Filters";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            // 
            // listBoxFilters
            // 
            this.listBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFilters.FormattingEnabled = true;
            this.listBoxFilters.ItemHeight = 17;
            this.listBoxFilters.Location = new System.Drawing.Point(34, 77);
            this.listBoxFilters.Name = "listBoxFilters";
            this.listBoxFilters.Size = new System.Drawing.Size(562, 191);
            this.listBoxFilters.TabIndex = 8;
            // 
            // buttonOpenFilters
            // 
            this.buttonOpenFilters.AutoSize = true;
            this.buttonOpenFilters.Location = new System.Drawing.Point(34, 44);
            this.buttonOpenFilters.Name = "buttonOpenFilters";
            this.buttonOpenFilters.Size = new System.Drawing.Size(203, 27);
            this.buttonOpenFilters.TabIndex = 7;
            this.buttonOpenFilters.Text = "Open Global Date/Time Filters...";
            this.buttonOpenFilters.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Filters for Each Export";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBoxExportType);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.textBoxDirectory);
            this.tabPage4.Controls.Add(this.buttonSelectFolder);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(605, 296);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Location to Save Results";
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.AutoSize = true;
            this.buttonSelectFolder.Location = new System.Drawing.Point(34, 44);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(178, 27);
            this.buttonSelectFolder.TabIndex = 10;
            this.buttonSelectFolder.Text = "Select Folder to Save Files...";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(218, 46);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(378, 25);
            this.textBoxDirectory.TabIndex = 11;
            // 
            // comboBoxExportType
            // 
            this.comboBoxExportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExportType.FormattingEnabled = true;
            this.comboBoxExportType.Items.AddRange(new object[] {
            "CSV",
            "Excel"});
            this.comboBoxExportType.Location = new System.Drawing.Point(218, 86);
            this.comboBoxExportType.Name = "comboBoxExportType";
            this.comboBoxExportType.Size = new System.Drawing.Size(121, 25);
            this.comboBoxExportType.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Export Type:";
            // 
            // WorkFlowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 371);
            this.Controls.Add(this.wizardPages1);
            this.Controls.Add(this.panel1);
            this.Name = "WorkFlowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "This Does Everything!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStripAddDataScoring.ResumeLayout(false);
            this.wizardPages1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WizardPages wizardPages1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        protected System.Windows.Forms.Label lblHeader;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.ListBox listBoxFilters;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.ComboBox comboBoxExportType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonSelectFolder;

    }
}

