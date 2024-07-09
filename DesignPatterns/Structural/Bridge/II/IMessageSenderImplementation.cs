namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Bridge.II
{
    internal interface IMessageSenderImplementation
    {
        IEnumerable<string> AdaptMessage(string message);
        void SendMessage(string message);
    }
}