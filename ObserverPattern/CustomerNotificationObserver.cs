using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CustomerNotificationObserver : IOrderObserver
    {
        private readonly INotificationStrategy _notificationStrategy;

        public CustomerNotificationObserver(INotificationStrategy _notificationStrategy)
        {
            this._notificationStrategy = _notificationStrategy;
        }

        public void OnOrderShipped(int orderId)
        {
            // Implementation for handling order shipped notification
            _notificationStrategy.Send("Order Has been shipped");
        }
    }
}