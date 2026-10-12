using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno2
{
    public class Discount
    {
        public virtual double CalculateDiscount(double price)
        {
            return price; 
        }
    }
}
