using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.StrategyDesignPattern
{
    internal class LoadBalancer
    {
        ILoadBalancingStrategy _strategy;
        List<IServer> _servers;

        public LoadBalancer(ILoadBalancingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ILoadBalancingStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SendRequest(IRequest request)
        {
            _strategy = new RoundRobinStrategy();
            _strategy.BalanceLoad(_servers, request);
        }
    }
}
