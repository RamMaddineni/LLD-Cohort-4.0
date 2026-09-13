using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    internal class Run
    {
        public static void Start()
        {
            Console.WriteLine("---Facade Design Pattern Starts---");
            AuthenticationFacade authenticationFacade = new AuthenticationFacade();
            String token = authenticationFacade.Login("Ram!", "pass12334", "otp12345");
            Console.WriteLine("Login Successful "+token);
            Console.WriteLine("---Facade Design Pattern Ends---");
        }
/*  Facade Design Pattern : 
        Workflow simplification for the client*/
    }
}
