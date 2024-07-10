namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Memento
{
    internal interface IRestorable<T>
    {
        void Restore(T state);
    }
}
