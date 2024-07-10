namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Container : Control
    {
        protected ICollection<Control> Controls { get; } = new List<Control>();

        public void Add(Control control)
        {
            Controls.Add(control);
            control.Parent = this;
        }
    }
}
