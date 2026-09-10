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

/*    Abstract class: is a restricted class that cannot be used to create objects(to access it, it must be inherited from another class).

Abstract method: can only be used in an abstract class, and it does not have a body.The body is provided by the derived class (inherited from).*/

}
