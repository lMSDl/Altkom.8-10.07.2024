namespace Altkom._8_10._07._2024.DesignPatterns.Creational.Builder
{
    internal class VehilceProductionInfoBuilder : VehicleBuilderFacade
    {
        public VehilceProductionInfoBuilder(Vehicle item) : base(item)
        {
        }
        public VehilceProductionInfoBuilder() : this(new Vehicle())
        {
        }

        public VehilceProductionInfoBuilder SetManufacturer(string manufacturer)
        {
            Item.Manufacturer = manufacturer;
            return this;
        }

        public VehilceProductionInfoBuilder SetProductionYear(int year)
        {
            Item.ProductionYear = year;
            return this;
        }
    }
}
