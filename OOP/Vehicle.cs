using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Interface
    //En klass kan implementera (ärva) från många interface
    //Allt är publikt 
    //(Med C# 8 kan vi har privata statiska medlemmar, samt publika/privata metoder med default implemenation)
    //Måste Implementeras i ärvda klasser
    //(Kan ha implementation from c# 8)
    //Kan inte implementeras - ej skapa objekt av med new
    public interface IDrivable
    {
        string Drive(int distance);
    }

    //Abstrakt
    //Kan inte implementeras - ej skapa objekt av med new
    //Kan inehålla en blandnig av vanliga metoder och abstrakta metoder utan implementation
    //Alla abstrakta medlemmar måste implemneteras av dem som ärver från den abstrakta klassen
    //Kan hålla privata fält
    //AbstractVehicle implementerar IDrivable
    public abstract class AbstractVehicle : IDrivable
    {
        //Virtual - En metod som markeras med nykelordet virtual är ok att skriva en ny implementation i  ärvda klasser
        public virtual string Drive(int distance)
        {
            return $"{this.GetType().Name} wants to drive for {distance}";
        }

        //Håller ingen implementation måste implementeras i ärvda klasser
        //Nykelordet abstract kan bara användas i abstrakta klasser
        public abstract string Turn();

    }

    //Vehicle ärver från AbstractVehicle
    public class Vehicle : AbstractVehicle
    {
        public string Brand { get; set; }

        //Protected enbart synlig här och klasser som ärver Vehicle. Private för alla andra
        protected string RegNo { get; set; }

        public Vehicle(string brand, string regNo)
        {
            Brand = brand;
            RegNo = regNo;
        }

        //Overide egen implementation av Turn, mer specialiserad variant
        public override string Turn()
        {
            return "Vehicle turns";
        }
    }

    public class FuelVehicle : Vehicle
    {
        //Privat fält
        private double fuelLevel;

        //Property, när vi skriver kod i get och set behöver vi skriva ut det bakomliggande fältet
        public double FuelLevel 
        {
            get
            {
                return fuelLevel;
            }
            set
            {
                double newLevel = Math.Max(0, value);
                fuelLevel= Math.Min(newLevel, FuelCapacity);
            }
        }

        //Property med enbart geter. Kan bara sättas via konstruktorn
        public double FuelCapacity { get; }

        //Nyckelordet base anropar här basklassens konstruktor
        public FuelVehicle(string regNo, double fuelCapacity, string brand = "default") : base(brand, regNo)
        {
            FuelCapacity = fuelCapacity;
        }

        //public  override string Drive(int distance)
        //{
        //    return base.Drive(distance) + " From FuelVehicle";
        //}
    }


    public class FuelCar : FuelVehicle
    {
        //Const kan inte ändras när värdet är satt. Måste sätta värdet direkt!
        private const double fuelConsumption = 0.5;

        protected double MaxDistance => FuelLevel / fuelConsumption;
        //Samma som ovan!
        //{
        //    get
        //    {
        //        return FuelLevel / fuelConsumption;
        //    }
        //}

        //Kedjade konstruktorer. base anropar basklassens konstruktor, this anropar den andra konstruktorn i klassen
        public FuelCar() : this("DefaultBrandName", 100) { }
        public FuelCar(string brand, double fuelCapacity, string regNo = "AAA111") : base(regNo, fuelCapacity, brand) { }

        //Nyckelordet sealed låser metoden från att overriadas längre
        public sealed override string Drive(int distance)
        {
            var result = new StringBuilder();

            result.AppendLine(base.Drive(distance));

            if(distance < 0)
            {
                distance = 0;
                result.AppendLine("Negative distance is assumed to be 0");
            }

            //Samma resultat på rad 129, 130 bara olika syntax
            //FuelLevel = FuelLevel - (distance * fuelConsumption);
            FuelLevel -= distance * fuelConsumption;

            result.AppendLine($"RegNo: {RegNo} drove {distance}km");

            return result.ToString();

        }

    }

    //Klassen Bicycle kan inte ärvas när den är markerad med sealed
    public sealed class Bicycle : AbstractVehicle
    {
        public override string Turn()
        {
            return "Bicycle turns";
        }

        public override string Drive(int distance)
        {
            return string.Format("Bicycle starts pedaling for {0} {1}",  distance, Turn());
        }

        //Överladdade metoder måste ha unika signaturer. Olika namn samt parametrar. Returtyp inte del av metodens signatur
        public void Over(string input)
        {

        }  
        
        public int Over(string input, string inpu2 = "Hej")
        {
            return 1;
        }  
        
        public void Over(double input)
        {

        }
    }
}
