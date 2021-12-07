using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelVehicle vehicle = new FuelVehicle(regNo: "Abc123", "Saab");
            AbstractVehicle abstractVehicle = new FuelVehicle("Volvo");
            Bicycle bicycle2 = new Bicycle();
            AbstractVehicle bicycle3 = new Bicycle();
            
            Bicycle bicycle = new();

            List<AbstractVehicle> vehicles = new List<AbstractVehicle>()
            {
                vehicle,
                abstractVehicle,
                bicycle2,
                new Vehicle("Mazda", "MMM222")
            };

            foreach (var v in vehicles)
            {
                Console.WriteLine(v.Drive(25));
            }


            Console.WriteLine(vehicle.Drive(100));

           
        }
    }
}
