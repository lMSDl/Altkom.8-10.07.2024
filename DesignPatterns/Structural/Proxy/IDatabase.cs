namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Proxy
{
    internal interface IDatabase : IDisposable
    {
        Task RequestAsync(int @int);
    }
}