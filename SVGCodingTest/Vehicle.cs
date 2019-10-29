using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVGCodingTest
{
    public class Vehicle
    {
        public Vehicle(string type, int y1, int y2) => (Type, QuantSoldY1, QuantSoldY2, MarketY1, MarketY2, Diff) = (type, y1, y2, 0, 0, QuantDiff());
        public string Type { get; set; }

        public int QuantSoldY1 { get; set; }

        public int QuantSoldY2 { get; set; }

        public float MarketY1 { get; set; }

        public float MarketY2 { get; set; }

        public int Diff { get; set; }

        private int QuantDiff()
        {
            var result = QuantSoldY1 - QuantSoldY2;
            return result;
        }
    }
}
