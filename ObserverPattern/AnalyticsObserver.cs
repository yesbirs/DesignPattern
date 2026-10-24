using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class AnalyticsObserver : IOrderObserver
    {
        public void OnOrderShipped(int orderId)
        {
            // Implementation for handling order shipped notification
            Console.WriteLine($"Analytics updated for order {orderId}");
        }
    }
}