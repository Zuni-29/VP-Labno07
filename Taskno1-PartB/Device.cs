using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno1_PartB
{
    public class Device
    {
        public string Brand;

        public Device(string brand)
        {
            Brand = brand;
        }

        public virtual void PowerOn()
        {
            Console.WriteLine("Device (Brand: " + Brand + ") is powering on");
        }
    }
}
