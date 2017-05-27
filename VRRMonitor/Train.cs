using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRRMonitor
{
    public class Train
    {
        public string Data { get; set; }

        public string Value { get; set; }

        public static Train RE1
        {
            get
            {
                return new Train
                {
                    Data = "ddb:90E01:+:H",
                    Value = "Zug+|+RE1+|+Hamm,+Hbf./Willy-Brandt-Platz"
                };
            }
        }

        public static Train RE6
        {
            get
            {
                return new Train
                {
                    Data = "ddb:90E06:+:H",
                    Value = "Zug+|+RE6+|+Minden,+Bahnhof"
                };
            }
        }
        
        public static Train RE11
        {
            get
            {
                return new Train
                {
                    Data = "ddb:90E11:+:H",
                    Value = "Zug+|+RE11+|+Kassel-Wilhelmshöhe"
                };
            }
        }

        public static Train S2
        {
            get
            {
                return new Train
                {
                    Data = "ddb:92E02:+:H",
                    Value = "S-Bahn+|+S2+|+Dortmund+Hbf"
                };
            }
        }

        public static Train RE3
        {
            get {
                return new Train
                {
                    Data = "ddb:90E03:+:H",
                    Value = "Zug+|+RE3+|+Hamm,+Hbf./Willy-Brandt-Platz"
                };
            }
        }
    }
}
