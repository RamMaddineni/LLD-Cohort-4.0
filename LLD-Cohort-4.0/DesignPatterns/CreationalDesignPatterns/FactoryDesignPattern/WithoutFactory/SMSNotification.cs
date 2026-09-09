using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.WithoutFactory
{
    internal class SMSNotification : Notification
    {
        public void send(string message)
        {
            Console.WriteLine("Without Factory , SMS Notification : " + message);
        }
    }
}
