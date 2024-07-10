using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Command
{
    internal class Client
    {
        public static void Execute()
        {
            var garden = new Garden(5);
            var command1 = new PlantCommand(garden, "drzewo");
            var command2 = new PlantCommand(garden, "kwiaty");
            var command3 = new RemoveCommand(garden, "drzewo");
            var command4 = new RemoveCommand(garden, "kwiaty");


            var plantTreeButton = new Invoker(command1);
            var plantFlowersButton = new Invoker(command2);
            var removeTreeButton = new Invoker(command3);
            var removeFlowersButton = new Invoker(command4);

            Console.WriteLine(garden);

            plantTreeButton.Click();
            plantTreeButton.Click();
            plantTreeButton.Click();

            Console.WriteLine(garden);

            plantFlowersButton.Click();
            plantFlowersButton.Click();
            plantFlowersButton.Click();

            Console.WriteLine(garden);

            removeTreeButton.Click();
            removeFlowersButton.Click();
            removeFlowersButton.Click();
            removeFlowersButton.Click();

            Console.WriteLine(garden);


            Invoker.Undo();
            Invoker.Undo();
            Invoker.Undo();
            Invoker.Undo();

            Console.WriteLine(garden);
        }
    }
}
