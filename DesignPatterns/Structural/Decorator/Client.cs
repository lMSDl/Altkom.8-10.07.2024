using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Decorator
{
    internal class Client
    {
        public static void Execute()
        {
            while (true)
            {
                var text = Console.ReadLine();
                INotification notification = new SystemNotification();


                notification.Send(text);
            }
        }
    }
}
