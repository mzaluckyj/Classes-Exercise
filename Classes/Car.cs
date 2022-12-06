using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public Car()
        { }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string Make { get; private set; }
        public string Model { get; }
        public int Year { get; }

        //overload method
        /*public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }   */
    }
}
