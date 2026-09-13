using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.BehaviouralDesignPatterns.StateDesignPattern
{
    internal interface IATMState
    {
        void InserCard();
        void PressDispenseMoney();
        void Cancel();
        void EjectCard();
    }
}
