using System.Text;

namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooHelper
{
    /// <summary>
    /// KoobooJson helper
    /// </summary>
    private static class Man
    {
        private static Encoding _encoding = Encoding.UTF8;

        private static JsonSerializerOption _option1 = new();

        private static JsonDeserializeOption _option2 = new();

        /// <summary>
        /// Gets or sets default encoding
        /// </summary>
        public static Encoding DefaultEncoding
        {
            get => _encoding;
            set => _encoding = value ?? _encoding;
        }

        /// <summary>
        /// Gets or sets default json serializer options
        /// </summary>
        public static JsonSerializerOption DefaultSerializerOptions
        {
            get => _option1;
            set => _option1 = value ?? _option1;
        }

        /// <summary>
        /// Gets or sets default json deserializer options
        /// </summary>
        public static JsonDeserializeOption DefaultDeserializeOptions
        {
            get => _option2;
            set => _option2 = value ?? _option2;
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

    public static JsonSerializerOption GetDefaultJsonSerializerOption()
    {
        return Man.DefaultSerializerOptions;
    }

    public static void SetDefaultJsonSerializerOption(JsonSerializerOption options)
    {
        Man.DefaultSerializerOptions = options;
    }

    public static JsonDeserializeOption GetDefaultJsonDeserializeOption()
    {
        return Man.DefaultDeserializeOptions;
    }

    public static void SetDefaultJsonDeserializeOption(JsonDeserializeOption options)
    {
        Man.DefaultDeserializeOptions = options;
    }

    private static JsonSerializerOption ToOptions(this JsonSerializerOption options)
    {
        return options ?? Man.DefaultSerializerOptions;
    }

    private static JsonSerializerOption GetOptions(this Action<JsonSerializerOption> optionAct)
    {
        var options = new JsonSerializerOption();
        optionAct?.Invoke(options);
        return options;
    }

    private static JsonDeserializeOption ToOptions(this JsonDeserializeOption options)
    {
        return options ?? Man.DefaultDeserializeOptions;
    }

    private static JsonDeserializeOption GetOptions(this Action<JsonDeserializeOption> optionAct)
    {
        var options = new JsonDeserializeOption();
        optionAct?.Invoke(options);
        return options;
    }

    private static Encoding GetEncoding(this Encoding encoding)
    {
        return encoding ?? Man.DefaultEncoding;
    }
}