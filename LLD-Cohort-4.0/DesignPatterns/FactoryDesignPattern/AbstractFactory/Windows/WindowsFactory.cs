using LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.AbstractFactory.Windows
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
