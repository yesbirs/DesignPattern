using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class NotificationService
    {
        private INotificationStrategy _notificationStrategy;

        public NotificationService(INotificationStrategy notificationStrategy)
        {
            _notificationStrategy = notificationStrategy;
        }

        public void SendNotification(string message)
        {
            _notificationStrategy.Send(message);
        }
    }
}