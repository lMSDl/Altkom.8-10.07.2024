﻿namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Mediator
{
    internal class ChatBot : ChatMemeber
    {
        public override void Receive(string from, string message, bool isPrivate)
        {
            if (isPrivate)
                Mediator.Send(Nick, from, message);
            else
                Mediator.Send(Nick, message);
        }
    }
}
