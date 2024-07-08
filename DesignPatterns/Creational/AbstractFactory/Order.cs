using Altkom._8_10._07._2024.SOLID.L;

namespace Altkom._8_10._07._2024.DesignPatterns.Creational.AbstractFactory
{
    internal class Order
    {
        public ICar? Car { get; private set; }


        public string ManufacturedCarName()
        {
            return Car?.Name() ?? "";
        }

        public void MakeOrder(ICarFactory? carFactory, string type, string segment)
        {
            switch (type)
            {
                case nameof(ISedan):
                    Car = carFactory?.ManufactureSedan(segment);
                    break;
                case nameof(ISuv):
                    Car = carFactory?.ManufactureSuv(segment);
                    break;
            }
        }

        public void MakeOrder(string manufacturer, string type, string segment)
        {
            MakeOrder(GetCarFactory(manufacturer), type, segment);
        }

        private ICarFactory? GetCarFactory(string manufacturer)
        {
            switch(manufacturer)
            {
                case "Honda":
                    return new HondaFactory();
                case "Toyota":
                    return new ToyotaFactory();
            }
            return null;
        }
    }
}
