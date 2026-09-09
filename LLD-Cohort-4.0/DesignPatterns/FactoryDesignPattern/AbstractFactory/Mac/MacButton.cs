using LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.AbstractFactory.Mac
{
    internal class MacButton : IButton
    {
        public void RenderButton()
        {
            Console.WriteLine("Mac Button Rendering!");
        }
    }
}
