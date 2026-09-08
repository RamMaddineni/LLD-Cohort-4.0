using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.SimpleFactory
{
    internal class EmailNotification:Notification
    {
        public void Send(string message)
        {
            Console.WriteLine("Simple Factory Email Notification: "+message);
        }
    }
}
