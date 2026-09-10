using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.DecoratorDesignPattern
{
    internal class Run
    {
        public static void Start()
        {

            Console.WriteLine("---Starting Decorator Design Pattern!---");
            INotification notification = new LoggingDecorator( new RetryDecorator(new SMSNotification()));


            // Client code 
            notification.Send("Hi there!");

            Console.WriteLine("---Decorator Design Pattern Ends!---");
        }
    }
}
