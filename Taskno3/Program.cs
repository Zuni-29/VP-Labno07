using System;
using Taskno3;
namespace Taskno3
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcess paypal = new PayPalProcessor();
            PaymentProcess  stripe = new StripeProcessor();

            double validAmount = 150.75;
            double invalidAmount = -25.00;

            Console.WriteLine("=== TESTING WITH VALID AMOUNT (150.75 USD) ===");
            paypal.ProcessPayment(validAmount);
            stripe.ProcessPayment(validAmount);

            Console.WriteLine("=== TESTING WITH INVALID AMOUNT (-25.00 USD) ===");
            paypal.ProcessPayment(invalidAmount);
            stripe.ProcessPayment(invalidAmount);
        }
    
 }   }

