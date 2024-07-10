namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal abstract class BaseHandler<T> : IHandler<T>
    {
        private readonly IHandler<T> _handler;

        protected BaseHandler(IHandler<T> handler)
        {
            _handler = handler;
        }

        public virtual void Handle(T context)
        {
            _handler?.Handle(context);
        }
    }
}
