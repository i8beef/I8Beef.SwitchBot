using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace I8Beef.SwitchBot
{
    /// <summary>
    /// JSON serialization helper.
    /// </summary>
    /// <typeparam name="TType">Type of object to serialize / deserialize to.</typeparam>
    public static class JsonSerializer<TType>
        where TType : class
    {
        private static readonly JsonSerializerSettings _settings = new()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented
        };

        /// <summary>
        /// Serializes an object to JSON
        /// </summary>
        /// <param name="instance">The object to serialize.</param>
        /// <returns>Serialized string.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "Generic static matching JSON.NET contract")]
        public static string Serialize(TType instance)
        {
            return JsonConvert.SerializeObject(instance, _settings);
        }

        /// <summary>
        /// DeSerializes an object from JSON
        /// </summary>
        /// <param name="json">The JSON string to deserialize.</param>
        /// <returns>Deserialized object.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "Generic static matching JSON.NET contract")]
        public static TType Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<TType>(json, _settings);
        }
    }
}
