using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.Factory
{
    internal class Run
    {
        public static void Start()
        {
            Console.WriteLine("---Factory Start---");
           
            NotificationFactory smsNotificationFactory = new SMSNotificationFactory();
            Notification sms = smsNotificationFactory.GetNotification();

            sms.Send("Hi there!");

            NotificationFactory emailNotificationFactory= new EmailNotificationFactory();
            Notification email = emailNotificationFactory.GetNotification();
            email.Send("Hi there!");

            Console.WriteLine("---Factory Ends---");

        }
    }
}
