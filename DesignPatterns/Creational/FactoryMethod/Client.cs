namespace Altkom._8_10._07._2024.DesignPatterns.Creational.FactoryMethod
{
    internal class Client
    {
        public static void Execute()
        {
            var elevator = new MyElevator();

            var input = "Down";
            var floor = 3;

            /*IElevatorOperation elevatorOperation = null;
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
            */

            elevator.Execute(input, floor);


            input = "GoTo";
            elevator.Execute(input, floor);

            input = "Left";
            elevator.Execute(input, floor);
        }


        class MyElevator : Elevator
        {
            protected override IElevatorOperation? GetOperation(string operation)
            {
                if (operation == "Left")
                    return new ElevatorLeft();

                return base.GetOperation(operation);
            }

            class ElevatorLeft : IElevatorOperation
            {
                public void Operate(int floor)
                {
                    Console.WriteLine($"Winda skręca w lewo na piętrze {floor}");
                }
            }
        }
    }
}
