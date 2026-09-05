using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.NonThreadSafeSingleton
{
    internal class NonThreadSafeSingleton
    {

        private static NonThreadSafeSingleton _instance;
        public NonThreadSafeSingleton() {
            Console.WriteLine("Coming to Non thread safe-singleton Design Pattern");
        }
        public static NonThreadSafeSingleton GetInstance()
        {
            if (_instance == null)
            {
                Thread.Sleep(100);
                _instance = new NonThreadSafeSingleton();
            }
            return _instance;
        }
    }
}
