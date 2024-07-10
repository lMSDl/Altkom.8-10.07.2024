namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Observer
{
    internal abstract class Subscriber : IObserver<int>
    {
        public IDisposable? Subscription { get; set; }
        public void OnCompleted()
        {
            Console.WriteLine($"{GetType().Name} odłączył się");
            Subscription?.Dispose();
            Subscription = null;
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{GetType().Name} otrzymał powiadomienie o błędzie: {error}");
        }

        public abstract void OnNext(int value);
    }
}
