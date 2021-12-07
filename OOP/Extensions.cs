using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public static class Extensions
    {
        public static string AddString(this string first, string second)
        {
            return $"{first} {second}";
        }

        public static void Print(this List<IDrivable> source)
        {
           // source.ForEach(v => Console.WriteLine(v.Drive(34)));

            foreach (var v in source)
            {
                Console.WriteLine(v.Drive(34));
            }
        }
    }
}
