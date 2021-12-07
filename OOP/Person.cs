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
        void Do();

    }

    public interface IPerson2
    {

        void Doing()
        {
            Console.WriteLine("Iperson2");
        }
    }

    internal class Person : IPerson
    {
        public string Name { get; set; }

        public virtual void Do()
        {
            Console.WriteLine("Person");
        }
    }

    internal class Employee : Person
    {
        public int Salary { get; set; }

    }

    internal class Admin : Employee, IPerson2
    {
        public string Department { get; set; }

        public override void Do()
        {
            //base.Do();
            Console.WriteLine("Admin");
        }

        void IPerson2.Doing()
        {
            Console.WriteLine("Admin2");
        }
    }


}
