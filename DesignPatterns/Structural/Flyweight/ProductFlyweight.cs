namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Flyweight
{
    internal class ProductFlyweight : ICloneable
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Logo { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void ShortShowInfo(Product product)
        {
            Console.WriteLine($"{Name}: {product.Weight}g");
        }
    }
}
