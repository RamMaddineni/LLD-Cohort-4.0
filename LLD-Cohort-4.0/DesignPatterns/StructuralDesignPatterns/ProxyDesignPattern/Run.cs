using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
    internal class Run
    {
        public static void Start()
        {

            Console.WriteLine("--Proxy design Pattern Starts---");

            IInternet internet = new ProxyInternet();
            internet.ConnectTo("google.com");
            internet.ConnectTo("banned.com");


            Console.WriteLine("--Proxy design Pattern Ends---");

        }
    }
}
