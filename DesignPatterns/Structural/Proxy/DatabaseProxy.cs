using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Proxy
{
    internal class DatabaseProxy : IDatabase
    {
        private IDatabase? _database;
        private Func<IDatabase> _generateFunc;

        public DatabaseProxy(Func<IDatabase> generateFunc)
        {
            _generateFunc = generateFunc;
        }

        public void Dispose()
        {
            _database?.Dispose();
            _database = null;
        }

        public const int MAX = Database.MAX_CONNECTIONS - 1;
        private readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(MAX);
        public async Task RequestAsync(int @int)
        {
            await _semaphoreSlim.WaitAsync();

            if(_database == null)
                _database = _generateFunc();

            await _database.RequestAsync(@int);

            _semaphoreSlim.Release();

            if (_semaphoreSlim.CurrentCount == MAX)
            {
                _database.Dispose();
            }
        }
    }
}
