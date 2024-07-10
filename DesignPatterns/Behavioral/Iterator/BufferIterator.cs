using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Iterator
{
    internal class BufferIterator<T> : IEnumerator<(T, T)>
    {
        private IEnumerator<T> _enumerator;

        public BufferIterator(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
            Reset();
        }

        public (T, T) Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _enumerator?.Dispose();
            _enumerator = null;
            Current = default;
        }

        public bool MoveNext()
        {
            if(_enumerator.MoveNext())
            {
                Current = (Current.Item2, _enumerator.Current);
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _enumerator.Reset();
            Current = _enumerator.MoveNext() ? ((T, T))(default, _enumerator.Current) : default;
        }
    }
}
