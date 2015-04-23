using System;
using System.Globalization;

namespace WorkflowApp
{
    public class ScoringFilter
    {
        public enum FilterType { AllDays, Weekdays, Weekends, DayOfTheWeek, SpecificDate, DayRange, DateRange, SpecificTime };

        public FilterType Type { get; set; }
        public string Name { get; set; }
        public bool Use { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }

        /// <summary>
        /// day of the week number.  0 is Sunday, 1 is Monday ... 6 is Saturday
        /// </summary>
        public int DayOfTheWeek { get; set; }
        public int DayRangeStart { get; set; }
        public int DayRangeEnd { get; set; }
        public DateTime SpecificDate { get; set; }
        public DateTime DateRangeStart { get; set; }
        public DateTime DateRangeEnd { get; set; }

        public ScoringFilter()
        {
            Use = true;
        }

        public ScoringFilter(ScoringFilter sf)
        {
            Type = sf.Type;
            Name = sf.Name;
            Use = sf.Use;
            StartTime = sf.StartTime;
            StopTime = sf.StopTime;
            DayOfTheWeek = sf.DayOfTheWeek;
            DayRangeEnd = sf.DayRangeEnd;
            DayRangeStart = sf.DayRangeStart;
            SpecificDate = sf.SpecificDate;
            DateRangeStart = sf.DateRangeStart;
            DateRangeEnd = sf.DateRangeEnd;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ScoringFilter)) return false;
            return Equals((ScoringFilter)obj);
        }

        public bool Equals(ScoringFilter other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Type, Type) && Equals(other.Name, Name) && other.Use.Equals(Use) && other.StartTime.Equals(StartTime) && other.StopTime.Equals(StopTime) && other.DayOfTheWeek == DayOfTheWeek && other.SpecificDate.Equals(SpecificDate);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = Type.GetHashCode();
                result = (result * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                result = (result * 397) ^ Use.GetHashCode();
                result = (result * 397) ^ StartTime.TimeOfDay.GetHashCode();
                result = (result * 397) ^ StopTime.TimeOfDay.GetHashCode();
                result = (result * 397) ^ DayOfTheWeek;
                result = (result * 397) ^ SpecificDate.Date.GetHashCode();
                return result;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2:t} - {3:t}", Name, GetTitleOfDataScoringDateFilter(), StartTime, StopTime);
        }

        public string GetTitleOfDataScoringDateFilter()
        {
            var dayNames = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
            string title = "";
            switch (Type)
            {
                case FilterType.AllDays:
                    title = "All Days";
                    break;
                case FilterType.Weekdays:
                    title = "Weekdays";
                    break;
                case FilterType.Weekends:
                    title = "Weekends";
                    break;
                case FilterType.DayOfTheWeek:
                    title = dayNames[DayOfTheWeek];
                    break;
                case FilterType.SpecificDate:
                    title = SpecificDate.ToShortDateString();
                    break;
                case FilterType.DayRange:
                    title = string.Format("{0} -\r\n{1}", dayNames[DayRangeStart], dayNames[DayRangeEnd]);
                    break;
                case FilterType.DateRange:
                    title = string.Format("{0} -\r\n{1}", DateRangeStart.ToShortDateString(), DateRangeEnd.ToShortDateString());
                    break;
            }

            return title;
        }
    }
}