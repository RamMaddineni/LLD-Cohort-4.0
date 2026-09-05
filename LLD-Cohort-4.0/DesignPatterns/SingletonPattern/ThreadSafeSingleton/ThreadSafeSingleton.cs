using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.SingletonPattern.ThreadSafeSingleton
{
    internal class ThreadSafeSingleton
    {

        private static ThreadSafeSingleton _instance;
        private static readonly object _lock = new object();
        public ThreadSafeSingleton()
        {
            Console.WriteLine("Coming to thread safe - singleton Design Pattern");
        }
        public static ThreadSafeSingleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        Thread.Sleep(100);
                        _instance = new ThreadSafeSingleton();

                    }

                }
            }
            return _instance;
        }
    }
}
