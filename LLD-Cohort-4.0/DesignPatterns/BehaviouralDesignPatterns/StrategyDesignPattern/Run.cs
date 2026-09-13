using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.StrategyDesignPattern
{
    internal class Run
    {
        public static void Start()
        {
            Console.WriteLine("---Starting Strategy Design Pattern : Behavioural -----");
            ILoadBalancingStrategy roundRobinStrategy= new RoundRobinStrategy();
            ILoadBalancingStrategy leastConnectionStrategy= new LeastConnectionStrategy();
            IRequest request= new Request();
            LoadBalancer loadBalancer = new LoadBalancer(roundRobinStrategy);
            loadBalancer.SendRequest(request);
            loadBalancer.SetStrategy(leastConnectionStrategy);
            loadBalancer.SendRequest(request);
            Console.WriteLine("---Starting Strategy Design Pattern Ends : Behavioural -----");

        }
    }
}
