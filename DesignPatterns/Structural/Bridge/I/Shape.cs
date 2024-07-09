using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Bridge.I
{
    internal abstract class Shape
    {
        public Color? Color { get; set; }

        public override string ToString()
        {
            return $"{(Color is null ? "" : Color)}{GetType().Name}";
        }
    }
}
