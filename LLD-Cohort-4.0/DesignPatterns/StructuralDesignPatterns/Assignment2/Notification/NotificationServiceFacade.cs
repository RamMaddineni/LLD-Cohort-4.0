using LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.Adapters;
using LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.ThirdPartyNotificationAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.Notification
{
    internal class NotificationServiceFacade 
    {
        public NotificationServiceFacade() {
        }

        public void SendOrderPlaced(string user)
        {
            //Normal Notification
            INotification notification = new EncryptionDecorator( new AnalyticsDecorator( new LoggingDecorator( new RetryDecorator(new Email()))));
            notification.Send(user, "Order Placed!");

            //Thrid Party Notification
            INotification firebaseNotification = new FirebaseAdapter(new FirebasePush());
            firebaseNotification= new EncryptionDecorator(new AnalyticsDecorator(new LoggingDecorator(new RetryDecorator(firebaseNotification))));
            firebaseNotification.Send(user, "Order Placed!");

        }
    }
}
