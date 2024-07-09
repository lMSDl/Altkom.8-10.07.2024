using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Composite
{
    internal abstract class Composite : IComponent
    {
        public string Name => GetType().Name;

        public IList<IComponent> Components { get; set; } = new List<IComponent>();


        public float GetValue()
        {
            var value = Components.Select(x => x.GetValue()).Sum();

            Console.WriteLine($"Wartość {Name} to {value}");
            return value;
        }
    }
}
