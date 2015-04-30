using System.Collections.Generic;

namespace WorkflowApp
{
    public class WtvResult
    {
        public string Filename { get; set; }
        public string SubjectName { get; set; }
        public string SerialNumber { get; set; }
        public Dictionary<string, double> SummaryStats { get; set; }

        public WtvResult()
        {
            SummaryStats = new Dictionary<string, double>();
        }
    }
}