using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.Notification
{
    internal class EncryptionDecorator : NotificationDecorator
    {
        public EncryptionDecorator(INotification notification) : base(notification) { }

        public override void Send(string user, string message)
        {
            Console.WriteLine("Entering Encryption Decorator and Encrypting the message");
            message = message + " Encrypted message";
            _wrappedNotification.Send(user, message);
            Console.WriteLine("Existing Encryption Decorator");
        }
    }
}
