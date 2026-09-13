using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    internal class TokenService
    {
        public String GenerateToken(String username)
        {
            Console.WriteLine("Generating JWT Token!");
            return "jwt-token";
        }
    }
}
