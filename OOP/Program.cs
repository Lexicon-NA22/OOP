using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Person person = new Person();
            person = employee;
            Person admin = new Admin();
            Admin admin1 = (Admin)admin;
           
        }
    }
}
