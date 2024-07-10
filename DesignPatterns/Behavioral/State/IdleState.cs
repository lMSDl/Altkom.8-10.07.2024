﻿namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.State
{
    internal class IdleState : State
    {
        private readonly CancellationTokenSource _cancellationTokenSource;
        public IdleState(CoffeeMachine coffeeMachine) : base(coffeeMachine)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Delay(5000).ContinueWith(x =>
            {
                if (!_cancellationTokenSource.IsCancellationRequested)
                    CoffeeMachine.State = new HeatingUpState(CoffeeMachine);
                _cancellationTokenSource.Dispose();
            });
        }

        public override void Large()
        {
            _cancellationTokenSource.Cancel();
            System.Console.WriteLine("Duża kawa");
            CoffeeMachine.State = new WorkingState(CoffeeMachine, 7000);
        }

        public override void Small()
        {
            _cancellationTokenSource.Cancel();
            System.Console.WriteLine("Mała kawa");
            CoffeeMachine.State = new WorkingState(CoffeeMachine, 4000);
        }
    }
}