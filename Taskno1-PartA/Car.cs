using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno1_PartA
{
    public class Car :Vehicle
    {
        public int NumberOfDoors;
        public Car(string brand, string model, int year, int numberOfDoors)
            : base(brand, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Number of Doors: " + NumberOfDoors);
        }
    }
}
