using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Interfaces;
using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Mac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Mac
{
    internal class MacFactory : I_UI_Factory
    {
        public IButton GetButton()
        {
            return new MacButton();
        }

        public IModal GetModal()
        {
            return new MacModal();
        }

        public IScreen GetScreen()
        {
            return new MacScreen();
        }
    }
}
