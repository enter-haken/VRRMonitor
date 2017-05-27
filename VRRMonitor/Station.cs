using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace VRRMonitor
{
    public class Station
    {
        public int StationId { get; set; }
        public string StationName { get; set; }

        public int RowCount { get; set; } = 12;

        public List<Train> Filters { get; set; }

        public List<MeansOfTransport> MeansOfTransport { get; set; } = new List<MeansOfTransport> {
            VRRMonitor.MeansOfTransport.SBahn,
            VRRMonitor.MeansOfTransport.Zug };

        public string MeansOfTransportAsString
        {
            get
            {
                return string.Join(",", MeansOfTransport.Cast<int>());
            }
        }

        public bool HasFilter
        {
            get
            {
                return Filters != null && Filters.Count > 0;
            }
        }

        public string FilterString
        {
            get
            {
                if (!HasFilter)
                    return string.Empty;

                return JsonConvert.SerializeObject(Filters, 
                    Formatting.None, 
                    new JsonSerializerSettings
                    {
                        ContractResolver = new LowerCaseContractResolver()
                    });
            }
        }
    }
}
