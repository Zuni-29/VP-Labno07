using System;
using Taskno1_PartB;

namespace Taskno1_PartB{
   
        class Program
        {
            static void Main(string[] args)
            {
                // Creating a Microwave object through multi-level inheritance
                Microwave myMicrowave = new Microwave("Samsung", 1200, true);

                Console.WriteLine("--- Testing PowerOn() Chain ---");
                myMicrowave.PowerOn();
            }
        }

}
