using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.AdapterDesignPattern
{
    internal class StripePaymentAdapter : IPaymentProcessor
    {
        private StripePaymentGateway _stripePaymentGateway;
        public StripePaymentAdapter(StripePaymentGateway stripePaymentGateway)
        {
            _stripePaymentGateway = stripePaymentGateway;
        }

        public void Pay(int amount)
        {
            _stripePaymentGateway.MakePayment(amount);
        }
    }
}
