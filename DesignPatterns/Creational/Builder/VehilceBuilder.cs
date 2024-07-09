namespace Altkom._8_10._07._2024.DesignPatterns.Creational.Builder
{
    internal class VehilceBuilder : VehicleBuilderFacade
    {
        public VehilceBuilder(Vehicle item) : base(item)
        {
        }

        public VehilceBuilder() : this(new Vehicle())
        {
        }


        public VehilceBuilder SetWheels(int wheels)
        {
            Item.Wheels = wheels;
            return this;
        }

        public VehilceBuilder SetDoors(int doors)
        {
            Item.Doors = doors;
            return this;
        }

        public VehilceBuilder SetSeats(int seats)
        {
            Item.Seats = seats;
            return this;
        }

        public VehilceBuilder SetEngine(int? power)
        {
            Item.EnginePower = power;
            return this;
        }

        public VehilceBuilder SetTrunk(int capacity)
        {
            Item.TrunkCapacity = capacity;
            return this;
        }
    }
}
