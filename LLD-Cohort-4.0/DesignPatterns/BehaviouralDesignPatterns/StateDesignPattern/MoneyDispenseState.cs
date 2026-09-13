using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.StateDesignPattern
{
    internal class MoneyDispenseState : IATMState
    {
        ATMMachine atm;
        public MoneyDispenseState(ATMMachine atm)
        {
            this.atm = atm;
        }
        public void Cancel()
        {
        }

        public void EjectCard()
        {
        }

        public void InserCard()
        {
        }

        public void PressDispenseMoney()
        {
            Console.WriteLine("Dispensing Money!");
        }
    }
}
