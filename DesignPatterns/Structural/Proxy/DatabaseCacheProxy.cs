using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Proxy
{
    internal class DatabaseCacheProxy : IDatabase
    {
        IDatabase? _database;
        public DatabaseCacheProxy(IDatabase database)
        {
            _database = database;
        }

        private Queue<int> ints = new Queue<int>();

        public async Task RequestAsync(int @int)
        {
            if(ints.Contains(@int))
            {
                return;
            }

            if(ints.Count >= 3)
            {
                ints.Dequeue();
            }

            await _database.RequestAsync(@int);

            ints.Enqueue(@int);
        }

        public void Dispose()
        {
            _database?.Dispose();
            _database = null;
        }
    }
}
