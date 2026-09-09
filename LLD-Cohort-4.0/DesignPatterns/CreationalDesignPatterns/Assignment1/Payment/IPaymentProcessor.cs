using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.Assignment1.Payment
{
    internal interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }
}
