using Microsoft.VisualBasic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myTruck = new Car();
            {
                myTruck.make = "Ram";
                myTruck.model = "1500";
                myTruck.year = 2021;
            }

            Car ford = new Car();
            {
                ford.make = "Ford";
                ford.model = "F150";
                ford.year = 2010;
            }

            var carlist = new List<Car>() { myTruck, ford,};

            foreach(var vehicle in carlist) { Console.WriteLine($"{vehicle.make} {vehicle.model} {vehicle.year}"); }
        }


    }
}
