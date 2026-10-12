using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno1_PartA
{
    public class Motorbike: Vehicle
    {
        public bool HasSidecar;

        public Motorbike(string brand, string model, int year, bool hasSidecar)
            : base(brand, model, year)
        {
            HasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Has Sidecar: " + HasSidecar);
        }
    }
}
