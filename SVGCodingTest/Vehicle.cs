using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVGCodingTest
{
    public class Vehicle
    {
        public Vehicle(string type, int y1, int y2) => (Type, QuantSoldY1, QuantSoldY2, MarketY1, MarketY2, Diff, TopYear) = (type, y1, y2, 0, 0, QuantDiff(), TopYearCalc());
        public string Type { get; set; }

        public int QuantSoldY1 { get; set; }

        public int QuantSoldY2 { get; set; }

        public float MarketY1 { get; set; }

        public float MarketY2 { get; set; }

        public int Diff { get; set; }

        public int TopYear { get; set; }

        private int TopYearCalc()
        {
            var year = QuantSoldY1 > QuantSoldY2 ? 1 : 2;
            return year;
        }

        private int QuantDiff()
        {
            var result = QuantSoldY1 > QuantSoldY2 ? QuantSoldY1 - QuantSoldY2 : QuantSoldY2 - QuantSoldY1;
            return result;
        }
    }
}
