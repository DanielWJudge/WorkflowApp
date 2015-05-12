using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ActiLifeAPILibrary.Models.Actions;
using Newtonsoft.Json;

namespace WorkflowApp
{
    public partial class WorkFlowForm : Form
    {
        private WorkFlowWorker _workFlowWorker;
        private FilterExport _currentFilterExport;

        public WorkFlowForm()
        {
            InitializeComponent();
            _currentFilterExport = null;
            _workFlowWorker = new WorkFlowWorker();
            _workFlowWorker.CreateDefaultFilterExports();

            HandleCreated += (o, e) =>
            {
                comboBoxExportType.Items.Add(DataScoringExport.ExportType.Csv);
                comboBoxExportType.Items.Add(DataScoringExport.ExportType.Excel);

                comboBoxWtvAlgorithm.Items.Add(WorkFlowWorker.WTVAlgorithm.Troiano);
                comboBoxWtvAlgorithm.Items.Add(WorkFlowWorker.WTVAlgorithm.Choi);

                comboBoxWtvAlgorithm.SelectedIndex = 0;
                comboBoxExportType.SelectedIndex = 0;
                foreach (var filterExport in _workFlowWorker.FilterExports)
                    listBoxFilterExports.Items.Add(filterExport);

                listBoxFilterExports.SelectedIndex = 0;

                textBoxDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            };

            buttonAddFiles.Click += (sender, args) => AddFilesMenuClick();
            buttonClear.Click += (sender, args) =>
            {
                DialogResult result = MessageBox.Show(this,
                    "Are you sure you want to clear all files? This cannot be undone.",
                    "Remove All Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _workFlowWorker.ClearFiles();
                    checkedListBoxFiles.Items.Clear();
                    labelFilesCount.Text = string.Format("{0} files loaded", _workFlowWorker.Files.Count);
                }
            };
            buttonClearFilters.Click += (sender, args) =>
            {
                DialogResult result = MessageBox.Show(this,
                    "Are you sure you want to clear all filters? This cannot be undone.",
                    "Remove All Filters", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _workFlowWorker.ClearFilters();
                    checkedListBoxFilters.Items.Clear();
                    labelFiltersCount.Text = string.Format("{0} filters loaded", _workFlowWorker.Filters.Count);
                }
            };

            toolStripMenuAddFiles.Click += (o, e) => AddFilesMenuClick();
            toolStripMenuAddDirectory.Click += (o, e) => AddDirectoryMenuClick();
            buttonSelectFolder.Click += (sender, args) =>
            {
                string currentDirectory = Helpers.SelectFolder();
                if (!string.IsNullOrEmpty(currentDirectory))
                    textBoxDirectory.Text = currentDirectory;
            };

            checkedListBoxFilters.ItemCheck += (sender, args) =>
            {
                if (_currentFilterExport != null)
                    _currentFilterExport.SetUseForFilter((ScoringFilter) checkedListBoxFilters.SelectedItem, args.NewValue == CheckState.Checked);
            };

            checkedListBoxFiles.ItemCheck += (sender, args) =>
            {
                if (_currentFilterExport != null)
                {
                    var filename = (string) checkedListBoxFiles.SelectedItem;

                    if (string.IsNullOrEmpty(filename))
                        return;

                    switch (args.NewValue)
                    {
                        case CheckState.Checked:
                            _currentFilterExport.Files.Add(filename);
                            break;
                        default:
                            if (_currentFilterExport.Files.Contains(filename))
                                _currentFilterExport.Files.Remove(filename);
                            break;
                    }
                }
            };

            saveWorkspaceToolStripMenuItem.Click += (sender, args) => SaveWorkspace();

            openWorkspaceToolStripMenuItem.Click += (sender, args) => OpenWorkspace();
            
            listBoxFilterExports.SelectedIndexChanged += (sender, args) => SelectedExportChanged();

            buttonOpenFilters.Click += (sender, args) => OpenFilters();

            buttonCalculate.Click += (sender, args) => CalculateRunExport();

            linkLabelSelectAllFiles.Click += (sender, args) =>
            {
                if (_currentFilterExport == null)
                    return;

                for (int i = 0; i < checkedListBoxFiles.Items.Count; i++)
                    checkedListBoxFiles.SetItemChecked(i, true);

                _currentFilterExport.Files.Clear();
                _currentFilterExport.Files.AddRange(_workFlowWorker.Files.Where(x => !string.IsNullOrEmpty(x)));
            };

            checkBoxCalculateWtv.CheckedChanged +=
                (sender, args) => _workFlowWorker.CalculateWearTimeValidation = checkBoxCalculateWtv.Checked;
        }

