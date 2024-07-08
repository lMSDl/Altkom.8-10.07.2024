using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.SOLID.D
{
    interface IMessage
    {
        void Send();
    }
    
    internal class SMS : IMessage
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            SendSMS();
        }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    internal class MMS : IMessage
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void Send()
        {
            SendMMS();
        }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
    }

    internal class Mail : IMessage
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public byte[] Attachement { get; set; }

        public void Send()
        {
            SendMail();
        }

        public void SendMail()
        {
            Console.WriteLine("Sending Mail...");
        }
    }

    internal class Messenger
    {
        public IEnumerable<IMessage> Messages { get; set; }

        public Messenger(IEnumerable<IMessage> messages)
        {
            Messages = messages;
        }

        public void SendMessages(IEnumerable<IMessage> messages)
        {
            Messages = messages;
            SendMessages(); 
        }

        public void SendMessages()
        {
            foreach (var item in Messages)
            {
                item.Send();
            }
        }
    }

    /*internal class SMS
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    internal class MMS
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
    }

    internal class Mail
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public byte[] Attachement { get; set; }

        public void SendMail()
        {
            Console.WriteLine("Sending Mail...");
        }
    }

    internal class Messenger
    {
        public SMS SMS { get; set; }
        public MMS MMS { get; set; }
        public Mail Mail { get; set; }


        public void SendMessage()
        {
            SMS.SendSMS();
            MMS.SendMMS();
            Mail.SendMail();
        }
    }*/
}
