namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Decorator
{
    internal class SmsNotification : BaseDecorator
    {
        public SmsNotification(INotification notification) : base(notification)
        {
        }

        public int MaxLength { get; } = 10;

        protected override void ExtraSend(string message)
        {
            foreach (var item in Enumerable.Range(0, message.Length / MaxLength).Select(i => message.Substring(i * MaxLength, MaxLength)))
            {
                Console.WriteLine($"SMS: {item}");
            }
        }
    }
}
