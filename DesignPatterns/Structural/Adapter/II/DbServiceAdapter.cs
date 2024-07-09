

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Adapter.II
{
    internal class DbServiceAdapter : IPeopleService
    {
        private readonly DbService _dbService;

        public DbServiceAdapter(DbService dbService)
        {
            _dbService = dbService;
        }

        public IEnumerable<Person> GetPeople()
        {

            return _dbService.Read().Select(x => new Person { Name = $"{x.LastName} {x.FirstName}", Age = DateTime.Now.Year - x.BirthDate.Year });
            
        }
    }
}
