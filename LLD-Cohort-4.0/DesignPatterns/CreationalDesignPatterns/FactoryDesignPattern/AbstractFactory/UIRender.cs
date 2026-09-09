using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory
{

    // We can see the benefit of I_UI_factory here, the I_UI_factory abstracts away the groping of windows,mac,linux ideas where each of them have seperate classes for each product.
    internal class UIRender
    {
        IButton button;
        IModal modal;
        IScreen screen;
        public UIRender(I_UI_Factory factory)
        {
            button = factory.GetButton();
            modal = factory.GetModal();
            screen = factory.GetScreen();
            RenderUI();
        }
        public void RenderUI()
        {
            button.RenderButton();
            modal.RenderModal();
            screen.RenderScreen();

        }
        public void ToggleUI(I_UI_Factory factory)
        {
            button = factory.GetButton();
            modal = factory.GetModal();
            screen = factory.GetScreen();
            RenderUI();
        }
    }
}
