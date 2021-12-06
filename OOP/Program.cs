using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson employee = new Employee();
            IPerson admin = new Admin();

            employee.Do();
            admin.Do();

           // Person person = new Person();
           //// person = employee;
           // Admin admin1 = (Admin)admin;



           
        }
    }
}
