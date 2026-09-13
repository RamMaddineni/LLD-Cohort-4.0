using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
    internal class ProxyInternet : IInternet
    {
        IInternet _internet;
        List<String> _bannedSites;
        public ProxyInternet()
        {
            _internet = new RealInternet();
            _bannedSites = new List<String>();
            _bannedSites.Add("banned.com");
        }

        public void ConnectTo(string host)
        {
            if(_bannedSites.Contains(host))
            {
                Console.WriteLine("This site is banned! "+host);
                return;
            }
            _internet.ConnectTo(host);
        }
    }
}
