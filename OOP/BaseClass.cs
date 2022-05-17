using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{


    internal abstract class BaseClass
    {
        public static void Do()
        {
            Console.WriteLine("Base do");
        }

    }

    internal class DirevedClass : BaseClass
    {
        public  void Test()
        {
            Do();
        }
    }
   
}

