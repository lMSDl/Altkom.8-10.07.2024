namespace Altkom._8_10._07._2024.DesignPatterns.Creational.FactoryMethod
{
    internal class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var input = "Down";
            var floor = 3;

            IElevatorOperation elevatorOperation = null;
            switch (nameof(Elevator) + input)
            {
                case nameof(ElevatorDown):
                    elevatorOperation = new ElevatorDown();
                    break;
                case nameof(ElevatorUp):
                    elevatorOperation = new ElevatorUp();
                    break;
            }

            if(elevatorOperation != null)
                elevator.Execute(elevatorOperation, floor);

        }
    }
}
