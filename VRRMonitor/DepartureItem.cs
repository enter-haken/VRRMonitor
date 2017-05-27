using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRRMonitor
{
    public class DepartureItem
    {
        public string Name { get; set; }
        public string LineNumber { get; set; }
        public string SubName { get; set; }
        public string Direction { get; set; }

        public string Route { get; set; }
        public MeansOfTransport Type { get; set; } 
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int OrgDay { get; set; }
        public int OrgMonth { get; set; }
        public int OrgYear { get; set; }
        public int OrgHour { get; set; }
        public int OrgMinute { get; set; }
        public string Platform { get; set; }

        public int? Delay { get; set; }

        public DateTime CurrentDeparture 
        {
            get
            {
                return new DateTime(Year, Month, Day, Hour, Minute, 0);
            }
        }

        public DateTime OriginalDeparture
        {
            get
            {
                return new DateTime(OrgYear, OrgMonth, OrgDay, OrgHour, OrgMinute, 0);
            }
        }

        public override string ToString()
        {
            return $"Aktuell {Hour.ToString("D2")}:{Minute.ToString("D2")} - Verspätung {Delay ?? 0} - {Name} - Richtung {Direction}";
        }
    }
}
