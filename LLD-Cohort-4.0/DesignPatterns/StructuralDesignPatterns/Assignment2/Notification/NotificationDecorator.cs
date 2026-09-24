using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.Notification
{
    internal abstract class NotificationDecorator : INotification
    {
        protected INotification _wrappedNotification;
        public NotificationDecorator(INotification wrappedNotification)
        {
            _wrappedNotification = wrappedNotification;
        }
        public abstract void Send(string user, string message);
    }
}
