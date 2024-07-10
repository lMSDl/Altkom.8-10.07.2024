namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Memento
{
    internal class Caretaker<T> where T : ICloneable, IRestorable<T>
    {
        private ICollection<Memento<T>> _mementos = new List<Memento<T>>();

        protected T originator;
        public Caretaker(T originator)
        {
            this.originator = originator;
        }

        public void SaveState()
        {
            var memento = new Memento<T>(originator);
            _mementos.Add(memento);
            Console.WriteLine($"Caretaker: snapshot {memento.DateTime}");
        }

        public void RestoreState()
        {
            var memento = _mementos.LastOrDefault();
            if (memento != null)
            {
                RestoreState(memento);
                _mementos.Remove(memento);
            }
        }

        public void RestoreState(DateTime dateTime)
        {
            var memento = _mementos.LastOrDefault(x => x.DateTime <= dateTime);
            if (memento != null)
            {
                RestoreState(memento);
            }
        }

        protected virtual void RestoreState(Memento<T>? memento)
        {
            originator.Restore(memento.State);
            Console.WriteLine($"Caretaker: restored {memento.DateTime}");
        }
    }
}
