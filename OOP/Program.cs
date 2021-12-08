using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson iperson = new Person();

            if(iperson is IPerson)
            {
                Console.WriteLine("Working");
            }

            var person = new Person();
            var employee = new Employee();
            Person admin = new Admin();
            var admin2 = new Admin();

            //Console.WriteLine(((Admin)admin).Print());
            //Console.WriteLine(admin.Print());
            //Console.WriteLine("------------------");

            List<Person> people = new List<Person>()
            {
                person,
                employee,
                admin
            };

            foreach (Person p in people)
            {
                Console.WriteLine(p.Print());

                Employee tempEmployee = p as Employee;
                if (tempEmployee != null) // ! =
                {
                    tempEmployee.EmployeeMethod();
                }

                tempEmployee?.EmployeeMethod();

                //if (p is Employee)
                //{
                //    Employee emp = (Employee)p;
                //    Console.WriteLine(emp.EmployeeMethod());
                //}

                bool isEmp = p is Employee;

                if (p is Employee emp)
                {
                    Console.WriteLine(emp.EmployeeMethod());
                }

               // int result;
               //var x = uint.TryParse(Console.ReadLine(), out uint result);



            }

          //var admin2 = new Admin();
          //Console.WriteLine(admin2.Print());

            //string first = "Kalle";
            //string result = first.AddString("Anka");

            //Console.WriteLine(result);

            //FuelCar fuelCar = new FuelCar();



            //FuelVehicle vehicle = new FuelVehicle(regNo: "Abc123", 23.5, "Saab");
            ////var capacity = vehicle.FuelCapacity;
            ////vehicle.FuelCapacity = 100;
            //AbstractVehicle abstractVehicle = new FuelVehicle("ADD234", 78.5, "Volvo");
            //Bicycle bicycle2 = new Bicycle();
            //AbstractVehicle bicycle3 = new Bicycle();


            //Bicycle bicycle = new();

            //List<IDrivable> vehicles = new List<IDrivable>()
            //{
            //    vehicle,
            //    abstractVehicle,
            //    bicycle2,
            //    new Vehicle("Mazda", "MMM222")
            //};

            //vehicles.Print();

            //foreach (var v in vehicles)
            //{
            //    Console.WriteLine(v.Drive(25));

            //}


            //Console.WriteLine(vehicle.Drive(100));


        }
    }
}
