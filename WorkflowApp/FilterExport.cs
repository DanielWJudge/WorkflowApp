using System.Collections.Generic;

namespace WorkflowApp
{
    public class FilterExport
    {
        public string Name { get; set; }

        private readonly List<ScoringFilter> _scoringFilters;

        public IEnumerable<ScoringFilter> ScoringFilters
        {
            get { return _scoringFilters; }
        }

        public FilterExport(string name)
        {
            Name = name;
            _scoringFilters = new List<ScoringFilter>();
        }

        public void SetUseForFilter(ScoringFilter filter)
        {
            foreach (var scoringFilter in _scoringFilters)
                if (scoringFilter.Equals(filter))
                    scoringFilter.Use = true;
        }

        public void AddFilter(ScoringFilter filter)
        {
            _scoringFilters.Add(new ScoringFilter(filter));
        }

        public void AddFilterRange(IEnumerable<ScoringFilter> filters)
        {
            foreach (var scoringFilter in filters)
                AddFilter(scoringFilter);
        }

        public void ClearFilters()
        {
            _scoringFilters.Clear();
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