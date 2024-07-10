﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Observer
{
    internal class Client
    {
        public static void Execute()
        {
            SubscriberA sub1 = new();
            SubscriberB sub2 = new();

            using Publisher publisher = new();
            sub1.Subscription = publisher.Subscribe(sub1);
            sub2.Subscription = publisher.Subscribe(sub2);


            _ = Task.Delay(7000).ContinueWith(x => sub2.OnCompleted());
            _ = Task.Delay(12000).ContinueWith(x => sub2.Subscription = publisher.Subscribe(sub2));

            publisher.Work().Wait();
        }
    }
}
