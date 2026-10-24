using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Order
    {
        private readonly List<IOrderObserver> _observers = new List<IOrderObserver>();
        public int OrderId { get; set; }

        public void Subscribe(IOrderObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IOrderObserver observer)
        {
            _observers.Remove(observer);
        }

        public void ShipOrder()
        {
            // Logic to ship the order
            Console.WriteLine($"Order {OrderId} has been shipped.");
            // Notify all observers
            foreach (var observer in _observers)
            {
                observer.OnOrderShipped(OrderId);
            }
        }
    }
}