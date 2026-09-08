using LLD_Cohort_4._0.DesignPatterns.Assignment1.Logging;
using LLD_Cohort_4._0.DesignPatterns.Assignment1.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.Assignment1
{
    internal class Client
    {
        public static void Start()
        {
            // Client wants Upi payment type;
            Console.WriteLine("---Assignment 1 Starts---");
            IPaymentProcessorFactory upiFactory = new UpiProcessorFactory();
            ProcessPayment(upiFactory,40);
            Console.WriteLine("---Assignment 1 Ends---");
        }
        static void ProcessPayment(IPaymentProcessorFactory factory,double amount)
        {
            IPaymentProcessor processor = factory.GetPaymentProcessor();

            Transaction transaction = new Transaction.TransactionBuilder("txId1", "custId1", amount).SetCurrency("INR").SetNotes("Assigment 1, transaction 1").SetTime(DateTime.UtcNow).Build();
            processor.ProcessPayment(transaction.amount);

            TransactionLogger.GetTransactionLogger().Log("Transaction Success (transactionId,amount) : "+transaction.transactionId+" "+transaction.amount);
        }
    }
}
