using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WorkflowApp
{
    public partial class WorkFlowForm : Form
    {
        private readonly WorkFlowWorker _workFlowWorker;
        private FilterExport _lastFilter;

        public WorkFlowForm()
        {
            InitializeComponent();
            _lastFilter = null;
            _workFlowWorker = new WorkFlowWorker();

            HandleCreated += (o, e) =>
            {
                comboBoxWtvAlgorith.SelectedIndex = 0;
                comboBoxExportType.SelectedIndex = 0;
                foreach (var filterExport in _workFlowWorker.FilterExports)
                    listBoxFilterExports.Items.Add(filterExport);

                listBoxFilterExports.SelectedIndex = 0;
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
                    listBoxFiles.Items.Clear();
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

            listBoxFilterExports.SelectedIndexChanged += (sender, args) => SaveFiltersAndUpdateUI();

            buttonOpenFilters.Click += (sender, args) => OpenFilters();
        }

        private void SaveFiltersAndUpdateUI()
        {
            if (_lastFilter == null)
            {
                checkedListBoxFilters.ClearSelected();
                _lastFilter = (FilterExport)listBoxFilterExports.SelectedItem;
                return;
            }

            var selectedItems = checkedListBoxFilters.CheckedItems;
            foreach (var scoringFilter in _lastFilter.ScoringFilters)
                scoringFilter.Use = false;

            foreach (ScoringFilter selectedItem in selectedItems)
                _lastFilter.SetUseForFilter(selectedItem);

            _lastFilter = (FilterExport) listBoxFilterExports.SelectedItem;

            for (int i = 0; i < checkedListBoxFilters.Items.Count; i++)
                checkedListBoxFilters.SetItemChecked(i, false);

            IEnumerable<ScoringFilter> scoringFilters = _lastFilter.ScoringFilters.Where(x => x.Use);
            if (!scoringFilters.Any())
                return;

            for (int i = 0; i < checkedListBoxFilters.Items.Count; i++)
                if (scoringFilters.Contains(checkedListBoxFilters.Items[i]))
                    checkedListBoxFilters.SetItemChecked(i, true);
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
            listBoxFiles.Items.Clear();
            foreach (var file in _workFlowWorker.Files)
                listBoxFiles.Items.Add(file);
        }
    }
}