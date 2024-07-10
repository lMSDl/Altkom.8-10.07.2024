
namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal abstract class Control
    {
        public string Name { get; set; }
        public Control? Parent { get; set; }

        public void Click()
        {
            Click(false);
        }
        protected virtual void Click(bool handled)
        {
            Parent?.Click(handled);
        }
    }
}
