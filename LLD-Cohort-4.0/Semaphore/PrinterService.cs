using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.Semaphore
{
    internal class PrinterService
    {
        private readonly Queue<Printer> _printersQueue = new Queue<Printer>();
        private readonly object _gate=new object();
        private SemaphoreSlim _printerSemaphore;
        public PrinterService(Queue<Printer> printersQueue)
        {
            _printersQueue = printersQueue;
            int capacity= _printersQueue.Count;
            _printerSemaphore = new SemaphoreSlim(capacity,capacity);// initially all printers are available.
        }
        public void Print(string document)
        {
            _printerSemaphore.Wait();
            Printer printer;
            lock(_gate) 
            {
             printer = _printersQueue.Dequeue(); // critical section, being guarded by lock to ensure only one thread can access at a time.
            }
            try
            {
                printer.Print(document);
            }
            finally
            {
                lock (_gate)
                {
                    _printersQueue.Enqueue(printer);
                }
                _printerSemaphore.Release();
            }
            
        }
    }
}
