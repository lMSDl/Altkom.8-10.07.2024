namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Mediator
{
    internal class ChatUser : ChatMemeber
    {
        public override void Receive(string from, string message, bool isPrivate)
        {
            Console.WriteLine($"{from}{(isPrivate ? $" to {Nick}" : "")}: {message}");
        }
    }
}
