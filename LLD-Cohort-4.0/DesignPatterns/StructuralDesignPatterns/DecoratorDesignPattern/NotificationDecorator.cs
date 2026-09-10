using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.DecoratorDesignPattern
{
    internal abstract class NotificationDecorator : INotification
    {
        protected INotification _wrappedNotification;
        public NotificationDecorator(INotification notification)
        {
            this._wrappedNotification = notification;
        }
        public abstract void Send(string message);
    }
}
