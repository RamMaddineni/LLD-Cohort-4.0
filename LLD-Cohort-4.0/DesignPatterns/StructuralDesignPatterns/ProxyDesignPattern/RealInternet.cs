using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
    internal class RealInternet : IInternet
    {
        public void ConnectTo(string host)
        {
            Console.WriteLine("Connecting to Internet at " + host);
        }
    }
}
