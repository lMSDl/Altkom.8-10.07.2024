﻿namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.State
{
    internal class Client
    {
        public static void Execute()
        {
            var coffeeMachine = new CoffeeMachine();

            _ = Task.Delay(3000).ContinueWith(x => coffeeMachine.LargeCoffee());

            _ = Task.Delay(7000).ContinueWith(x => coffeeMachine.LargeCoffee());

            _ = Task.Delay(9000).ContinueWith(x => coffeeMachine.LargeCoffee());

            _ = Task.Delay(10000).ContinueWith(x => coffeeMachine.SmallCoffee());

            Console.ReadLine();
        }
    }
}
