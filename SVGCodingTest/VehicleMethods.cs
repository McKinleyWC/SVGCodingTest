using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVGCodingTest
{
    public class VehicleMethods
    {
        private int totalY1 = 0, totalY2 = 0;
        private List<Vehicle> vehicles = new List<Vehicle>();
        public List<Vehicle> MarketShares(List<Vehicle> vehicles)
        {
            this.vehicles = vehicles;
            Totals();
            Shares();
            return this.vehicles;
        }

        private void Totals()
        {
            try
            {
                foreach (var vehicle in vehicles)
                {
                    totalY1 += vehicle.QuantSoldY1;
                    totalY2 += vehicle.QuantSoldY2;
                }
            }
            catch(NullReferenceException ex)
            {
                // to do error logger
            }
        }

        private void Shares()
        {
            try
            {
                foreach (var vehicle in vehicles)
                {
                    vehicle.MarketY1 = vehicle.QuantSoldY1 / totalY1;
                    vehicle.MarketY2 = vehicle.QuantSoldY2 / totalY2;
                }
            }
            catch(NullReferenceException ex)
            {
                //to do error logger
            }
        }
    }
}
