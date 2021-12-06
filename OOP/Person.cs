using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    public interface IPerson
    {
        string Name { get; set; }
        void Do()
        {
            Console.WriteLine("Iperson");
        }
    } 
    
    public interface IPerson2
    {
       
        void Do()
        {
            Console.WriteLine("Iperson2");
        }
    }

    internal class Person 
    {
        public string Name { get; set; }

    }

    internal class Employee : Person, IPerson, IPerson2
    {
        public int Salary { get; set; }

    }

    internal class Admin : Employee 
    {
        public string Department { get; set; }
    }


}
