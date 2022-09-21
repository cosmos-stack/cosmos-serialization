using System.Text;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetHelper
{
    /// <summary>
    /// YamlDotNet manager
    /// </summary>
    private static class Man
    {
        private static Encoding _encoding = Encoding.UTF8;
        private static SerializerBuilder _serializerBuilder;
        private static DeserializerBuilder _deserializerBuilder;

        static Man()
        {
            _serializerBuilder = new SerializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance);
            _deserializerBuilder = new DeserializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance);
        }

        /// <summary>
        /// Gets or sets YamlDotNet serializer builder
        /// </summary>
        public static SerializerBuilder DefaultSerializerBuilder
        {
            get => _serializerBuilder;
            set => _serializerBuilder = value ?? _serializerBuilder;
        }

        /// <summary>
        /// Gets or sets YamlDotNet deserializer builder
        /// </summary>
        public static DeserializerBuilder DefaultDeserializerBuilder
        {
            get => _deserializerBuilder;
            set => _deserializerBuilder = value ?? _deserializerBuilder;
        }

        /// <summary>
        /// Gets default YamlDotNet serializer
        /// </summary>
        public static S DefaultSerializer => _serializerBuilder.Build();

        /// <summary>
        /// Gets default YamlDotNet deserializer
        /// </summary>
        public static D DefaultDeserializer => _deserializerBuilder.Build();

        /// <summary>
        /// Gets or sets default encoding
        /// </summary>
        public static Encoding DefaultEncoding
        {
            get => _encoding;
            set => _encoding = value ?? _encoding;
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

    public static SerializerBuilder GetDefaultSerializerBuilder()
    {
        return Man.DefaultSerializerBuilder;
    }

    public static void SetDefaultSerializerBuilder(SerializerBuilder serializer)
    {
        Man.DefaultSerializerBuilder = serializer;
    }

    public static DeserializerBuilder GetDefaultDeserializerBuilder()
    {
        return Man.DefaultDeserializerBuilder;
    }

    public static void SetDefaultDeserializerBuilder(DeserializerBuilder settings)
    {
        Man.DefaultDeserializerBuilder = settings;
    }

    public static S GetDefaultSerializer() => Man.DefaultSerializer;

    public static D GetDefaultDeserializer() => Man.DefaultDeserializer;

    private static Encoding ToEncoding(this Encoding encoding)
    {
        return encoding ??= Man.DefaultEncoding;
    }

    private static Task<T> Async<T>(Func<T> func, CancellationToken cancellationToken = default)
    {
        return Task.Run(func.Invoke, cancellationToken);
    }
}