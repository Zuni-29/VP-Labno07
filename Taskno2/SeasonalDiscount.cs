using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno2
{
    public class SeasonalDiscount : Discount
    {
        public override double CalculateDiscount(double price)
        {
            Console.WriteLine("Applying seasonal discount of 20%");
            return price * 0.8;
        }
    }
}
