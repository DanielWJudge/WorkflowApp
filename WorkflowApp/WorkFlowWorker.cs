using System.Collections.Generic;
using System.Linq;

namespace WorkflowApp
{
    public class WorkFlowWorker
    {
        private readonly List<string> _files;
        private readonly List<ScoringFilter> _filters;

        public List<FilterExport> FilterExports;

        public WorkFlowWorker()
        {
            _files = new List<string>(100);
            _filters = new List<ScoringFilter>(50);
            FilterExports = new List<FilterExport>(12);

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

        public int FilesCount
        {
            get { return _files.Count; }
        }

        public IEnumerable<string> Files
        {
            get { return _files; }
        }

        public int FiltersCount
        {
            get { return _filters.Count; }
        }

        public IEnumerable<ScoringFilter> Filters
        {
            get { return _filters; }
        }

        public void AddFiles(IEnumerable<string> fileNames)
        {
            _files.AddRange(fileNames.Where(fileName => !_files.Contains(fileName)));
        }

        public void ClearFiles()
        {
            _files.Clear();
        }

        public void AddFilters(IEnumerable<ScoringFilter> filters)
        {
            var scoringFilters = filters.Where(filter => !_filters.Contains(filter)).ToList();
            _filters.AddRange(scoringFilters);

            foreach (FilterExport filterExport in FilterExports)
                filterExport.AddFilterRange(scoringFilters);
        }

        public void ClearFilters()
        {
            _filters.Clear();

            foreach (var filterExport in FilterExports)
                filterExport.ClearFilters();
        }
    }
}