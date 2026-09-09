using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Interfaces;
using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Windows
{
    internal class WindowsFactory : I_UI_Factory
    {
        public IButton GetButton()
        {
            return new WindowsButton();
        }

        public IModal GetModal()
        {
            return new WindowsModal();
        }

        public IScreen GetScreen()
        {
            return new WindowsScreen();
        }
    }
}
