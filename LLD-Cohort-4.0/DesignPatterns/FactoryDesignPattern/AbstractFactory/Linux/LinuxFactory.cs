using LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.AbstractFactory.Linux
{
    internal class LinuxFactory : I_UI_Factory
    {
        public IButton GetButton()
        {
            return new LinuxButton();
        }

        public IModal GetModal()
        {
            return new LinuxModal();
        }

        public IScreen GetScreen()
        {
            return new LinuxScreen();
        }
    }
}
