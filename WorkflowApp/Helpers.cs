using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using ActiLifeAPILibrary.Models.Actions;
using Ookii.Dialogs;

namespace WorkflowApp
{
    public static class Helpers
    {
        public static List<string> GetFilesRecursive(string b, string filter = "*.*")
        {
            // 1.
            // Store results in the file results list.
            List<string> result = new List<string>();

            // 2.
            // Store a stack of our directories.
            Stack<string> stack = new Stack<string>();

            // 3.
            // Add initial directory.
            stack.Push(b);

            // 4.
            // Continue while there are directories to process
            while (stack.Count > 0)
            {
                // A.
                // Get top directory
                string dir = stack.Pop();

                try
                {
                    // B
                    // Add all files at this directory to the result List.
                    result.AddRange(Directory.GetFiles(dir, filter));

                    // C
                    // Add all directories at this directory.
                    foreach (string dn in Directory.GetDirectories(dir))
                    {
                        stack.Push(dn);
                    }
                }
                catch
                {
                }
            }
            return result;
        }

        public static string SelectFolder(string startingDirectory = "")
        {
            if (string.IsNullOrEmpty(startingDirectory) || !System.IO.Directory.Exists(startingDirectory))
                startingDirectory = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            if (VistaFileDialog.IsVistaFileDialogSupported)
                using (var v = new VistaFolderBrowserDialog())
                {
                    v.SelectedPath = startingDirectory;
                    if (v.ShowDialog() == DialogResult.OK)
                        return v.SelectedPath;
                }
            else
            {
                using (var f = new FolderBrowserDialog())
                {
                    f.SelectedPath = startingDirectory;
                    if (f.ShowDialog() == DialogResult.OK)
                        return f.SelectedPath;
                }
            }
            return string.Empty;
        }

        public static string GetTitleOfDataScoringDateFilter(this ScoringFilter scoringFilter)
        {
            var dayNames = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
            string title = "";
            switch (scoringFilter.Type)
            {
                case ScoringFilter.FilterType.AllDays:
                    title = "All Days";
                    break;
                case ScoringFilter.FilterType.Weekdays:
                    title = "Weekdays";
                    break;
                case ScoringFilter.FilterType.Weekends:
                    title = "Weekends";
                    break;
                case ScoringFilter.FilterType.DayOfTheWeek:
                    title = dayNames[scoringFilter.DayOfTheWeek];
                    break;
                case ScoringFilter.FilterType.SpecificDate:
                    title = scoringFilter.SpecificDate.ToShortDateString();
                    break;
                case ScoringFilter.FilterType.DayRange:
                    title = string.Format("{0} -\r\n{1}", dayNames[scoringFilter.DayRangeStart], dayNames[scoringFilter.DayRangeEnd]);
                    break;
                case ScoringFilter.FilterType.DateRange:
                    title = string.Format("{0} -\r\n{1}", scoringFilter.DateRangeStart.ToShortDateString(), scoringFilter.DateRangeEnd.ToShortDateString());
                    break;
            }

            return title;
        }
    }
}