using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.Concurrency
{
    internal class Run
    {
        public static void Start()
        {
            Thread t = new Thread(() => { Console.WriteLine("Hi there!"); });
            t.Start();
            t.Join(); // Waits the main thread until the thread is done executing.
            Console.WriteLine("Reached End");
        }
        public static void Cook()
        {
            Thread cook = new Thread(() => {
                Console.WriteLine("Cooking starts...");
                Thread.Sleep(2000);
                Console.WriteLine("Food is ready!");
            });
            cook.Start();
            Console.WriteLine("i am from main thread....");
            cook.Join();
            Console.WriteLine("Oh food is prepared i will eat now! in main thread!");
        }

        public static void Cook2()
        {
            Thread cook = new Thread(() => {
                Console.WriteLine("Cooking starts...");
                Thread.Sleep(2000);
                Console.WriteLine("Food is ready!");
            });
            cook.Start();
            Console.WriteLine("i am from main thread....");
            Thread.Sleep(5000);
            Console.WriteLine("inside main thread");
        }
        public static void CountFunc()
        {
            int counter = 0;
            Thread t1 = new Thread(() => { 
              for(int i=0; i<100000; i++)
                {
                    counter++;
                }
            });
            Thread t2 = new Thread(() => {
                for (int i = 0; i < 100000; i++)
                {
                    counter++;
                }
            });
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine(counter);
        }
        public static void CountFuncFix()
        {
            int counter = 0;
            object gate = new object();
            Thread t1 = new Thread(() => {
                for (int i = 0; i < 100000; i++)
                {
                   lock(gate)  // Acquire, waiting if necessary.
                    {

                    counter++;// Execute while holding the lock.
                    } // Automatically release.
                }
            });
            Thread t2 = new Thread(() => {
                for (int i = 0; i < 100000; i++)
                {
                    lock (gate)
                    {

                    counter++;
                    }
                }
            });
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine(counter);
        }
    }
}
