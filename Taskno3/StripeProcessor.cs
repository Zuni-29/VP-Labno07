using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno3
{
    public class StripeProcessor : PaymentProcess
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine("--- Processing via Stripe ---");

            if (ValidateTransaction(amount))
            {
                Console.WriteLine("Success: " + amount + " Rupees processed via Stripe credit card gateway.");
            }
            else
            {
                Console.WriteLine("Error! Transaction failed.");
            }
            Console.WriteLine();
        }
    }
}
