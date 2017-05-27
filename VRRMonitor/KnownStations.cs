using System.Collections.Generic;
using System.Linq;

namespace VRRMonitor
{
    public static class KnownStations
    {
        private static List<Station> Stations; 

        static KnownStations()
        {
            Stations = new List<Station>
                {
                    new Station
                    {
                        StationId = 20005613,
                        StationName = "Gelsenkirchen,+Hbf",
                        Filters = new List<Train> { Train.RE3, Train.S2 }
                    },
                    new Station
                    {
                        StationId = 20007501,
                        StationName = "Herne+Bf",
                        RowCount = 24
                    },
                    new Station
                    {
                        StationId = 20000522,
                        StationName = "Zeche+Minister+Stein",
                        MeansOfTransport = new List<MeansOfTransport> { MeansOfTransport.UBahn }
                    },
                    new Station
                    {
                        StationId = 20005503,
                        StationName = "Bochum+Wattenscheid+Bf",
                        Filters = new List<Train> { Train.RE1, Train.RE6, Train.RE11 },
                        RowCount = 12
                    },
                    new Station
                    {
                        StationId = 20000131,
                        StationName = "Dortmund+Hbf",
                        MeansOfTransport = new List<MeansOfTransport>
                        {
                            MeansOfTransport.SBahn,
                            MeansOfTransport.Zug,
                            MeansOfTransport.UBahn
                        },
                        RowCount = 24
                    }
                };
        }

        public static Station GetBy(string name)
        {
            return Stations.FirstOrDefault(x => x.StationName.ToLower().Contains(name.ToLower()));
        }
    }
}
