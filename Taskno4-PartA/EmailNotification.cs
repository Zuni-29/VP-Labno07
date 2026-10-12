using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno4_PartA
{
    public class EmailNotification : INotification
    {
        public string Channel
        {
            get { return "Email"; }
        }

        public void Send(string message)
        {
            Console.WriteLine("Sending " + Channel + " Notification: " + message);
        }

    }
}
