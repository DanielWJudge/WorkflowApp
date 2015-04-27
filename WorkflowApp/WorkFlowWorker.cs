using System.Collections.Generic;
using System.Linq;

namespace WorkflowApp
{
    public class WorkFlowWorker
    {
        public WorkFlowWorker()
        {
            Files = new List<string>(100);
            Filters = new List<ScoringFilter>(50);
            FilterExports = new List<FilterExport>(12);
            DirectoryToSaveResults = "";
        }

        public List<string> Files { get; set; }

        public List<ScoringFilter> Filters { get; set; }

        public List<FilterExport> FilterExports;

        public string DirectoryToSaveResults { get; set; }
        public string ExportType { get; set; }
        public string WearTimeValidationAlgorithm { get; set; }
        public decimal WearTimeValidationMinimumPerDay { get; set; }

        public void CreateDefaultFilterExports()
        {
            FilterExports.Add(new FilterExport("Total weekly PA"));
            FilterExports.Add(new FilterExport("Leisure time (school end bell to start bell on next school day)"));
            FilterExports.Add(new FilterExport("Leisure time (weekdays only)"));
            FilterExports.Add(new FilterExport("Leisure time (weekend only)"));
            FilterExports.Add(new FilterExport("School day (bell to bell)"));
            FilterExports.Add(new FilterExport("Recess"));
            FilterExports.Add(new FilterExport("Lunch"));
            FilterExports.Add(new FilterExport("Hour before maths lesson"));
            FilterExports.Add(new FilterExport("PE Lesson 1 (bell to bell)"));
            FilterExports.Add(new FilterExport("PE Lesson 2 (bell to bell)"));
            FilterExports.Add(new FilterExport("PE Lesson 3 (bell to bell)"));
            FilterExports.Add(new FilterExport("Whole days"));
        }

        public void AddFiles(IEnumerable<string> fileNames)
        {
            Files.AddRange(fileNames.Where(fileName => !Files.Contains(fileName)));
        }

        public void ClearFiles()
        {
            Files.Clear();
        }

        public void AddFilters(IEnumerable<ScoringFilter> filters)
        {
            List<ScoringFilter> scoringFilters = filters.Where(filter => !Filters.Contains(filter)).ToList();
            Filters.AddRange(scoringFilters);

            foreach (FilterExport filterExport in FilterExports)
                filterExport.AddFilterRange(scoringFilters);
        }

        public void ClearFilters()
        {
            Filters.Clear();

            foreach (FilterExport filterExport in FilterExports)
                filterExport.ClearFilters();
        }
    }
}