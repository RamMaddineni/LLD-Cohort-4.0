using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.Factory
{
    internal class SMSNotificationFactory : NotificationFactory
    {
        public Notification GetNotification()
        {
            return new SMSNotification();
        }

    }
}
