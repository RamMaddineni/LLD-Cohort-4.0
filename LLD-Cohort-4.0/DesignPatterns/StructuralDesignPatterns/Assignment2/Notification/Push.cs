using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.Notification
{
    internal class Push : INotification
    {
        public void Send(string user,string message)
        {
            Console.WriteLine("Push Message : " +user+" "+ message);
        }
    }
}
