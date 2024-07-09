namespace Altkom._8_10._07._2024.DesignPatterns.Creational.Singleton
{
    internal class Context
    {
        private readonly Dictionary<string, string> _settings = new Dictionary<string, string>();

        private Context()
        {
            Console.WriteLine("Inicjalizacja ustawień");

            _settings.Add("1", "A");
            _settings.Add("2", "B");
            _settings.Add("3", "C");
        }

        private async Task Initialize()
        {
            await Task.Delay(1000);

            _settings.Add("1", "A");
            _settings.Add("2", "B");
            _settings.Add("3", "C");
        }

        public string GetSettings(string key)
        {
            return _settings[key];
        }
        public void SetSettings(string key, string value)
        {
            _settings[key] = value;
        }

        private static Context? _instance;

        /*public static Context GetInstance()
        {
            if(_instance == null)
                _instance = new Context();
            return _instance;
        }*/

        private static readonly object _locker = new object();
        /*public static Context GetInstance()
        {
            lock (_locker)
            {
                if (_instance == null)
                {
                    _instance = new Context();
                    //await _instance.Initialize();
                }

                return _instance;
            }
        }*/

        /*public static Context GetInstance()
        {
            if (_instance == null)
            {
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Context();
                    }
                }
            }
            return _instance;
        }*/


        static Context() { }
        public static Context Instance { get; } = new Context();

        /*private static Lazy<Context> _lazyInstance = new Lazy<Context>(() => new Context());
        public static Context GetInstance()
        {
            return _lazyInstance.Value;
        }*/

    }
}
