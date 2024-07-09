namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Bridge.II
{
    internal class SmsGate : IMessageSenderImplementation
    {
        public const int MaxLength = 10;
        public IEnumerable<string> AdaptMessage(string message)
        {
            var splittedMessage = Enumerable.Range(0, message.Length / MaxLength).Select(i => message.Substring(i * MaxLength, MaxLength));
            return splittedMessage;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Wiadomość została wysłana przez bramkę SMS: {message}");
        }
    }
}
