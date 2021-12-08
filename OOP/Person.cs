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

        public virtual string Print()
        {
            return "Person";
        }
    }

    internal class Employee : Person
    {
        public int Salary { get; set; }

        public string EmployeeMethod()
        {
            return "From EmployeeMethod";
        }
        public override string Print()
        {
            return "Employee";
        }

    }

    internal class Admin : Employee, IPerson2
    {
        public string Department { get; set; }

        public new virtual string Print()
        {
            return "Admin";
        }

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

    internal class Ceo : Admin
    {

        public override string Print()
        {
            return base.Print();
        }
        //public new string Print()
        //{
        //    base.Print();
        //    return "Ceo";
        //}
        public void TestException(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException($"'{nameof(input)}' cannot be null or whitespace.", nameof(input));
            }
        }
    }


}
