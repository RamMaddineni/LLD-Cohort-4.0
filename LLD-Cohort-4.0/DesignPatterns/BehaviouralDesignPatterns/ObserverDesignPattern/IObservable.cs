using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.ObserverDesignPattern
{
    internal interface IObservable
    {
        public void AddObserver(IObserver observer);
        public void DeleteObserver(IObserver observer);
    }
}
