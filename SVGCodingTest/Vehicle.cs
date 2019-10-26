using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVGCodingTest
{
    public class Vehicle
    {
        public string Type { get; set; }

        public int QuantSold18 { get; set; }

        public int QuantSold19 { get; set; }

        public int TopYear()
        {
            var year = QuantSold18 > QuantSold19 ? 18 : 19;
            return year;
        }

        public int QuantDiff()
        {
            var result = QuantSold18 > QuantSold19 ? QuantSold18 - QuantSold19 : QuantSold19 - QuantSold18;
            return result;
        }
    }
}
