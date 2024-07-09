using System.Text.Json;

namespace Altkom._8_10._07._2024.DesignPatterns.Creational.Prototype
{
    internal class Person : ICloneable
    {
        public Person? Parent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address? Address { get; set; }

        //public IEnumerable<Person> Childred { get; set; }

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = (Address?)Address?.Clone();
            return clone;
        }

        public object DeepClone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = (Address?)Address?.Clone();
            clone.Parent = (Person?)Parent?.Clone();
            return clone;
        }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
