namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Adapter.II
{
    internal class DbService
    {
        private IEnumerable<DbPerson> _people = new List<DbPerson>()
        {
            new DbPerson {FirstName = "Adam", LastName = "Adamski", BirthDate = DateTime.Now.AddYears(-24)},
            new DbPerson {FirstName = "Ewa", LastName = "Ewowska", BirthDate = DateTime.Now.AddYears(-25)},
        };

        public IEnumerable<DbPerson> Read()
        {
            return _people.ToList();
        }
    }
}
