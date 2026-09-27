using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.ChainOfResponsibilityDesignPattern
{
    internal class Request
    {
        int _level;
        public Request(int level)
        {
            _level = level;
        }
        public int getLevel() { return _level; }

    }
}
