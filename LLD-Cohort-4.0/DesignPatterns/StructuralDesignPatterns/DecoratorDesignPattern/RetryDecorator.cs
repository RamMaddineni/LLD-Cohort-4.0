using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.DecoratorDesignPattern
{
    internal class RetryDecorator : NotificationDecorator
    {

        public RetryDecorator(INotification notification) :
          base(notification)
        {

        }
        public override void Send(string message)
        {
            _wrappedNotification.Send(message);
            Console.WriteLine("We are retrying with some additonal logic based on reponse of first send!");
        }
    }
}
