using System;
using System.Text.Json;

namespace Cosmos.Serialization
{
    /// <summary>
    /// System.Text.Json (MicrosoftJson) extensions.
    /// </summary>
    public static class MicrosoftJsonObjectSerializerExtensions
    {
        /// <summary>
        /// Use Microsoft System.Text.Json object serializer
        /// </summary>
        /// <param name="entry"></param>
        public static void UseMicrosoftJson(this IJsonSerializerConfigureEntry entry)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new MicrosoftJsonObjectSerializer());
        }

        /// <summary>
        /// Use Microsoft System.Text.Json object serializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="options"></param>
        public static void UseMicrosoftJson(this IJsonSerializerConfigureEntry entry, JsonSerializerOptions options)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new MicrosoftJsonObjectSerializer(options));
        }

        /// <summary>
        /// Use Microsoft System.Text.Json object serializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="optionsFactory"></param>
        public static void UseMicrosoftJson(this IJsonSerializerConfigureEntry entry, Func<JsonSerializerOptions> optionsFactory)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new MicrosoftJsonObjectSerializer(optionsFactory));
        }

        /// <summary>
        /// Use Microsoft System.Text.Json object serializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="serializerFactory"></param>
        public static void UseMicrosoftJson(this IJsonSerializerConfigureEntry entry, Func<MicrosoftJsonObjectSerializer> serializerFactory)
        {
            entry.CheckNull(nameof(entry));
            serializerFactory.CheckNull(nameof(serializerFactory));
            entry.ConfigureJsonSerializer(serializerFactory);
        }
    }
}