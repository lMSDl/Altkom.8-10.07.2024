namespace Altkom._8_10._07._2024.DesignPatterns.Creational.Builder
{
    internal class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(4, 5, 4, 500, 100);

            Console.WriteLine(vehicle);

            var builder = new VehilceBuilder();

            builder.SetWheels(4);
            builder.SetDoors(4);
            builder.SetSeats(5);
            builder.SetEngine(100);
            builder.SetTrunk(500);

            vehicle = builder.Build();

            Console.WriteLine(vehicle);

            vehicle = new Vehicle() { Doors = 4, EnginePower = 100, Seats = 5, Wheels = 4, TrunkCapacity = 500 };

            Console.WriteLine(vehicle);

        }
    }
}
