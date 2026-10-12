using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno4_PartA
{
    public class NotificationService
    {
        public void SendNotification(List<INotification> notifications, string message)
        {
            foreach (INotification notification in notifications)
            {
                Console.WriteLine("Channel Type: " + notification.Channel);
                notification.Send(message);
                Console.WriteLine();
            }
        }
    }
   
}
