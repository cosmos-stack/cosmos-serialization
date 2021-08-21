using System;
using Swifter.Json;

namespace Cosmos.Serialization
{
    /// <summary>
    /// SwifterJsonSerializer extensions.
    /// </summary>
    public static class SwifterJsonSerializerExtensions
    {
        /// <summary>
        /// Use SwifterJsonSerializer
        /// </summary>
        /// <param name="entry"></param>
        public static void UseSwifter(this IJsonSerializerConfigureEntry entry)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new SwifterJsonSerializer());
        }

        /// <summary>
        /// Use SwifterJsonSerializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="options1"></param>
        /// <param name="options2"></param>
        public static void UseSwifter(this IJsonSerializerConfigureEntry entry, JsonFormatterOptions options1, JsonFormatterOptions options2)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new SwifterJsonSerializer(options1, options2));
        }

        /// <summary>
        /// Use SwifterJsonSerializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="optionsFactory1"></param>
        /// <param name="optionsFactory2"></param>
        public static void UseSwifter(this IJsonSerializerConfigureEntry entry, Func<JsonFormatterOptions> optionsFactory1, Func<JsonFormatterOptions> optionsFactory2)
        {
            entry.CheckNull(nameof(entry));
            entry.ConfigureJsonSerializer(new SwifterJsonSerializer(optionsFactory1, optionsFactory2));
        }

        /// <summary>
        /// Use SwifterJsonSerializer
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="serializerFactory"></param>
        public static void UseSwifter(this IJsonSerializerConfigureEntry entry, Func<SwifterJsonSerializer> serializerFactory)
        {
            entry.CheckNull(nameof(entry));
            serializerFactory.CheckNull(nameof(serializerFactory));
            entry.ConfigureJsonSerializer(serializerFactory);
        }
    }
}