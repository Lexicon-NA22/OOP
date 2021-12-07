using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Extension metoder låter en lägga till metoder på existerande klasser
    //Anropas på samma sätt som vanliga instans metoder
    //Måste ligga i en statisk klass
    //Måste vara en statisk metod
    //this string visar att vi "extendar" typen string
    public static class Extensions
    {
        //Här extendar typen string med en AddString metod
        public static string AddString(this string first, string second)
        {
            return $"{first} {second}";
        }

        //Här extendar vi en lista av IDrivable
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
