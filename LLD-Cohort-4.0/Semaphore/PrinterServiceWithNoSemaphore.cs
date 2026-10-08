using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.Semaphore
{
    internal class PrinterServiceWithNoSemaphore
    {
        BlockingCollection<Printer> _printers;
        public PrinterServiceWithNoSemaphore(BlockingCollection<Printer> printers)
        {
            _printers = printers;
        }
        public void Print(string document)
        {
            Printer printer = _printers.Take(); // handles waiting internally
            try
            {
                printer.Print(document);
            }
            finally
            {
                _printers.Add(printer);
            }
        }
    }
}
