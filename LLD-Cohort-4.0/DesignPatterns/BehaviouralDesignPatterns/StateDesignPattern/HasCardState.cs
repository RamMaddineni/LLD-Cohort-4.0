using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.StateDesignPattern
{
    internal class HasCardState : IATMState
    {
        ATMMachine atm;
        public HasCardState(ATMMachine atm)
        {
            this.atm = atm;
        }
        public void Cancel()
        {
        }

        public void EjectCard()
        {
            Console.WriteLine("Card Ejected!");
            atm.SetState(atm.GetNoCardState());
        }

        public void InserCard()
        {
        }

        public void PressDispenseMoney()
        {
            Console.WriteLine("Dispensing Money!");
            atm.SetState(atm.GetMoneyDispenseState());
        }
    }
}
