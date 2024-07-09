using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Facade.I
{
    internal class SerializeFacade
    {
        static JsonSerializerOptions Settings { get; } = new JsonSerializerOptions()
        {
            IgnoreReadOnlyProperties = true,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault,
            ReferenceHandler = ReferenceHandler.Preserve
        };

        public static string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize(obj, Settings);
        }
    }
}
