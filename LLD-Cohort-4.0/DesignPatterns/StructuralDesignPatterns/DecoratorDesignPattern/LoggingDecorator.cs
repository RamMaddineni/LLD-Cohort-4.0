using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.DecoratorDesignPattern
{
    internal class LoggingDecorator : NotificationDecorator
    {
        public LoggingDecorator(INotification notification):base(notification) { }
        public override void Send(string message)
        {
            Console.WriteLine("We are logging before sending!");
            _wrappedNotification.Send(message);
            Console.WriteLine("We are logging after sending message!");
        }
    }
}
