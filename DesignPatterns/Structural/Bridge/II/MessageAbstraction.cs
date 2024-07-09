using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Bridge.II
{
    internal class MessageAbstraction
    {
        protected IMessageSenderImplementation MessageSender { get; }

        public MessageAbstraction(IMessageSenderImplementation messageSender)
        {
            MessageSender = messageSender;
        }

        public void Send(string message)
        {
            var adaptedMessage = MessageSender.AdaptMessage(message);
            foreach (var item in adaptedMessage)
            {
                MessageSender.SendMessage(item);
            }
        }
    }
}
