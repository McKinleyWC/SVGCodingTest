using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVGCodingTest
{
    public class Vehicle
    {
        public string Type { get; set; }

        public int QuantSoldY1 { get; set; }

        public int QuantSoldY2 { get; set; }

        public float MarketY1 { get; set; }

        public float MarketY2 { get; set; }

        public int TopYear()
        {
            var year = QuantSoldY1 > QuantSoldY2 ? 1 : 2;
            return year;
        }

        public int QuantDiff()
        {
            var result = QuantSoldY1 > QuantSoldY2 ? QuantSoldY1 - QuantSoldY2 : QuantSoldY2 - QuantSoldY1;
            return result;
        }
    }
}
