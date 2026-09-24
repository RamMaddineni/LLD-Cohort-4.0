using LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2
{
    internal class Run
    {
        public static void Start()
        {
            Console.WriteLine("---Assignment 2 : Structural Design Patterns---");
            NotificationServiceFacade notificationServiceFacade = new NotificationServiceFacade();
            notificationServiceFacade.SendOrderPlaced("ram@abc.com");
            Console.WriteLine("---Assignment 2 Ends---");
        }
    }
}
