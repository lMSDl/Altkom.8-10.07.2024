namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Flyweight
{
    internal class Client
    {

        public static void Execute()
        {
            FlyweightFactory<ProductFlyweight>.Instance.Initialize(
                new ProductFlyweight
                {
                    Name = "N1",
                    Description = "D1",
                    Manufacturer = "M1"
                },
                new ProductFlyweight
                {
                    Name = "N1",
                    Description = "D2",
                    Manufacturer = "M1"
                },
                new ProductFlyweight
                {
                    Name = "N1",
                    Description = "D1",
                    Manufacturer = "M2"
                });

            //Console.WriteLine(FlyweightFactory<ProductFlyweight>.Instance);

            var product1 = new Product
            {
                Name = "N1",
                Description = "D1",
                ExpirationDate = DateTime.Now.AddDays(30),
                ProductionDate = DateTime.Now,
                Weight = 100,
                Manufacturer = "M1"
            };
            //product1.Flyweight = FlyweightFactory<ProductFlyweight>.Instance.GetFlyweight(product1.Flyweight);

            var product11 = new Product
            {
                Name = "N1",
                Description = "D2",
                ExpirationDate = DateTime.Now.AddDays(30),
                ProductionDate = DateTime.Now,
                Weight = 100,
                Manufacturer = "M1"
            };
            //product11.Flyweight = FlyweightFactory<ProductFlyweight>.Instance.GetFlyweight(product11.Flyweight);

            product11.Name = "N2";
            /*product11.Flyweight = FlyweightFactory<ProductFlyweight>.Instance.GetFlyweight(
                          new ProductFlyweight() { Name = "N2", Description = product11.Description, Logo = product11.Logo, Manufacturer = product11.Manufacturer }
                );*/
            //product11.Flyweight = (ProductFlyweight)product11.Flyweight.Clone();
            //product11.Name = "N2";
            //product11.Flyweight = FlyweightFactory<ProductFlyweight>.Instance.GetFlyweight(product11.Flyweight);

            var product2 = new Product
            {
                Name = "N2",
                Description = "D2",
                ExpirationDate = DateTime.Now.AddDays(30),
                ProductionDate = DateTime.Now,
                Weight = 100,
                Manufacturer = "M2"
            };
            //product2.Flyweight = FlyweightFactory<ProductFlyweight>.Instance.GetFlyweight(product2.Flyweight);


            Show(product1);
            Show(product2);

            Console.WriteLine(FlyweightFactory<ProductFlyweight>.Instance);
        }

        static void Show(Product product)
        {
            Console.WriteLine($"{product.Name}; {product.Description}; {product.Manufacturer}; {product.ProductionDate.ToShortDateString()}; {product.ExpirationDate.ToShortDateString()}");
        }
    }
}
