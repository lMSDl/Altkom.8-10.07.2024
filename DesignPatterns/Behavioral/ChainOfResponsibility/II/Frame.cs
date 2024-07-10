namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Frame : Container
    {
        protected override void Click(bool handled)
        {
            Console.WriteLine($"Ramka {Name} zamigotała");
            base.Click(handled);
        }
    }
}
