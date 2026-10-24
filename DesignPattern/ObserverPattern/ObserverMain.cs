using ObserverPattern;
using StrategyPattern;

namespace DesignPattern.ObserverPattern
{
    public static class ObserverMain
    {
        public static void Run()
        {
            var order = new Order { OrderId = 123 };
            var customerNotificationObserver = new CustomerNotificationObserver(new EmailNotification());
            var analyticsObserver = new AnalyticsObserver();
            order.Subscribe(customerNotificationObserver);
            order.Subscribe(analyticsObserver);

            order.ShipOrder();
        }
    }
}