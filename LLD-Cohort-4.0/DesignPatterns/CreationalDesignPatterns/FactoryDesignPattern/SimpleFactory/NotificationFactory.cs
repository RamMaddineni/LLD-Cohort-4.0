using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.SimpleFactory
{
    internal class NotificationFactory
    {
        public static Notification CreateNotification(string type)
        {
            if (type == "sms")
            {
                return new SMSNotification();
            }
            if (type == "email")
            {
                return new EmailNotification();
            }
            throw new ArgumentException($"Invalid notification type: '{type}'", nameof(type));

        }
    }
}
