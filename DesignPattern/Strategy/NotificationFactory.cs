using StrategyPattern;

namespace DesignPattern.Strategy
{
    public static class NotificationFactory
    {
        public static INotificationStrategy CreateNotificationStrategy(string type)
        {
            return type.ToLower() switch
            {
                "whatsapp" => new WhatsAppNotification(),
                "email" => new EmailNotification(),
                "sms" => new SMSNotification(),
                _ => throw new ArgumentException("Invalid notification type")
            };
        }
    }
}