﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Composite
{
    internal class Client
    {
        public static void Execute()
        {
            var warehouse = new Warehouse();

            var shelf1 = new Shelf();
            var shelf2 = new Shelf();

            warehouse.Components.Add(shelf1);
            warehouse.Components.Add(shelf2);

            var box1 = new Box();
            var box2 = new Box();
            var box3 = new Box();
            var box4 = new Box();

            shelf1.Components.Add(box1);
            shelf2.Components.Add(box2);
            shelf2.Components.Add(box3);

            warehouse.Components.Add(box4);

            for (int i = 0; i < 10; i++)
            {
                box1.Components.Add(new Tea(10));
                box2.Components.Add(new Toy(43.2f));
                box3.Components.Add(new Soda(4));
            }

            for (int i = 0; i < 5; i++)
            {
                box4.Components.Add(new Tea(15));
                box4.Components.Add(new Soda(3));
            }

            warehouse.Components.Add(new Toy(21.3f));

            box2.GetValue();

            Console.WriteLine("---");

            shelf1.GetValue();

            Console.WriteLine("---");

            warehouse.GetValue();

            Console.WriteLine("---");

            warehouse.Components[2].GetValue();
        }
    }
}