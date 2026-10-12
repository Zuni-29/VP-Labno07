using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno3
{
    public class PayPalProcessor : PaymentProcess
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine("--- Processing via PayPal ---");

            if (ValidateTransaction(amount))
            {
                Console.WriteLine("Success: " + amount + "Rupees processed securely through PayPal account.");
            }
            else
            {
                Console.WriteLine("Error! Transaction failed.");
            }
            Console.WriteLine();
        }
    }
}