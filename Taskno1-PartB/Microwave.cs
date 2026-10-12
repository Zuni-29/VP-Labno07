using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno1_PartB
{
    public class Microwave : KitchenAppliance
    {

        public bool HasGrillFeature;

        public Microwave(string brand, int wattage, bool hasGrillFeature) : base(brand, wattage)
        {
            HasGrillFeature = hasGrillFeature;
        }

        public override void PowerOn()
        {
            base.PowerOn();
            Console.WriteLine("Microwave is ready! Grill feature enabled: " + HasGrillFeature);
        }
    }
}
