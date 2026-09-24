using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.Notification
{
    internal class LoggingDecorator : NotificationDecorator
    {
        public LoggingDecorator(INotification notification) :base(notification) { }

        public override void Send(string user, string message)
        {
            Console.WriteLine("Entering Logging decorator");
            _wrappedNotification.Send(user, message);
            Console.WriteLine("Existing Logging decorator");
        }
    }
}
