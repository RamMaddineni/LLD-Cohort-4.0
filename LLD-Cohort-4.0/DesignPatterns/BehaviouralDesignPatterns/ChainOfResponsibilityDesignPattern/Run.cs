using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.ChainOfResponsibilityDesignPattern
{
    internal class Run
    {
        public static void Start()
        {

            Console.WriteLine("--- Chain of Responsibilty Starts ---");
            Request r1 = new Request(1);
            Request r2 = new Request(2);
            Request r3 = new Request(3);
            Request r4 = new Request(4);
            Request r5 = new Request(5);
            Request r6 = new Request(6);

            FatalHandler fatalHandler = new FatalHandler(null);
            ErrorHandler errorHandler = new ErrorHandler(fatalHandler);
            WarningHandler warningHandler = new WarningHandler(errorHandler);

            warningHandler.HandleRequest(r1);
            warningHandler.HandleRequest(r2);
            warningHandler.HandleRequest(r3);
            warningHandler.HandleRequest(r4);
            warningHandler.HandleRequest(r5);
            warningHandler.HandleRequest(r6);

            fatalHandler.HandleRequest(r1);
            Console.WriteLine("--- Chain of Responsibilty Ends ---");




        }
    }
}
