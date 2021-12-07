using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = "Kalle";
            string result = first.AddString("Anka");

            Console.WriteLine(result);

            FuelCar fuelCar = new FuelCar();
            


            FuelVehicle vehicle = new FuelVehicle(regNo: "Abc123",23.5, "Saab");
            //var capacity = vehicle.FuelCapacity;
            //vehicle.FuelCapacity = 100;
            AbstractVehicle abstractVehicle = new FuelVehicle("ADD234",  78.5, "Volvo");
            Bicycle bicycle2 = new Bicycle();
            AbstractVehicle bicycle3 = new Bicycle();
           
            
            Bicycle bicycle = new();

            List<IDrivable> vehicles = new List<IDrivable>()
            {
                vehicle,
                abstractVehicle,
                bicycle2,
                new Vehicle("Mazda", "MMM222")
            };

            vehicles.Print();

            foreach (var v in vehicles)
            {
                Console.WriteLine(v.Drive(25));
              
            }


            Console.WriteLine(vehicle.Drive(100));

           
        }
    }
}
