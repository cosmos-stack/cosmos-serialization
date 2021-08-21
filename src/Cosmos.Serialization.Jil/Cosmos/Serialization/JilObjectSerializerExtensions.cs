using System;
using Jil;

namespace Cosmos.Serialization
{
    /// <summary>
    /// JilObjectSerializer extensions.
    /// </summary>
    public static class JilObjectSerializerExtensions
    {
        /// <summary>
        /// Use JilObjectSerializer
        /// </summary>
        /// <param name="entry"></param>
        public static void UseJil(this IJsonSerializerConfigureEntry entry)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new JilObjectSerializer());
        }

        /// <summary>
        /// Use JilObjectSerializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="options"></param>
        public static void UseJil(this IJsonSerializerConfigureEntry entry, Options options)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new JilObjectSerializer(options));
        }

        /// <summary>
        /// Use JilObjectSerializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="optionsFactory"></param>
        public static void UseJil(this IJsonSerializerConfigureEntry entry, Func<Options> optionsFactory)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new JilObjectSerializer(optionsFactory));
        }

        /// <summary>
        /// Use JilObjectSerializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="serializerFactory"></param>
        public static void UseJil(this IJsonSerializerConfigureEntry entry, Func<JilObjectSerializer> serializerFactory)
        {
            entry.CheckNull(nameof(entry));
            serializerFactory.CheckNull(nameof(serializerFactory));
            entry.ConfigureJsonSerializer(serializerFactory);
        }
    }
}