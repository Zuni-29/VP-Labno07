using System;
using System.Collections.Generic;
using Taskno4_PartA;

namespace Taskno4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<INotification> notificationList = new List<INotification>();
            notificationList.Add(new EmailNotification());
            notificationList.Add(new SmsNotification());
            notificationList.Add(new PushNotification());

            notificationList.Add(new SlackNotification());

            NotificationService service = new NotificationService();
            string testMessage = "System maintenance scheduled for tonight at 12:00 AM.";

            Console.WriteLine("=== BROADCASTING NOTIFICATIONS ===");
            service.SendNotification(notificationList, testMessage);
        }
    }
}