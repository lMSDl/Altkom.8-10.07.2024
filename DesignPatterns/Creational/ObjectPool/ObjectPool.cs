using System.Collections.Concurrent;

namespace Altkom._8_10._07._2024.DesignPatterns.Creational.ObjectPool
{
    internal class ObjectPool<T>
    {
        private ConcurrentQueue<T> _queue;

        public ObjectPool(int count, Func<T> create)
        {
            _queue = new ConcurrentQueue<T>(Enumerable.Range(1, count).Select(x => create()).ToList());
        }

        public T? Acquire()
        {
            if (_queue.TryDequeue(out var item))
                return item;
            return default;
        }

        public void Release(T item)
        {
            _queue.Enqueue(item);
        }
    }
}
