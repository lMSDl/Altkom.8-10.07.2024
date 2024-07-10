using System.ComponentModel;
using System.Text.Json;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Memento
{
    internal class Person : ICloneable, IRestorable<Person>, INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Restore(Person state)
        {
            FirstName = state.FirstName;
            LastName = state.LastName;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
