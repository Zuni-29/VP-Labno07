using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno1_PartA
{
    public class Vehicle
    {
        public string Brand;
        public string Model;
        public int Year;

        // Parameterized Constructor
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Year: " + Year);
        }
    }
}
