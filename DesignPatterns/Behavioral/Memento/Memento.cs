namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Memento
{
    internal class Memento<T> where T : ICloneable
    {
        private readonly T _state;

        public T State => (T)_state.Clone();
        public DateTime DateTime { get; }

        public Memento(T state)
        {
            _state = (T)state.Clone();
            DateTime = DateTime.Now;
        }

    }
}
