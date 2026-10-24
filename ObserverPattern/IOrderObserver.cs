namespace ObserverPattern
{
    public interface IOrderObserver
    {
        void OnOrderShipped(int orderId);
    }
}