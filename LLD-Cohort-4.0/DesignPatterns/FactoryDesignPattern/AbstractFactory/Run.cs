using LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.AbstractFactory.Interfaces;
using LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.AbstractFactory.Linux;
using LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.AbstractFactory.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.AbstractFactory
{
    internal class Run
    {
        public static void Start()
        {
            Console.WriteLine("---Abstract Factory Execution Starts---");

            I_UI_Factory windowsFactory= new WindowsFactory();
            UIRender uIRender = new UIRender(windowsFactory); 

            // now client wants to toggle to linux.
            I_UI_Factory linuxFactory = new LinuxFactory();
            uIRender.ToggleUI(linuxFactory);

            Console.WriteLine("---Abstract Factory Execution Ends---");

        }
    }
}
