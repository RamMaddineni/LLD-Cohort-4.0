using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.Semaphore
{
    internal class Printer
    {
        string _name;
        public Printer(string name)
        {
            _name = name;
        }
        public void Print(string document)
        {
            Console.WriteLine($"Printer : {_name} is currently printing {document}");
            Thread.Sleep(1000);
            Console.WriteLine($"Printer : {_name} is done printing {document}!");
        }
    }
}
