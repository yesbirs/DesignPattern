// Strategy Pattern: Use a switch expression to handle different cases for a variable.
using StrategyPattern;

//var notification = new NotificationService(new EmailNotification());
var notification = new NotificationService(new WhatsAppNotification());
notification.SendNotification("Your Order has shipped.");