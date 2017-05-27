using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace VRRMonitor
{
    public class Program
    {
        static void Main(string[] args)
        {
            var station = GetStationBy(args);

            var task = GetDepartureBy(station);
            Console.WriteLine(task.Result);
        }

        private static Station GetStationBy(string[] args)
        {
            var defaultStation = KnownStations.GetBy("gelsenkirchen");

            if (args == null || args.Length <= 0)
                return defaultStation;

            var result = KnownStations.GetBy(args[0]);

            if (result == null)
                return defaultStation;

            return result;
        }

        static async Task<DepartureResponse> GetDepartureBy(Station station)
        {
            var client = new HttpClient();

            var departure = new Dictionary<string, string>
            {
                { "table[departure][stationId]" , station.StationId.ToString() },
                { "table[departure][stationName]", station.StationName },
                { "table[departure][platformVisibility]", "1" },
                { "table[departure][transport]" , station.MeansOfTransportAsString },
                { "table[departure][rowCount]", station.RowCount.ToString() },
                { "table[departure][distance]", "0" },
                { "table[departure][marquee]", "0" },
                { "table[sortBy]", "0" }
            };

            if (station.HasFilter)
            {
                departure.Add("table[departure][useAllLines]", "0");
                departure.Add("table[departure][linesFilter]", station.FilterString);
            }
            else
            {
                departure.Add("table[departure][useAllLines]", "1");
                departure.Add("table[departure][linesFilter]", "");
            }

            var content = new FormUrlEncodedContent(departure);
            var response = await client.PostAsync("http://abfahrtsmonitor.vrr.de/backend/app.php/api/stations/table", content);
            var responseString = await response.Content.ReadAsStringAsync();
            var typedResult = JsonConvert.DeserializeObject<DepartureResponse>(responseString);

            return typedResult;
        }
    }
}
