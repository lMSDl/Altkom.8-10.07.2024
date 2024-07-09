namespace Altkom._8_10._07._2024.DesignPatterns.Creational.Prototype
{
    internal class Client
    {
        public static void Execute()
        {
            var p0 = new Person()
            {
                FirstName = "Ewa",
                LastName = "Ewowska",
                Age = 45,
                Address = new Address { City = "Warszawa", Street = "Krakowska" },
            };

            var p1 = new Person()
            {
                FirstName = "Monika",
                LastName = "Ewowska",
                Age = 45,
                Address = new Address { City = "Warszawa", Street = "Krakowska" },
            };

            Console.WriteLine(p0);
            Console.WriteLine(p1);


        }
    }
}
