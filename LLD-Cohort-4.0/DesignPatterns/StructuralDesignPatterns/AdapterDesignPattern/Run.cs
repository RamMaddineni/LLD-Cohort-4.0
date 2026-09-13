using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.AdapterDesignPattern
{
    internal class Run
    {
        //Adapter acts as a translator between two incompatible interfaces.
        public static void Start()
        {
            IPaymentProcessor paymentProcessor = new StripePaymentAdapter(new StripePaymentGateway());
            paymentProcessor.Pay(40);

        }
    }
}
