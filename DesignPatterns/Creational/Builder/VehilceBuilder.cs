namespace Altkom._8_10._07._2024.DesignPatterns.Creational.Builder
{
    internal class VehilceBuilder
    {
        private Vehicle Vehicle { get; } = new Vehicle();


        public VehilceBuilder SetWheels(int wheels)
        {
            Vehicle.Wheels = wheels;
            return this;
        }

        public VehilceBuilder SetDoors(int doors)
        {
            Vehicle.Doors = doors;
            return this;
        }

        public VehilceBuilder SetSeats(int seats)
        {
            Vehicle.Seats = seats;
            return this;
        }

        public VehilceBuilder SetEngine(int? power)
        {
            Vehicle.EnginePower = power;
            return this;
        }

        public VehilceBuilder SetTrunk(int capacity)
        {
            Vehicle.TrunkCapacity = capacity;
            return this;
        }
        public Vehicle Build()
        {

            return Vehicle;
        }
    }
}
