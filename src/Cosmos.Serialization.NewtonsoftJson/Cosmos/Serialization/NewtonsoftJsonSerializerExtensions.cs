using System;
using Newtonsoft.Json;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Newtonsoft Json Serializer (Json.NET) extensions.
    /// </summary>
    public static class NewtonsoftJsonSerializerExtensions
    {
        /// <summary>
        /// Use Newtonsoft Json Serializer
        /// </summary>
        /// <param name="entry"></param>
        public static void UseNewtonsoftJson(this IJsonSerializerConfigureEntry entry)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new NewtonsoftJsonSerializer());
        }

        /// <summary>
        /// Use Newtonsoft Json Serializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="options"></param>
        public static void UseNewtonsoftJson(this IJsonSerializerConfigureEntry entry, JsonSerializerSettings options)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new NewtonsoftJsonSerializer(options));
        }

        /// <summary>
        /// Use Newtonsoft Json Serializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="optionsFactory"></param>
        public static void UseNewtonsoftJson(this IJsonSerializerConfigureEntry entry, Func<JsonSerializerSettings> optionsFactory)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new NewtonsoftJsonSerializer(optionsFactory));
        }

        /// <summary>
        /// Use Newtonsoft Json Serializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="serializerFactory"></param>
        public static void UseNewtonsoftJson(this IJsonSerializerConfigureEntry entry, Func<NewtonsoftJsonSerializer> serializerFactory)
        {
            entry.CheckNull(nameof(entry));
            serializerFactory.CheckNull(nameof(serializerFactory));
            entry.ConfigureJsonSerializer(serializerFactory);
        }
    }
}