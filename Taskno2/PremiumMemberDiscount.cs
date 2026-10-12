using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno2
{
    public class PremiumMemberDiscount :Discount
    {
        public override double CalculateDiscount(double price)
        {
            Console.WriteLine("Applying premium member discount of 50%");
            return price * 0.5;
        }


    }
}
