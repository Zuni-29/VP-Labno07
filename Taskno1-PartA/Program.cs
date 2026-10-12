using System;
using Taskno1_PartA;
namespace Taskno1_PartA
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car("Suzzuki", "xxx-98", 2022, 4);
            Console.WriteLine("--- Car Details ---");
            myCar.DisplayInfo();

            Console.WriteLine();

            Motorbike myBike = new Motorbike("Honda", "99-zun", 2023, false);
            Console.WriteLine("--- Motorbike Details ---");
            myBike.DisplayInfo();
        }
    }
}