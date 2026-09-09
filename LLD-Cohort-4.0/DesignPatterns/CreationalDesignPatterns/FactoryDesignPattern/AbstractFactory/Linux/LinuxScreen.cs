using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Linux
{
    internal class LinuxScreen : IScreen
    {
        public void RenderScreen()
        {
            Console.WriteLine("Linux Screen Rendering!");
        }
    }
}
