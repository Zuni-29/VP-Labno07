using System;
using System.Collections.Generic;
using Taskno2;
namespace taskno2
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 100.0;
            Discount discount = new Discount();
            double discountedPrice = discount.CalculateDiscount(price);
            Console.WriteLine("Original Price: " + price );
            SeasonalDiscount seasonalDiscount = new SeasonalDiscount();
            discountedPrice = seasonalDiscount.CalculateDiscount(price);
            Console.WriteLine("Original Price: " + price + ", Discounted Price: " + discountedPrice);
            PremiumMemberDiscount premiumMemberDiscount = new PremiumMemberDiscount();
            discountedPrice = premiumMemberDiscount.CalculateDiscount(price);
            Console.WriteLine("Original Price: " + price + ", Discounted Price: " + discountedPrice);
        }
    }
}
