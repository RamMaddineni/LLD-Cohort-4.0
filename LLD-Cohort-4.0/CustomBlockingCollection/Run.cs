using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.CustomBlockingCollection
{
    internal class Run
    {
        public static void Start()
        {
            Console.WriteLine(Console.ForegroundColor);
            Console.WriteLine("---CustomBlocking Collection Starts---");
            var queue= new CustomBlockingCollection<int>(3);
            Thread producer = new Thread(() => { 
            
                for(int i = 0; i < 5; i++)
                {
                    queue.Add(i);
                }
            });
            Thread consumer = new Thread(() => { 
            
                for(int i=0;i< 5; i++)
                {
                    int item=queue.Take();
                    Console.WriteLine(item);
                }
            });
            producer.Start();
            consumer.Start();
            producer.Join();
            consumer.Join();
            Console.WriteLine("---Custom Blocking Collection Ends---");
        }
    }
}
