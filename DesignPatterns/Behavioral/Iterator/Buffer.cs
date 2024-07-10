﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Iterator
{
    internal class Buffer<T> : IEnumerable<(T,T)>
    {
        IEnumerable<T> _items;

        public Buffer(IEnumerable<T> items)
        {
            _items = items;
        }

        public IEnumerator<(T, T)> GetEnumerator()
        {
            return new BufferIterator<T>(_items.GetEnumerator());
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
