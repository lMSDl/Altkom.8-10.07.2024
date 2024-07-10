using Altkom._8_10._07._2024.DesignPatterns.Structural.Bridge.I;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class DiscountHandler_2 : BaseHandler<DiscountHandlerContext>
    {
        private string Name { get; }
        protected float MaxDiscount { get; }
        protected float MinPrice { get; }

        public DiscountHandler_2(string name, float maxDiscount, float minPrice, IHandler<DiscountHandlerContext>? handler) : base(handler)
        {
            Name = name;
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }

        public DiscountHandler_2(string name, float maxDiscount, float minPrice) : this(name, maxDiscount, minPrice, null)
        {
        }

        public override void Handle(DiscountHandlerContext context)
        {
            if (context.Price >= MinPrice && context.Value <= MaxDiscount)
            {
                Console.WriteLine($"{Name} udzielił rabatu {context.Value}");
                context.Result = true;
            }
            else
            {
                Console.WriteLine($"{Name} przekazał dalej");
                base.Handle(context);
            }
        }
    }
}
