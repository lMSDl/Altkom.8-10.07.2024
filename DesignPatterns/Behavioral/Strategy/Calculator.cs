using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Strategy
{
    internal class Calculator
    {
        public ICalcStrategy? Strategy { get; set; }
        public float? Operate(float a, float b)
        {
            return Strategy?.Calc(a, b);
        }
    }
}
