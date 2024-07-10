
namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Button : Control
    {
        public Func<bool>? OnClick { get; set; }

        protected override void Click(bool handled)
        {
            if (!handled && (OnClick?.Invoke() ?? false))
            {
                base.Click(true);
            }
            else
            {
                base.Click(handled);
            }
        }

    }
}
