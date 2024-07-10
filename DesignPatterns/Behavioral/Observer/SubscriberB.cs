﻿namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Observer
{
    internal class SubscriberB : Subscriber
    {
        public override void OnNext(int value)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine($"SubscriberB zareagował na {value}");
            }
        }
    }
}