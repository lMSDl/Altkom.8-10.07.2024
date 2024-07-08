namespace Altkom._8_10._07._2024.DesignPatterns.Creational.Builder
{
    internal class VehilceBuilder
    {
        private Vehicle Vehicle { get; } = new Vehicle();


        public void SetWheels(int wheels)
        {
            Vehicle.Wheels = wheels;
        }

        public void SetDoors(int doors)
        {
            Vehicle.Doors = doors;
        }

        public void SetSeats(int seats)
        {
            Vehicle.Seats = seats;
        }

        public void SetEngine(int? power)
        {
            Vehicle.EnginePower = power;
        }

        public void SetTrunk(int capacity)
        {
            Vehicle.TrunkCapacity = capacity;
        }
        public Vehicle Build()
        {

            return Vehicle;
        }
    }
}
