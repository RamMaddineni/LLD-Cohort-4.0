using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.ChainOfResponsibilityDesignPattern
{
    internal abstract class Handler
    {
        private Handler _nextHandler;
        public Handler(Handler nextHandler)
        {
            _nextHandler = nextHandler;
        }
        protected abstract bool CanHandle(Request request);

        abstract public void HandleRequest(Request request);
        protected Handler GetNextHandler()
        {
            return _nextHandler;
        }

    }
}
