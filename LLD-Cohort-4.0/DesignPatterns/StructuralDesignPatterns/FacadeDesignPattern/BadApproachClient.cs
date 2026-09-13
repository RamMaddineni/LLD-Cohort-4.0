using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    internal class BadApproachClient
    {
        public static void Start()
        {
            Console.WriteLine("--- Bad Approach without using Facade Design Pattern Starts---");
            PasswordValidator passwordValidator = new PasswordValidator();
            OtpService otpService = new OtpService();
            TokenService tokenService = new TokenService();
            AuditLogger auditLogger = new AuditLogger();
            if(passwordValidator.Validate("ram","123") && otpService.VerifyOtp("Ram", "12343"))
            {
                String token = tokenService.GenerateToken("Ram");
                auditLogger.LogLogin("Ram");
                Console.WriteLine("Login Success " + token);
            }
            Console.WriteLine("--- Bad Approach without using Facade Design Pattern Ends!---");
        }

        /*Why this is bad?
         * Client controller knows too much!
         * Flow Logic duplicated across services or different clients.
         * Any auth change? then need to change every client
         * hard to test and evolve
*/
    }
}
