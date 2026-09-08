using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.WithoutFactory
{
    internal class EmailNotification:Notification
    {
        public void send(string message)
        {
            Console.WriteLine("Without Factory , Email Notification : "+message);
        }
    }
}
