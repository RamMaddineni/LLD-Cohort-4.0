using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.WithoutFactory
{
    internal class Run
    {
        public static void Start()
        {

            Console.WriteLine("---Without factory start---");
            Notification obj;

            string type = "sms";
            if (type == "sms")
            {
                obj = new SMSNotification();
            }
            else
            {
                obj = new SMSNotification();
            }

            obj.send("Hi there!");
            Console.WriteLine("---Without Factory end---");

        }

    }
}
