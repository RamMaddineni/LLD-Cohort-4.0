using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    internal class PasswordValidator
    {
        public bool Validate(String username,String password)
        {
            Console.WriteLine("Validating Password!");
            return true;
        }
    }
}
