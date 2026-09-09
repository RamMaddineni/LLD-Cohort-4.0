using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.SimpleFactory
{
    internal class Run
    {
        public static void Start()
        {
            Console.WriteLine("---SimpleFactory Start---");
            Notification sms = NotificationFactory.CreateNotification("sms");
            sms.Send("Hi there!");

            Notification email = NotificationFactory.CreateNotification("email");
            email.Send("Hi there!");

            Console.WriteLine("---SimpleFactory Ends---");

        }
    }
}
