using System;
using fastJSON;

namespace Cosmos.Serialization
{
    /// <summary>
    /// FastJsonObjectSerializer extensions.
    /// </summary>
    public static class FastJsonObjectSerializerExtensions
    {
        /// <summary>
        /// Use FastJsonObjectSerializer
        /// </summary>
        /// <param name="entry"></param>
        public static void UseJil(this IJsonSerializerConfigureEntry entry)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new FastJsonObjectSerializer());
        }

        /// <summary>
        /// Use FastJsonObjectSerializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="options"></param>
        public static void UseJil(this IJsonSerializerConfigureEntry entry, JSONParameters options)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new FastJsonObjectSerializer(options));
        }

        /// <summary>
        /// Use FastJsonObjectSerializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="optionsFactory"></param>
        public static void UseJil(this IJsonSerializerConfigureEntry entry, Func<JSONParameters> optionsFactory)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new FastJsonObjectSerializer(optionsFactory));
        }

        /// <summary>
        /// Use FastJsonObjectSerializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="serializerFactory"></param>
        public static void UseJil(this IJsonSerializerConfigureEntry entry, Func<FastJsonObjectSerializer> serializerFactory)
        {
            entry.CheckNull(nameof(entry));
            serializerFactory.CheckNull(nameof(serializerFactory));
            entry.ConfigureJsonSerializer(serializerFactory);
        }
    }
}