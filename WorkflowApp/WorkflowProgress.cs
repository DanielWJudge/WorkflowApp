using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ActiLifeAPILibrary;
using ActiLifeAPILibrary.Models.Actions;
using ActiLifeAPILibrary.Models.WearTimeValidation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DataScoringExport = ActiLifeAPILibrary.Models.Request.DataScoringExport;
using WearTimeValidation = ActiLifeAPILibrary.Models.Request.WearTimeValidation;

namespace WorkflowApp
{
    public partial class WorkflowProgress : Form
    {
        private readonly WorkFlowWorker _workFlowWorker;

        public WorkflowProgress(WorkFlowWorker workFlowWorker)
        {
            InitializeComponent();

            _workFlowWorker = workFlowWorker;

            Shown += (sender, args) => StartProgress();
            richTextBox1.TextChanged += (sender, args) =>
            {
                richTextBox1.SelectionStart = richTextBox1.Text.Length; //Set the current caret position at the end
                richTextBox1.ScrollToCaret(); //Now scroll it automatically
            };
        }

        private async void StartProgress()
        {
            using (var api = new ActiLifeAPIConnection())
            {
                LogToTextBox("Connecting to ActiLife API\r\n");
                try
                {
                    await api.Connect(5000);
                }
                catch (Exceptions.APIConnectionException ex)
                {
                    LogToTextBox("Unable to connect to ActiLife API\r\n");
                    MessageBox.Show(this, ex.Message, "Can't connect to ActiLife!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LogToTextBox("Connected to ActiLife API\r\n");

                LogToTextBox("Getting version of ActiLife API\r\n");
                /*
                {
                    "Action": "APIVersion"
                }
                 * */

                var apiVersionResponse = await api.APIVersion();

                JObject jobject = JsonConvert.DeserializeObject<JObject>(apiVersionResponse);

                JToken value;
                if (jobject.TryGetValue("Payload", StringComparison.CurrentCultureIgnoreCase, out value))
                {
                    JToken apiVersion;
                    if (((JObject) value).TryGetValue("version", StringComparison.CurrentCultureIgnoreCase, out apiVersion))
                        LogToTextBox(string.Format("ActiLife API version: {0}", apiVersion));
                }

                var files = _workFlowWorker.Files.ToArray();

                FloatingWindowWTVOptions floatingOptions = null;
                switch (_workFlowWorker.WearTimeValidationAlgorithm)
                {
                    case WorkFlowWorker.WTVAlgorithm.Troiano:
                        floatingOptions = TroianoWTVOptions.Default;
                        floatingOptions.UseMinimumWearTimePerDay = true;
                        floatingOptions.MinimumWearTimePerDayLength =
                            (int) _workFlowWorker.WearTimeValidationMinimumPerDay;
                        floatingOptions.MinimumWearTimePerDayUnits = FloatingWindowWTVOptions.Units.Minutes;
                        break;
                    case WorkFlowWorker.WTVAlgorithm.Choi:
                        floatingOptions = ChoiWTVOptions.Default;
                        floatingOptions.UseMinimumWearTimePerDay = true;
                        floatingOptions.MinimumWearTimePerDayLength =
                            (int) _workFlowWorker.WearTimeValidationMinimumPerDay;
                        floatingOptions.MinimumWearTimePerDayUnits = FloatingWindowWTVOptions.Units.Minutes;
                        break;
                }

                //calculate WTV
                foreach (var file in files)
                {
                    LogToTextBox("Calculating Wear Time Validation for: " + file + "\r\n");
                    var wtv = new WearTimeValidation
                    {
                        Options =
                        {
                            Algorithm = _workFlowWorker.WearTimeValidationAlgorithm.ToString(),
                            FileInputPath = file,
                            ChoiOptions = _workFlowWorker.WearTimeValidationAlgorithm == WorkFlowWorker.WTVAlgorithm.Choi ? (ChoiWTVOptions) floatingOptions : null,
                            TroianoOptions = _workFlowWorker.WearTimeValidationAlgorithm == WorkFlowWorker.WTVAlgorithm.Troiano ? (TroianoWTVOptions) floatingOptions : null

                        }
                    };
                    await api.WearTimeValidation(wtv);
                }
                
                //loop through filter exports
                foreach (var filterExport in _workFlowWorker.FilterExports)
                {
                    string directory = _workFlowWorker.DirectoryToSaveResults + "\\" + filterExport.Name;
                    if (!Directory.Exists(directory))
                        Directory.CreateDirectory(directory);

                    LogToTextBox("Calculating and exporting: " + filterExport.Name + " to directory: " + directory + "\r\n");
                    //calculate data scoring and export

                    var dataScoringExport = new DataScoringExport
                    {
                        Options =
                        {
                            FileInputPaths = files,
                            ExportLocation = directory,
                            ExportFileType = _workFlowWorker.ExportType,
                            CalculateEnergyExpenditure = false,
                            CalculateMETs = false,
                            BatchExportSheetOptions = new BatchExportSheetOptions
                            {
                                AddDefinitionComments = false,
                                AddDefinitionWorksheet = false,
                                AddWtv = true,
                                ShowNonWear = false,
                                ShowSummary = true,
                                ShowDaily = false,
                                ShowHourly = false,
                                AddSleepScores = false,
                                ShowBoutDetails = false,
                                ShowSedentaryDetails = false,
                            },
                            CalculateCutPoints = true,
                            CutPointOptions = new CutPointOptions
                            {
                                Algorithm = "EvensonChildren2008"
                            },
                            CalculateBouts = false,
                            CalculateSedentaryAnalysis = false,
                            IncludeExtraStatistics = true,
                            FilterOptions = new FilterOptions
                            {
                                UseLogDiaries = false,
                                UseWTVData = true,
                                GlobalDateTimeFilterOptions = new GlobalDateTimeFilterOptions
                                {
                                    UseGlobalDateTimeFilters = true,
                                    GlobalDateTimeFilters = filterExport.ScoringFilters.Where(x => x.Use).ToList()
                                }
                            }

                        }
                    };

                    await api.DataScoringExport(dataScoringExport);
                }
                
                //FINISH!
                LogToTextBox("Finished!\r\n");

                var foo = JsonConvert.SerializeObject(_workFlowWorker, Formatting.Indented);

                var bar = JsonConvert.DeserializeObject<WorkFlowWorker>(foo);

                Console.WriteLine(bar);
            }
        }

        private void LogToTextBox(string message)
        {
            richTextBox1.AppendText(string.Format("{0:G} - " + message, DateTime.Now));
        }
    }
}
