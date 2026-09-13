using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.ObserverDesignPattern
{
    internal class Run
    {
        public static void Start()
        {
            Console.WriteLine("---Starting Observer Design Pattern---");
            IObserver tv = new TV();
            IObserver phone = new Phone();
            Stock stock = new Stock();
            stock.AddObserver(tv);
            stock.AddObserver(phone);

            stock.SetStockPrice(6);

            stock.DeleteObserver(tv);

            stock.SetStockPrice(7);
            Console.WriteLine("---Starting Observer Design Pattern Ends---");
        }

    }
}
