using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetProgram
{
    class HashSetProgram
    {
        public class Vehicle // vehicle class 
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Type { get; set; }
        }

        public class VehicleNameComparer : IEqualityComparer<Vehicle> // comparison for Vehicle objects
        {
            public bool Equals(Vehicle x, Vehicle y)
            {
                return x.Brand.Equals(y.Brand, StringComparison.InvariantCultureIgnoreCase); //compare objects by Brand(String comparison) parameter
            }

            public int GetHashCode(Vehicle obj)
            {
                return obj.Brand.GetHashCode(); //return hash code for Brand(String) in object
            }
        }


        static void Main(string[] args)
        {
            HashSet<Vehicle> Cars = new HashSet<Vehicle>(new VehicleNameComparer()) //objects added to HashSet with comparer used
            {
                new Vehicle() { Brand = "Ford", Model = "Mustang", Type = "Car" }, 
                new Vehicle() { Brand = "Ford", Model = "F250", Type = "Truck" },
                new Vehicle() { Brand = "GM", Model = "Yukon", Type = "Truck" },
                new Vehicle() { Brand = "GM", Model = "Sierra", Type = "Truck" },
                new Vehicle() { Brand = "Chrysler", Model = "300S", Type = "Car" },
                new Vehicle() { Brand = "Ford", Model = "Edge", Type = "Cross Over"},
                new Vehicle() { Brand = "BMW", Model = "760I", Type = "Car"},
                new Vehicle() { Brand = "Kia", Model = "Sorento", Type = "Truck"}
            };

            Console.WriteLine("There are {0} types of Car brands", Cars.Count); // return compared count
            Console.ReadKey();
        }
    }
}
