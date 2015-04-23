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

        public WorkFlowForm()
        {
            InitializeComponent();

            HandleCreated += (o, e) =>
            {
                wizardPages1.SetTabBackColorForOS();
                comboBoxWtvAlgorith.SelectedIndex = 0;
                comboBoxExportType.SelectedIndex = 0;
            };

            buttonNext.Click += (sender, args) =>
            {
                switch (wizardPages1.SelectedIndex)
                {
                    case 0:
                        if (_workFlowWorker.FilesCount > 0)
                            wizardPages1.SelectedIndex = wizardPages1.SelectedIndex + 1;
                        else
                            MessageBox.Show(this, "Please add some AGD files to calculate.", "No Files Added",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case 1:
                        wizardPages1.SelectedIndex = wizardPages1.SelectedIndex + 1;
                        break;

                    case 2:
                        if (_workFlowWorker.FiltersCount > 0)
                            wizardPages1.SelectedIndex = wizardPages1.SelectedIndex + 1;
                        else
                            MessageBox.Show(this, "Please add some global date/time filters files to calculate.", "No Filters Added",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case 3:
                        //run stuff
                        break;
                }
            };

            buttonBack.Click += (sender, args) => wizardPages1.SelectedIndex = wizardPages1.SelectedIndex - 1;

            wizardPages1.SelectedIndexChanged += (sender, args) =>
            {
                buttonBack.Enabled = (wizardPages1.SelectedIndex != 0);
                buttonNext.Text = wizardPages1.SelectedIndex == wizardPages1.TabCount - 1 ? "Finish" : "Next >";
            };

            buttonAddFiles.Click += (sender, args) => AddFilesMenuClick();
            buttonClear.Click += (sender, args) =>
            {
                var result = MessageBox.Show(this, "Are you sure you want to clear all files? This cannot be undone.",
                    "Remove All Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _workFlowWorker.ClearFiles();
                    listBoxFiles.Items.Clear();
                }
            };
            buttonClearFilters.Click += (sender, args) =>
            {
                var result = MessageBox.Show(this, "Are you sure you want to clear all filters? This cannot be undone.",
                    "Remove All Filters", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _workFlowWorker.ClearFilters();
                    listBoxFilters.Items.Clear();
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

            buttonOpenFilters.Click += (sender, args) => OpenFilters();

            _workFlowWorker = new WorkFlowWorker();
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
                    using (StreamReader re = new StreamReader(filename))
                        json = re.ReadToEnd();

                    if (json.Length > 0)
                    {
                        try
                        {
                            var scoringFilters = JsonConvert.DeserializeObject<List<ScoringFilter>>(json);
                            _workFlowWorker.AddFilters(scoringFilters);

                            listBoxFilters.Items.Clear();
                            listBoxFilters.Items.AddRange(_workFlowWorker.Filters.ToArray());
                        }
                        catch { }
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
                var files = Helpers.GetFilesRecursive(currentDirectory, "*.agd");
                if (!files.Any())
                {
                    MessageBox.Show(this, "The selected directory does not contain any files.", "No files found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            listBoxFiles.Items.AddRange(_workFlowWorker.Files.ToArray());
        }
    }

    public class WorkFlowWorker
    {
        private readonly List<string> _files;
        private readonly List<ScoringFilter> _filters; 

        public int FilesCount
        {
            get { return _files.Count; }
        }

        public IEnumerable<string> Files
        {
            get { return _files; }
        }

        public void AddFiles(IEnumerable<string> fileNames)
        {
            _files.AddRange(fileNames.Where(fileName => !_files.Contains(fileName)));
        }

        public void ClearFiles()
        {
            _files.Clear();
        }

        public int FiltersCount
        {
            get { return _filters.Count; }
        }

        public IEnumerable<ScoringFilter> Filters
        {
            get { return _filters; }
        }

        public void AddFilters(IEnumerable<ScoringFilter> filters)
        {
            _filters.AddRange(filters.Where(filter => !_filters.Contains(filter)));
        }

        public void ClearFilters()
        {
            _filters.Clear();
        }

        public WorkFlowWorker()
        {
            _files = new List<string>(100);
            _filters = new List<ScoringFilter>(50);
        }
    }
}