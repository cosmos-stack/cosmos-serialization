using System.Text;

namespace Cosmos.Serialization.SwifterJson;

public static partial class SwifterJsonHelper
{
    /// <summary>
    /// SwifterJson manager
    /// </summary>
    private static class Man
    {
        private static Encoding _encoding = Encoding.UTF8;

        private static JsonFormatterOptions _options1 = JsonFormatterOptions.Default;

        private static JsonFormatterOptions _options2 = JsonFormatterOptions.VerifiedDeserialize;

        /// <summary>
        /// Gets or sets default encoding
        /// </summary>
        public static Encoding DefaultEncoding
        {
            get => _encoding;
            set => _encoding = value ?? _encoding;
        }

        /// <summary>
        /// Gets or sets default json formatter options
        /// </summary>
        public static JsonFormatterOptions DefaultOptions
        {
            get => _options1;
            set => _options1 = value;
        }

        /// <summary>
        /// gets for sets default json deserialize formatter options
        /// </summary>
        public static JsonFormatterOptions DefaultDeserializeOptions
        {
            get => _options2;
            set => _options2 = value;
        }
    }

    public static Encoding GetDefaultEncoding()
    {
        return Man.DefaultEncoding;
    }

    public static void SetDefaultEncoding(Encoding encoding)
    {
        Man.DefaultEncoding = encoding;
    }

    public static JsonFormatterOptions GetDefaultJsonSerializeOption()
    {
        return Man.DefaultOptions;
    }

    public static void SetDefaultJsonSerializeOption(JsonFormatterOptions options)
    {
        Man.DefaultOptions = options;
    }

    public static JsonFormatterOptions GetDefaultJsonDeserializeOption()
    {
        return Man.DefaultDeserializeOptions;
    }

    public static void SetDefaultJsonDeserializeOption(JsonFormatterOptions options)
    {
        Man.DefaultDeserializeOptions = options;
    }

    private static JsonFormatterOptions ToSerializeOptions(this JsonFormatterOptions? options)
    {
        return options ?? Man.DefaultOptions;
    }

    private static JsonFormatterOptions ToDeserializeOptions(this JsonFormatterOptions? options)
    {
        return options ?? Man.DefaultDeserializeOptions;
    }

    private static Encoding GetEncoding(this Encoding encoding)
    {
        return encoding ?? Man.DefaultEncoding;
    }
}