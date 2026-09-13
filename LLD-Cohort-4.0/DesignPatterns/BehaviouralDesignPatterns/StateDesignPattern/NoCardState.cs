using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.StateDesignPattern
{
    internal class NoCardState : IATMState
    {
        ATMMachine atm;
        public NoCardState(ATMMachine atm)
        {
            this.atm = atm;
        }

        public void Cancel()
        {
        }

        public void EjectCard()
        {
            Console.WriteLine("There is no card inserted yet!");
        }

        public void InserCard()
        {
            Console.WriteLine("Card Inserted!");
            atm.SetState(atm.GetHasCardState());
        }

        public void PressDispenseMoney()
        {
            Console.WriteLine("Please Insert Card First!");
        }
    }
}
