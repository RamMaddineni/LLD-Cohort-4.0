using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Factory;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Factory
{
    internal class Run
    {
        public static void Start()
        {
            Console.WriteLine("---Factory Start---");

            // What does factory do? Produces objects.

            NotificationFactory smsNotificationFactory = new SMSNotificationFactory();
            Notification sms = smsNotificationFactory.GetNotification();

            sms.Send("Hi there!");

            NotificationFactory emailNotificationFactory = new EmailNotificationFactory();
            Notification email = emailNotificationFactory.GetNotification();
            email.Send("Hi there!");

            Console.WriteLine("---Factory Ends---");


            // Interfaces : Notification ,NotificationFactory

            // Concrete classes : SMSNotification, EmailNotification, SMSNotificationFactory,EamilNotificationFactory

            // group 1 : Notification, SMSNotification,EmailNotification.
            // group 2 factories : NotificationFactory,EmailNotificationFactory,SMSNotificationFactory.


        }
    }
}
