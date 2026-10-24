using StrategyPattern;

namespace DesignPattern.Strategy
{
    public static class StrategyMain
    {
        public static void Run()
        {
            Console.Write("Choose notification (email/sms/whatsapp): ");
            string? type = Console.ReadLine();

            try
            {
                INotificationStrategy strategy = NotificationFactory.CreateNotificationStrategy(type ?? "");

                var notification = new NotificationService(strategy);

                notification.SendNotification("Your order has shipped.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}