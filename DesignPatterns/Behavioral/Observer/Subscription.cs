﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Observer
{
    internal class Subscription : IDisposable
    {

        private Action? action;

        public Subscription(Action? action)
        {
            this.action = action;
        }

        public void Dispose()
        {
            action?.Invoke();
            action = null;
        }
    }
}
