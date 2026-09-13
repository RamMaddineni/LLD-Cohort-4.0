using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.StrategyDesignPattern
{
    internal class RoundRobinStrategy : ILoadBalancingStrategy
    {
        public void BalanceLoad(List<IServer> servers, IRequest request)
        {
            Console.WriteLine("Balancing Load at RoundRobinStrategy!");
        }
    }
}
