using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.ChainOfResponsibilityDesignPattern
{
    internal class FatalHandler : Handler
    {
        public FatalHandler(Handler handler) : base(handler) { }
        public override void HandleRequest(Request request)
        {
            if (CanHandle(request))
            {
                Console.WriteLine("Request is being handled by FatalHandler , level : "+request.getLevel());
            }
            else
            {
                Console.WriteLine("FatalHandler can't handle this level escalating to your HR , level : " + request.getLevel());
               
            }
        }

        protected override bool CanHandle(Request request)
        {
            if (request.getLevel() < 6)
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
