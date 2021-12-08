using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region exception
            Ceo ceo = new Ceo();
            try
            {
                 ceo.TestException(null);

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally 
            {
                Console.WriteLine("Finally");
            }
            #endregion

            #region casting
            IPerson iperson = new Person();

            //Är iperson en IPerson ? true : false
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

                //Castning casta p till en Employee om det lyckas lägg resultatet i variabeln tempEmployee annars null
                Employee tempEmployee = p as Employee;
                if (tempEmployee != null) // ! =
                {
                    tempEmployee.EmployeeMethod();
                }

                //?. null check om tempEmployee är null anropas aldrig EmployeeMethod
                tempEmployee?.EmployeeMethod();

                //if (p is Employee)
                //{
                //    Employee emp = (Employee)p;               //Unsafe cast Exception om det inte går att casta
                //    Console.WriteLine(emp.EmployeeMethod());
                //}

                bool isEmp = p is Employee;


                //Är instansen p en Employee? 
                //Om ja, casta och tilldela resultaten till variabeln emp
                if (p is Employee emp)
                {
                    Console.WriteLine(emp.EmployeeMethod());
                }

               // int result;
               //var x = uint.TryParse(Console.ReadLine(), out uint result);



            }
            #endregion

            #region extension methods and polymorfism 
            Console.WriteLine(admin2.Print());

            string first = "Kalle";
            string result = first.AddString("Anka");

            Console.WriteLine(result);

            FuelVehicle vehicle = new FuelVehicle(regNo: "Abc123", 23.5, "Saab");
            //var capacity = vehicle.FuelCapacity;
            //vehicle.FuelCapacity = 100;
            AbstractVehicle abstractVehicle = new FuelVehicle("ADD234", 78.5, "Volvo");
            Bicycle bicycle2 = new Bicycle();
            AbstractVehicle bicycle3 = new Bicycle();

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

            #endregion

            //Två olika sätt att instansiera nya objekt
            var fuelCar = new FuelCar();
            Bicycle bicycle = new();

        }
    }
}
