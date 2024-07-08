namespace Altkom._8_10._07._2024.DesignPatterns.Creational.AbstractFactory
{
    internal class Order
    {
        public ICar Car { get; private set; }


        public string ManufacturedCarName()
        {
            return Car.Name();
        }

        public void MakeOrder(string manufacturer, string type, string segment)
        {
            switch (manufacturer)
            {
                case "Honda":
                    switch (type)
                    {
                        case nameof(ISedan):
                            switch (segment)
                            {
                                case "compact":
                                    Car = new HondaCompactSedan();
                                    break;
                                case "full":
                                    Car = new HondaFullSedan();
                                    break;
                            }
                            break;
                        case nameof(ISuv):
                            switch (segment)
                            {
                                case "compact":
                                    Car = new HondaCompactSuv();
                                    break;
                                case "full":
                                    Car = new HondaFullSuv();
                                    break;
                            }
                            break;
                    }
                    break;
                case "Toyota":
                    switch (type)
                    {
                        case nameof(ISedan):
                            switch (segment)
                            {
                                case "compact":
                                    Car = new ToyotaCompactSedan();
                                    break;
                                case "full":
                                    Car = new ToyotaFullSedan();
                                    break;
                            }
                            break;
                        case nameof(ISuv):
                            switch (segment)
                            {
                                case "compact":
                                    Car = new ToyotaCompactSuv();
                                    break;
                                case "full":
                                    Car = new ToyotaFullSuv();
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
