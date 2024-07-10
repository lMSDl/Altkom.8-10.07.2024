
namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal abstract class BaseDiscountHandler : IDiscountHandler
    {
        private readonly BaseDiscountHandler? _next;

        public BaseDiscountHandler(BaseDiscountHandler next)
        {
            _next = next;
        }

        public virtual bool Handle(float value, float price)
        {
            return _next?.Handle(value, price) ?? false;
        }
    }
}
