using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.ChainOfResponsibilityDesignPattern
{
    internal class WarningHandler : Handler
    {
        public WarningHandler(Handler handler):base(handler) { }
        public override void HandleRequest(Request request)
        {
            if (CanHandle(request))
            {
                Console.WriteLine("Request is being handled by Warning Handler , level : " + request.getLevel());
            }
            else
            {
                Console.WriteLine("WarningHandler can't handle this level of Request Forwarding to next Handler , level : " + request.getLevel());
                GetNextHandler().HandleRequest(request);
            }
        }

        protected override bool CanHandle(Request request)
        {
            if (request.getLevel() < 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