        private void SaveWorkspace()
        {
            _workFlowWorker.DirectoryToSaveResults = textBoxDirectory.Text;
            _workFlowWorker.ExportType = (DataScoringExport.ExportType) comboBoxExportType.SelectedItem;
            _workFlowWorker.CalculateWearTimeValidation = checkBoxCalculateWtv.Checked;
            _workFlowWorker.WearTimeValidationAlgorithm = (WorkFlowWorker.WTVAlgorithm) comboBoxWtvAlgorithm.SelectedItem;
            _workFlowWorker.WearTimeValidationMinimumPerDay = numericUpDown1.Value;

            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Workspace Files (*.agw)|*.agw";
                saveDialog.Title = "Select Location to Save Workspace";
                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return;

                string filename = saveDialog.FileName;
                try
                {
                    using (var fileWriter = new StreamWriter(filename))
                    {
                        string json = JsonConvert.SerializeObject(_workFlowWorker, Formatting.Indented);
                        fileWriter.Write(json);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Unable to save workspace file: " + ex.Message, "Workspace Not Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenWorkspace()
        {
            DialogResult result = MessageBox.Show(this,
                "Are you sure you want to open a workspace? You will lose any changes you've made.",
                "Open Workspace", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;
            WorkFlowWorker newWorkFlowWorker;
            using (var openFile = new OpenFileDialog())
            {
                openFile.Multiselect = false;
                openFile.Filter = "Workspace Files (*.agw)|*.agw";
                openFile.Title = "Select File";
                openFile.FileName = "";
                if (openFile.ShowDialog() != DialogResult.OK)
                    return;

                string filename = openFile.FileName;

                try
                {
                    var fileText = File.ReadAllText(filename);
                    newWorkFlowWorker = JsonConvert.DeserializeObject<WorkFlowWorker>(fileText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Unable to read workspace file: " + ex.Message, "Workspace Not Loaded",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            checkedListBoxFiles.Items.Clear();
            checkedListBoxFilters.Items.Clear();
            listBoxFilterExports.Items.Clear();

            foreach (var filterExport in newWorkFlowWorker.FilterExports)
                listBoxFilterExports.Items.Add(filterExport);

            checkedListBoxFilters.Items.Clear();
            foreach (var filter in newWorkFlowWorker.Filters)
                checkedListBoxFilters.Items.Add(filter);

            checkedListBoxFiles.Items.Clear();
            foreach (var file in newWorkFlowWorker.Files)
                checkedListBoxFiles.Items.Add(file);

            textBoxDirectory.Text = newWorkFlowWorker.DirectoryToSaveResults;
            comboBoxExportType.SelectedItem = newWorkFlowWorker.ExportType;

            checkBoxCalculateWtv.Checked = newWorkFlowWorker.CalculateWearTimeValidation;
            comboBoxWtvAlgorithm.SelectedItem = newWorkFlowWorker.WearTimeValidationAlgorithm;
            numericUpDown1.Value = newWorkFlowWorker.WearTimeValidationMinimumPerDay;

            listBoxFilterExports.SelectedIndex = 0;
            comboBoxWtvAlgorithm.SelectedIndex = 0;
            comboBoxExportType.SelectedIndex = 0;
            _workFlowWorker = newWorkFlowWorker;

            labelFilesCount.Text = string.Format("{0} files loaded", _workFlowWorker.Files.Count);
            labelFiltersCount.Text = string.Format("{0} filters loaded", _workFlowWorker.Filters.Count);
        }

        private void CalculateRunExport()
        {
            //make sure we have files entered
            if (_workFlowWorker.Files.Count == 0)
            {
                MessageBox.Show(this, "Please add some AGD files to calculate", "No Files Loaded",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            //validate export directory
            if (!Directory.Exists(textBoxDirectory.Text))
            {
                MessageBox.Show(this, "The directory you selected does not exist. Please find one that does!", "Directory Doesn't Exist",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            StringBuilder sb = new StringBuilder(1024);
            //make sure we have global date/time filters loaded
            if (_workFlowWorker.Filters.Count == 0)
                sb.AppendLine("No global date/time filters were loaded.");

            //make sure each filter export has at least one global date/time filter loaded
            foreach (var filterExport in _workFlowWorker.FilterExports)
            {
                var count = filterExport.ScoringFilters.Count(x => x.Use);
                if (count == 0)
                    sb.AppendLine(string.Format("{0} has no selected date/time filters", filterExport.Name));
            }

            if (sb.Length > 0)
            {
                DialogResult result = MessageBox.Show(this,
                    "Are you sure you want to continue? The following isn't filled out:\r\r\n" + sb,
                    "Not all areas are filled in", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
            }

            _workFlowWorker.DirectoryToSaveResults = textBoxDirectory.Text;
            _workFlowWorker.ExportType = (DataScoringExport.ExportType) comboBoxExportType.SelectedItem;
            _workFlowWorker.WearTimeValidationAlgorithm = (WorkFlowWorker.WTVAlgorithm) comboBoxWtvAlgorithm.SelectedItem;
            _workFlowWorker.WearTimeValidationMinimumPerDay = numericUpDown1.Value;

            using (var workflowProgress = new WorkflowProgress(_workFlowWorker))
                workflowProgress.ShowDialog(this);
        }

        private void SelectedExportChanged()
        {
            checkedListBoxFilters.SelectedItem = null;
            checkedListBoxFiles.SelectedItem = null;

            if (_currentFilterExport == null)
            {
                checkedListBoxFilters.ClearSelected();
                checkedListBoxFiles.ClearSelected();
                _currentFilterExport = (FilterExport)listBoxFilterExports.SelectedItem;
                return;
            }
            
            _currentFilterExport = (FilterExport) listBoxFilterExports.SelectedItem;

            for (int i = 0; i < checkedListBoxFilters.Items.Count; i++)
                checkedListBoxFilters.SetItemChecked(i, false);

            for (int i = 0; i < checkedListBoxFiles.Items.Count; i++)
                checkedListBoxFiles.SetItemChecked(i, false);

            var scoringFilters = _currentFilterExport.ScoringFilters.Where(x => x.Use);
            if (scoringFilters.Any())
                for (int i = 0; i < checkedListBoxFilters.Items.Count; i++)
                    if (scoringFilters.Contains(checkedListBoxFilters.Items[i]))
                        checkedListBoxFilters.SetItemChecked(i, true);

            var files = _currentFilterExport.Files;
            if (files.Any())
                for (int i = 0; i < checkedListBoxFiles.Items.Count; i++)
                    if (files.Contains(checkedListBoxFiles.Items[i]))
                        checkedListBoxFiles.SetItemChecked(i, true);
        }

        private void OpenFilters()
        {
            using (var openFile = new OpenFileDialog())
            {
                openFile.Multiselect = false;
                openFile.Filter = "ActiLife Global Date/Time Filters (*.aldsfilter)|*.aldsfilter";
                openFile.Title = "Select File";
                openFile.FileName = "";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string filename = openFile.FileName;
                    string json;
                    using (var re = new StreamReader(filename))
                        json = re.ReadToEnd();

                    if (json.Length > 0)
                    {
                        try
                        {
                            var scoringFilters = JsonConvert.DeserializeObject<List<ScoringFilter>>(json);
                            foreach (var scoringFilter in scoringFilters)
                                scoringFilter.Use = false;

                            _workFlowWorker.AddFilters(scoringFilters);

                            checkedListBoxFilters.Items.Clear();
                            foreach (var filter in _workFlowWorker.Filters)
                                checkedListBoxFilters.Items.Add(filter);

                            labelFiltersCount.Text = string.Format("{0} filters loaded", _workFlowWorker.Filters.Count);
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }

        private void AddFilesMenuClick()
        {
            using (var openFile = new OpenFileDialog())
            {
                openFile.Multiselect = true;
                openFile.Filter = "Files (*.agd)|*.agd";
                openFile.Title = "Select File(s)";
                openFile.FileName = "";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    AddFiles(openFile.FileNames);
                }
            }
        }

        private void AddDirectoryMenuClick()
        {
            string currentDirectory = Helpers.SelectFolder();
            if (!string.IsNullOrEmpty(currentDirectory))
            {
                List<string> files = Helpers.GetFilesRecursive(currentDirectory, "*.agd");
                if (!files.Any())
                {
                    MessageBox.Show(this, "The selected directory does not contain any files.", "No files found!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AddDirectoryMenuClick();
                    return;
                }
                AddFiles(files);
            }
        }

        private void AddFiles(IEnumerable<string> files)
        {
            _workFlowWorker.AddFiles(files);
            checkedListBoxFiles.Items.Clear();
            foreach (var file in _workFlowWorker.Files)
                checkedListBoxFiles.Items.Add(file);

            labelFilesCount.Text = string.Format("{0} files loaded", _workFlowWorker.Files.Count);
        }
    }
}