using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.DecoratorDesignPattern
{
    internal class SMSNotification : INotification
    {
        public void Send(string message)
        {
           Console.WriteLine("Sending Message from SMSNotification :"+message);
        }
    }
}
