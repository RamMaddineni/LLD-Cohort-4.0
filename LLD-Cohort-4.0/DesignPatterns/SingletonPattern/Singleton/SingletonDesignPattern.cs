using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.SingletonPattern.Singleton
{
    internal class SingletonDesignPattern
    {

        private static SingletonDesignPattern _instance;
        public SingletonDesignPattern()
        {
            Console.WriteLine("Coming to singleton Design Pattern");
        }
        public static SingletonDesignPattern GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonDesignPattern();
            }
            return _instance;
        }
    }
}
