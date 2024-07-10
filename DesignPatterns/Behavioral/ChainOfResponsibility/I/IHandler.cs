namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal interface IHandler<T>
    {
        public void Handle(T context);
    }
}
