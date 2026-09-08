using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.Assignment1
{
    internal class Transaction
    {
        public string transactionId {get;}
        public string customerId { get; }
        public double amount { get; }
        public string currency { get; }
        public string notes { get; }
        public DateTime timestamp { get; }

        private Transaction(TransactionBuilder buildObj) { 
            this.transactionId = buildObj.transactionId;
            this.customerId = buildObj.customerId;
            this.amount = buildObj.amount;
            this.currency = buildObj.currency;
            this.notes = buildObj.notes;
            this.timestamp = buildObj.timestamp;

        }

        public class TransactionBuilder
        {
            public string transactionId { get; }
            public string customerId { get; }
            public double amount { get; }
            public string currency { get; set; }
            public string notes { get; set; }
            public DateTime timestamp { get; set; }

            public TransactionBuilder(string transactionId,string customerId,double amount)
            {
                this.transactionId = transactionId;
                this.customerId = customerId;
                this.amount = amount;
            }
            public TransactionBuilder SetCurrency(string currency)
            {
                this.currency = currency;
                return this;
            }
            public TransactionBuilder SetNotes(string notes)
            {
                this.notes = notes;
                return this;
            }
            public TransactionBuilder SetTime(DateTime timestamp)
            {
                this.timestamp = timestamp;
                return this;
            }
            public Transaction Build()
            {
                Transaction transaction = new Transaction(this);
                return transaction;
            }
        }
    }
}
