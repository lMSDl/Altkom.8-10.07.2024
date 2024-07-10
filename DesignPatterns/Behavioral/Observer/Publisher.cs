namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Observer
{
    internal class Publisher : IObservable<int>, IDisposable
    {
        private List<IObserver<int>> _observers = new();
        public IDisposable Subscribe(IObserver<int> observer)
        {
            Console.WriteLine($"{observer.GetType().Name} podłączył się");
            _observers.Add(observer);

            return new Subscription(() => _observers.Remove(observer));
        }

        public int Index { get; set; }
        public async Task Work()
        {
            for (int i = 0; i < 15; i++)
            {
                await Task.Delay(1000);
                var second = DateTime.Now.Second;
                if (second % 3 == 0)
                {
                    Index = second;
                    Notify();
                }
            }
        }

        private void Notify()
        {
            Console.WriteLine($"Powiadomienie: {Index}");
            if (Index == 0)
            {
                foreach (var observer in _observers.ToList())
                {
                    observer.OnError(new IndexOutOfRangeException(Index.ToString()));
                }
            }
            else
            {
                foreach (var observer in _observers.ToList())
                {
                    //observer.OnNext(Index);
                    Task.Run(() => observer.OnNext(Index));
                }
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Zamknięcie źródła");
            foreach (var observer in _observers.ToList())
            {
                observer.OnCompleted();
            }
        }
    }
}
