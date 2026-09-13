using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.StateDesignPattern
{
    internal class ATMMachine
    {
        IATMState currentState;
        IATMState noCardState;
        IATMState hasCardState;
        IATMState moneyDispenseState;

        public ATMMachine()
        {
            this.noCardState= new NoCardState(this);
            this.currentState = this.noCardState;
            this.hasCardState= new HasCardState(this);
            this.moneyDispenseState = new MoneyDispenseState(this);
        }

        public IATMState GetNoCardState()
        {
            return this.noCardState;
        }
        public IATMState GetHasCardState()
        {
            return this.hasCardState;
        }
        public IATMState GetMoneyDispenseState()
        {
            return this.moneyDispenseState;
        }
        public void SetState(IATMState state)
        {
            this.currentState = state;
        }
        public void PleaseInsertCard()
        {
            currentState.InserCard();
        }

        public void DispenseCash()
        {
            currentState.PressDispenseMoney();
        }
        public void RemoveCard()
        {
            currentState.EjectCard();
        }

    }
}
