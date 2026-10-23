// Strategy Pattern: Use a switch expression to handle different cases for a variable.
using StrategyPattern;
using DesignPattern;

//var notification = new NotificationService(new EmailNotification());
//var notification = new NotificationService(new WhatsAppNotification());
//notification.SendNotification("Your Order has shipped.");

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