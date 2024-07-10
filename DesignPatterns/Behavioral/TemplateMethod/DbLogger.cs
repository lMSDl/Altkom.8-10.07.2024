using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class DbLogger
    {
        public void Log(string message)
        {
            var messageToLog = SerializeMessage(message);
            var service = ConnectToDatabase();
            InsertLogMessageToTable(service, messageToLog);
            CloseDbConnection(service);
        }
        private DbLog SerializeMessage(string message)
        {
            Console.WriteLine("Serializing message");
            return new DbLog { DateTime = DateTime.Now, Message = message };
        }
        private DatabaseService ConnectToDatabase()
        {
            Console.WriteLine("Connecting to Database.");
            return new DatabaseService();
        }
        private void InsertLogMessageToTable(DatabaseService service, DbLog message)
        {
            service.Insert(message);
        }
        private void CloseDbConnection(DatabaseService service)
        {
            service.Dispose();
        }
    }
}
