using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.ThirdPartyNotificationAPI
{
    internal class SendGridEmail
    {
        public void SendEmail(string user, string message)
        {
            Console.WriteLine("Email : "+user+" "+message);
        }
    }
}
