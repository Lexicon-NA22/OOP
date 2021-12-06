using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Vehicle
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public virtual string Drive(int distance)
        {
            return $"{this.GetType().Name} drove for {distance}";
        }
    }

    public class FuelVehicle : Vehicle
    {
        public FuelVehicle(string brand = "default") : base(brand){}

        public override string Drive(int distance)
        {
            return base.Drive(distance) + " From FuelVehicle";
        }
    }
}
