using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace SVGCodingTest.Pages
{
    public class IndexModel : PageModel
    {
        public List<Vehicle> vehicles = new List<Vehicle>();
        public string vehicleJSON = string.Empty;
        VehicleMethods vehicleMethods = new VehicleMethods();
        private List<Vehicle> PopulateVehicles()
        {
            vehicles.AddRange(new List<Vehicle>
            {
                new Vehicle("Bicycle", 200, 220),
                new Vehicle("Car", 100, 94),
                new Vehicle("Truck", 150, 168),
                new Vehicle("Motorcycle", 40, 55),
                new Vehicle("Jet", 11, 14)
            });

            vehicles = vehicleMethods.MarketShares(vehicles);

            return vehicles;
        }

        public void OnGet()
        {
            vehicles = PopulateVehicles();
            vehicleJSON = JsonConvert.SerializeObject(vehicles);
        }
    }
}
