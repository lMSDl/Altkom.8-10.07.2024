namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Flyweight
{
    internal class Product
    {
        public string Manufacturer { get => Flyweight.Manufacturer; set => SetValue(x => x.Manufacturer = value); }
        public string Name { get => Flyweight.Name; set => SetValue(x => x.Name = value); }
        public string Description { get => Flyweight.Description; set => SetValue(x => x.Description = value); }
        public byte[] Logo { get => Flyweight.Logo; set => SetValue(x => x.Logo = value); }
        public int Weight { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public ProductFlyweight Flyweight { get; set; } = new ProductFlyweight();


        private void SetValue(Action<ProductFlyweight> action)
        {
            var clone = (ProductFlyweight)Flyweight.Clone();
            action(clone);
            Flyweight = FlyweightFactory<ProductFlyweight>.Instance.GetFlyweight(clone);
        }


        public void ShortShowInfo()
        {
            //Console.WriteLine($"{Name}: {Weight}g");
            Flyweight.ShortShowInfo(this);
        }
    }
}
