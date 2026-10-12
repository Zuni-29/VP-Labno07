using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno1_PartB
{
    public class KitchenAppliance: Device
    {
        public int Wattage;
        public KitchenAppliance(string brand, int wattage) : base(brand)
        {
            Wattage = wattage;
        }
        public override void PowerOn()
        {
            base.PowerOn();
            Console.WriteLine("Kitchen Appliance (Brand: " + Brand + ", Wattage: " + Wattage + "W) is powering on");
        }
    }
    
}
