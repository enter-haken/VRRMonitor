using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRRMonitor
{
    public class DepartureResponse
    {
        public List<DepartureItem> DepartureData { get; set; }

        public string StationName { get; set; }

        public override string ToString()
        {
            if (DepartureData == null)
                return string.Empty;

            var sb = new StringBuilder();
            sb.AppendLine($"Station name: {StationName}");

            foreach (var result in DepartureData.Select(x => x.ToString()))
                sb.AppendLine(result);

            return sb.ToString();
        }
    }
}
