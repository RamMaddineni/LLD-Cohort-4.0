using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.Semaphore
{
    internal class PrinterServiceRunner
    {
        public static void Start()
        {
            Console.WriteLine("--- Entering PrinterServiceRunner ---");

            Queue<Printer> printers= new Queue<Printer>(new[] {new Printer("Printer 1"),new Printer("Printer 2") ,new Printer("Printer 3") });
            PrinterService printerService= new PrinterService(printers);
            List<string> documentsT1= new List<string>() {"document1","document2","document3" };
            List<string> documentsT2 = new List<string>() { "document4", "document5", "document6" };
            List<string> documentsT3 = new List<string>() { "document7", "document8", "document9" };

            Thread T1 = new Thread(() =>
            {
                foreach (string doc in documentsT1)
                {
                    printerService.Print($"Thread1: {doc}");
                }
            });
            Thread T2 = new Thread(() =>
            {
                foreach (string doc in documentsT2)
                {
                    printerService.Print($"Thread2: {doc}");
                }
            });
            Thread T3 = new Thread(() =>
            {
                foreach (string doc in documentsT3)
                {
                    printerService.Print($"Thread3: {doc}");
                }
            });
            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();

            Console.WriteLine("--- Exited PrinterServiceRunner ---");

        }
    }
}
