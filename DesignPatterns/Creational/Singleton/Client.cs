namespace Altkom._8_10._07._2024.DesignPatterns.Creational.Singleton
{
    internal class Client
    {
        public static void Execute()
        {
            var service1 = new Context().GetSettings("1");
            Console.WriteLine($"Service: {service1}");

            var service2 = new Context().GetSettings("2");
            Console.WriteLine($"Service: {service2}");

            new Context().SetSettings("2", "X");
            service2 = new Context().GetSettings("2");
            Console.WriteLine($"Service: {service2}");
        }
    }
}
