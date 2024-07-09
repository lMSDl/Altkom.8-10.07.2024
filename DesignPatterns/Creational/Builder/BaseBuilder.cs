namespace Altkom._8_10._07._2024.DesignPatterns.Creational.Builder
{
    internal abstract class BaseBuilder<T> where T : ICloneable
    {
        protected T Item { get; }

        protected BaseBuilder(T item)
        {
            Item = item;
        }

        public T Build()
        {
            return (T)Item.Clone();
        }
    }
}
