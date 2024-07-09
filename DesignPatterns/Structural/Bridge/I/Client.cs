using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Bridge.I
{
    internal class Client
    {
        public static void Execute()
        {
            Shape shape = new Square();
            shape.Color = new Red();
            Console.WriteLine(shape);


            Shape circle = new Circle();
            circle.Color = new Blue() {  Brightness = new Dark()};
            Console.WriteLine(circle);
        }
    }
}
