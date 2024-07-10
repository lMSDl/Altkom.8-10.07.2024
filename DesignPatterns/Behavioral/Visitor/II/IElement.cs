using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Visitor.II
{
    internal interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
