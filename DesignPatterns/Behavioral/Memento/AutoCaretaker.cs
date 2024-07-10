using System.ComponentModel;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Memento
{
    internal class AutoCaretaker<T> : Caretaker<T> where T : ICloneable, IRestorable<T>, INotifyPropertyChanged
    {
        public AutoCaretaker(T originator) : base(originator)
        {
            originator.PropertyChanged += Originator_PropertyChanged;
        }

        private void Originator_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            SaveState();
        }

        protected override void RestoreState(Memento<T>? memento)
        {
            originator.PropertyChanged -= Originator_PropertyChanged;
            base.RestoreState(memento);
            originator.PropertyChanged += Originator_PropertyChanged;
        }
    }
}
