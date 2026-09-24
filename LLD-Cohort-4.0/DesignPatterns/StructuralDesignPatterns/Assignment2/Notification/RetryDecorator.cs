using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.Notification
{
    internal class RetryDecorator : NotificationDecorator
    {
        public RetryDecorator(INotification notification) : base(notification) { }
        public override void Send(string user, string message)
        {
            Console.WriteLine("Entering RetryDecorator");
            _wrappedNotification.Send(user, message);
            Console.WriteLine("Exiting RetryDecorator");
        }
    }
}
