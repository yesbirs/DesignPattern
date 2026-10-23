using StrategyPattern;

namespace DesignPattern
{
    public static class NotificationFactory
    {
        public static INotificationStrategy CreateNotificationStrategy(string type)
        {
            return type switch
            {
                "WhatsApp" => new WhatsAppNotification(),
                "Email" => new EmailNotification(),
                "SMS" => new SMSNotification(),
                _ => throw new ArgumentException("Invalid notification type")
            };
        }
    }
}