namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Decorator
{
    internal class Client
    {
        public static void Execute()
        {
            while (true)
            {
                var text = Console.ReadLine();
                INotification notification = GetNotification();

                notification.Send(text);
            }
        }

        private static INotification GetNotification()
        {
            INotification notification = new SystemNotification();

            if (DateTime.Now.Second % 2 == 0)
                notification = new EmailNotification(notification);

            if (DateTime.Now.Second % 3 == 0)
                notification = new SmsNotification(notification);
            return notification;
        }
    }
}
