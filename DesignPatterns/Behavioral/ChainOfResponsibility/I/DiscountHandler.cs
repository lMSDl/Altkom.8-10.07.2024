using Altkom._8_10._07._2024.DesignPatterns.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class DiscountHandler : BaseDiscountHandler
    {
        private string Name { get; }
        protected float MaxDiscount { get; }
        protected float MinPrice { get; }

        public DiscountHandler(string name, float maxDiscount, float minPrice, BaseDiscountHandler? next) : base(next)
        {
            Name = name;
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }
        public DiscountHandler(string name, float maxDiscount, float minPrice) : this(name, maxDiscount, minPrice, null)
        {
        }
        public override bool Handle(float value, float price)
        {
            if (price >= MinPrice && value <= MaxDiscount)
            {
                Console.WriteLine($"{Name} udzielił rabatu {value}");
                return true;
            }
            Console.WriteLine($"{Name} przekazał dalej");
            return base.Handle(value, price);
        }
    }
}
