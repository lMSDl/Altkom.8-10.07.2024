using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Visitor.I
{
    internal interface IVisitor
    {
        string Visit(PlainText element);
        string Visit(Hyperlink element);
        string Visit(BoldText element);
    }
}
