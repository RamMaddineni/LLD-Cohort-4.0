using LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.Notification;
using LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.ThirdPartyNotificationAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.Assignment2.Adapters
{
    internal class FirebaseAdapter : INotification
    {
        private FirebasePush _firebaseNotification;
        public FirebaseAdapter(FirebasePush firebaseNotification)
        {
            _firebaseNotification = firebaseNotification;
        }

        public void Send(string user, string message)
        {
            _firebaseNotification.FirebaseSend(user, message);
        }
    }
}
