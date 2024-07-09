using System.Text.Json;
using System.Text.Json.Serialization;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Facade.I
{
    internal class Client
    {
        public static void Execute()
        {
            var person = new Person() { LastName = "Personowski", Id = 12 };

            /*var settings = new JsonSerializerOptions()
            {
                IgnoreReadOnlyProperties = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault,
                ReferenceHandler = ReferenceHandler.Preserve
            };*/

            //var json = JsonSerializer.Serialize(person, settings);

            var json = SerializeFacade.Serialize(person);
            Console.WriteLine(json);
        }

    }
}
