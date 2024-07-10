﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class FileLogger : Logger<string, FileService>
    {
        protected override void Save(string item, FileService service)
        {
            service.Write(item);
        }

        protected override string CreateItem(string message)
        {
            Console.WriteLine("Serializing message");
            return message;
        }

        protected override FileService GetService()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }
    }
}
