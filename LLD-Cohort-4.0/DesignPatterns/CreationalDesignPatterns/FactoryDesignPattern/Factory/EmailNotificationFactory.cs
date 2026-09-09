using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Factory
{
    internal class EmailNotificationFactory : NotificationFactory
    {
        public Notification GetNotification()
        {
            return new EmailNotification();
        }
    }
}
