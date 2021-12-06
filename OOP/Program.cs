using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson employee = new Employee();

            employee.Do();

            Person person = new Person();
           // person = employee;
            Person admin = new Admin();
            Admin admin1 = (Admin)admin;



           
        }
    }
}
