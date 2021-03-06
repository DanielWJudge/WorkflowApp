using System.Collections.Generic;
using ActiLifeAPILibrary.Models.Actions;

namespace WorkflowApp
{
    public class FilterExport
    {
        public string Name { get; set; }

        public List<ScoringFilter> ScoringFilters { get; set; }

        public List<string> Files { get; set; }
        
        public FilterExport(string name)
        {
            Name = name;
            ScoringFilters = new List<ScoringFilter>();
            Files = new List<string>();
        }

        public void SetUseForFilter(ScoringFilter filter, bool use)
        {
            foreach (var scoringFilter in ScoringFilters)
                if (scoringFilter.Equals(filter))
                {
                    scoringFilter.Use = use;
                    return;
                }
        }

        public void AddFilter(ScoringFilter filter)
        {
            ScoringFilters.Add(new ScoringFilter(filter));
        }

        public void AddFilterRange(IEnumerable<ScoringFilter> filters)
        {
            foreach (var scoringFilter in filters)
                AddFilter(scoringFilter);
        }

        public void ClearFilters()
        {
            ScoringFilters.Clear();
        }

        public void ClearFiles()
        {
            Files.Clear();
        }

        public override string ToString()
        {
            return Name;
        }

        protected bool Equals(FilterExport other)
        {
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((FilterExport) obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}