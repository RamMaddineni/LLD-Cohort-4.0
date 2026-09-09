using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Interfaces
{
    internal interface I_UI_Factory
    {
        IButton GetButton();
        IModal GetModal();
        IScreen GetScreen();
    }
}
