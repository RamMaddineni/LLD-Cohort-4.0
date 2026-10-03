using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.CustomThreadPool
{
    internal class Run
    {
        public static void Start()
        {
            Console.WriteLine("---Custom Thread Pool Starts ---");
            CustomThreadPool pool = new CustomThreadPool(3);
            for(int i = 0; i < 10; i++)
            {
                int taskNumber = i;
                Action task = () => {
                    Console.WriteLine($"Task {taskNumber} -> Thread {Thread.CurrentThread.Name}");
                };
                pool.Submit(task);
            }
            pool.Shutdown();
            Console.WriteLine("All Tasks Finished");
        }
    }
}
