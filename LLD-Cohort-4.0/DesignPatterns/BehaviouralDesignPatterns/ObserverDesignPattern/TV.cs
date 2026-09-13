using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.ObserverDesignPattern
{
    internal class TV : IObserver
    {
        public void NotifyMe(int state)
        {
            Console.WriteLine("TV received an update "+state);
        }
    }
}
