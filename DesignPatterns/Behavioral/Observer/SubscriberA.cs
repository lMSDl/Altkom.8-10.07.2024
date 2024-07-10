namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Observer
{
    internal class SubscriberA : Subscriber
    {
        public override void OnNext(int value)
        {
            if (value > 30)
            {
                Console.WriteLine("SubscriberA rozpoczął reagowanie");

                Thread.Sleep(new Random(value).Next(1000, 5000));

                Console.WriteLine($"SubscriberA zareagował na {value}");
            }
        }
    }
}