namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class DatabaseService
    {
        public void Dispose()
        {
            Console.WriteLine("Closing DB connection.");
        }

        public void Insert(DbLog log)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + log.Message);
        }
    }
}