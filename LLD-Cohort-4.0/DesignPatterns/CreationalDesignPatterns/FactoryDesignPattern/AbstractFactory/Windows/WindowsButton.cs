using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Windows
{
    internal class WindowsButton : IButton
    {
        public void RenderButton()
        {
            Console.WriteLine("Windows Button Rendering!");
        }
    }
}
