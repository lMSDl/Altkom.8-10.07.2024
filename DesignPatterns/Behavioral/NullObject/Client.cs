using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.NullObject
{
    internal class Client
    {

        public static void Execute(int a)
        {
            var objects = new AbstractObject?[] { new RealObject(), null };
            var random = new Random();

            while(true)
            {
                var value = random.Next(0, objects.Length);
                Console.ReadLine();

                if (objects[value] is null)
                    continue;

                objects[value]?.Method1();
                objects[value]?.Method2();
                objects[value]?.Method3();
            }

        }
    }
}
