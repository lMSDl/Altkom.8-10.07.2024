using System.Reactive.Linq;

namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Iterator
{
    internal class Client
    {
        public static void Execute()
        {
            List<string> list = new List<string>() { "1", "2", "3", "4", "5", "6" };

            var item = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine(item + list[i]);
                item = list[i];
            }

            Console.WriteLine("---");

            var iterator = list.GetEnumerator();
            if (iterator.MoveNext())
            {
                item = iterator.Current;
                while (iterator.MoveNext())
                {
                    Console.WriteLine(item + iterator.Current);
                    item = iterator.Current;
                }
            }

            Console.WriteLine("---");

            var buffer = new Buffer<string>(list);
            var bufferIterator = buffer.GetEnumerator();
            while(bufferIterator.MoveNext())
            {
                Console.WriteLine(bufferIterator.Current.Item1 + bufferIterator.Current.Item2);
            }

            foreach (var bufferItem in buffer)
            {
                Console.WriteLine(bufferItem.Item1 + bufferItem.Item2);
            }

            Console.WriteLine("---");

            foreach(var value in list.ToObservable()
                .Buffer(2, 1)
                .Where(x => x.Count == 2)
                .ToEnumerable())
            {
                Console.WriteLine(value[0] + value[1]);
            }
        }

    }
}
