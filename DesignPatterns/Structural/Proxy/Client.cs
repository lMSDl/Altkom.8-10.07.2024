using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Proxy
{
    internal class Client
    {
        public static void Execute()
        {
            IDatabase database = new Database();


            for (int i = 1; i < 11; i++)
            {
                database.RequestAsync(i);
            }

            Console.ReadLine();


            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(250);
                database.RequestAsync(i);
            }

            Console.ReadLine();
        }
    }
}
