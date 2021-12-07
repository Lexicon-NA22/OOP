using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IDrivable
    {
        string Drive(int distance);
    }

    public abstract class AbstractVehicle : IDrivable
    {
        public virtual string Drive(int distance)
        {
            return $"{this.GetType().Name} wants to drive for {distance}";
        }

        public abstract string Turn();

    }

    public class Vehicle : AbstractVehicle
    {
        public string Brand { get; set; }
        protected string RegNo { get; set; }

        public Vehicle(string brand, string regNo)
        {
            Brand = brand;
            RegNo = regNo;
        }

        public override string Turn()
        {
            return "Vehicle turns";
        }

        public void Test()
        {

        }
    }

    public class FuelVehicle : Vehicle
    {
        private double fuelLevel;

        public double FuelLevel 
        {
            get
            {
                return fuelLevel;
            }
            set
            {
                double newLevel = Math.Max(0, value);
                fuelLevel= Math.Min(newLevel, FuelCapacity);
            }
        }

        public double FuelCapacity { get; }
        public FuelVehicle(string regNo, double fuelCapacity, string brand = "default") : base(brand, regNo)
        {
            FuelCapacity = fuelCapacity;
        }

        public new void  Test()
        {

        }

        public  override string Drive(int distance)
        {
            return base.Drive(distance) + " From FuelVehicle";
        }
    }


    public class FuelCar : FuelVehicle
    {
        private const double fuelConsumption = 0.5;

        protected double MaxDistance => FuelLevel / fuelConsumption;
        //{
        //    get
        //    {
        //        return FuelLevel / fuelConsumption;
        //    }
        //}
        public FuelCar() : this("DefaultBrandName", 100) { }
        public FuelCar(string brand, double fuelCapacity, string regNo = "AAA111") : base(regNo, fuelCapacity, brand) { }

        public sealed override string Drive(int distance)
        {
            var result = new StringBuilder();

            result.AppendLine(base.Drive(distance));

            if(distance < 0)
            {
                distance = 0;
                result.AppendLine("Negative distance is assumed to be 0");
            }

            //FuelLevel = FuelLevel - (distance * fuelConsumption);
            FuelLevel -= distance * fuelConsumption;

            result.AppendLine($"RegNo: {RegNo} drove {distance}km");

            return result.ToString();

        }

    }

    public sealed class Bicycle : AbstractVehicle
    {
        public override string Turn()
        {
            return "Bicycle turns";
        }

        public override string Drive(int distance)
        {
            return string.Format("Bicycle starts pedaling for {0} {1}",  distance, Turn());
        }

        public void Over(string input)
        {

        }  
        
        public int Over(string input, string inpu2 = "Hej")
        {
            return 1;
        }  
        
        public void Over(double input)
        {

        }
    }
}
