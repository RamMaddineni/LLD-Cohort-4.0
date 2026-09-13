using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.ObserverDesignPattern
{
    internal class Stock
    {
        int price;
        List<IObserver> observers;
        public Stock()
        {
            price = 0;
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver observer)
        {
            Console.WriteLine("Adding Observer!");
            observers.Add(observer);
        }
        public void DeleteObserver(IObserver observer)
        {
            Console.WriteLine("Deleting Observer!");
            observers.Remove(observer);
        }
        void NotifyObservers(int state)
        {
            for (int i=0;i<observers.Count;i++)
            {
                observers[i].NotifyMe(state);
            }
        }
        public void SetStockPrice(int price)
        {
            if(this.price!= price)
            {
                this.price = price;
                NotifyObservers(price);
            }
        }
    }
}
