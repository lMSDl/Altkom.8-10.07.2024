using System.Text;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Flyweight
{
    internal class FlyweightFactory<T>
    {
        static FlyweightFactory() { }
        public static FlyweightFactory<T> Instance { get; } = new FlyweightFactory<T>();

        private FlyweightFactory() { }

        private IDictionary<string, T> _flyweights = new Dictionary<string, T>();

        public void Initialize(params T[] flyweights)
        {
            foreach (var flyweight in flyweights)
            {
                _flyweights[GetKey(flyweight)] = flyweight;
            }
        }

        private string GetKey(T flyweight)
        {
            return string.Join("_", typeof(T).GetProperties().Where(x => x.CanWrite && x.CanRead).OrderBy(x => x.Name).Select(x => x.GetValue(flyweight)));

            //return flyweight.GetHashCode().ToString();
        }

        public T GetFlyweight(T flyweight)
        {
            var key = GetKey(flyweight);

            if (_flyweights.TryGetValue(key, out var cache))
            {
                Console.WriteLine("Pobieramy stan ze słownika");
                return cache;
            }


            Console.WriteLine("Dodajemy stan do słownika");
            _flyweights[key] = flyweight;
            return flyweight;
        }

        public override string ToString()
        {

            var stringBuilder = new StringBuilder($"Fabryka posiada {_flyweights.Count} stanów:\n");

            foreach (var item in _flyweights)
            {
                stringBuilder.AppendLine(item.Key);
            }

            return stringBuilder.ToString();
        }
    }
}
