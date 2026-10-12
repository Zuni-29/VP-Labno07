using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno3
{
   public abstract class PaymentProcess
    {
        
        public bool ValidateTransaction(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Validation Success: Amount " + amount + " Rupees is positive.");
                return true;
            }
            else
            {
                Console.WriteLine("Validation Failed: Amount " + amount );
                return false;
            }
        }

        public abstract void ProcessPayment(double amount);
    }
}
