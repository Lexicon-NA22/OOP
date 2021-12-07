using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    public abstract class AbstractVehicle
    {
        public virtual string Drive(int distance)
        {
            return $"{this.GetType().Name} drove for {distance}";
        }

        public abstract string Turn();

    }

    public class Vehicle : AbstractVehicle
    {
        public string Brand { get; set; }
        public string RegNo { get; set; }

        public Vehicle(string brand, string regNo)
        {
            Brand = brand;
            RegNo = regNo;
        }

        public override string Turn()
        {
            return "Vehicle turns";
        }
    }

    public class FuelVehicle : Vehicle
    {
        public FuelVehicle(string regNo, string brand = "default") : base(brand, regNo){}

        public override string Drive(int distance)
        {
            return base.Drive(distance) + " From FuelVehicle";
        }
    }

    public class Bicycle : AbstractVehicle
    {
        public override string Turn()
        {
            return "Bicycle turns";
        }

        public override string Drive(int distance)
        {
            return string.Format("Bicycle starts pedaling for {0} {1}",  distance, Turn());
        }
    }
}
