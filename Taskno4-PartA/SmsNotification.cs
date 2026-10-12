using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno4_PartA
{
    public class SmsNotification :INotification
    {
        public string Channel
        {
            get { return "SMS"; }
        }

        public void Send(string message)
        {
            Console.WriteLine("Sending " + Channel + " Notification: " + message);
        }

    }
}
