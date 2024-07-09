namespace Altkom._8_10._07._2024.DesignPatterns.Creational.Prototype
{
    public class Address : ICloneable
    {
        public string City { get; set; }
        public string Street { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}