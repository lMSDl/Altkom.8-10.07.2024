using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class EmailLogger
    {
        public void Log(string message)
        {
            var messageToLog = SerializeMessage(message);
            SendLogToEmail(messageToLog);
        }
        private string SerializeMessage(string message)
        {
            Console.WriteLine("Serializing message");
            return message;
        }
        private void SendLogToEmail(string message)
        {
            Console.WriteLine("Sending Email with Log Message : " + message);
        }
    }
}
