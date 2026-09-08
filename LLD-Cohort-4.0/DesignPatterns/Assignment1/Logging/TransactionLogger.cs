using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.Assignment1.Logging
{
    internal class TransactionLogger
    {
        private static TransactionLogger _instance;
        private static readonly object _lock = new object();
        public static TransactionLogger GetTransactionLogger()
        {
            if(_instance == null)
            {
                lock(_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new TransactionLogger();
                    }
                }
            }
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("Logging at TransactionLogger : "+message);
        }
    }
}
