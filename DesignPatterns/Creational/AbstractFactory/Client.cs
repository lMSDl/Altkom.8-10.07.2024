namespace Altkom._8_10._07._2024.DesignPatterns.Creational.AbstractFactory
{
    internal class Client
    {
        public static void Execute()
        {
            Order order = new Order();

            order.MakeOrder("Honda", nameof(ISedan), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order.MakeOrder("Toyota", nameof(ISedan), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order.MakeOrder("Toyota", nameof(ISuv), "full");
            Console.WriteLine(order.ManufacturedCarName());
        }
    }
}
