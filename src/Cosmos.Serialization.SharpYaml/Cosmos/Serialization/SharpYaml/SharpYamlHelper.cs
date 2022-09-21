using System.Text;

namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlHelper
{
    /// <summary>
    /// SharpYaml manager
    /// </summary>
    private static class Man
    {
        private static Encoding _encoding = Encoding.UTF8;
        private static SerializerSettings _settings = new();
        private static Serializer _serializer = new(_settings);

        /// <summary>
        /// Gets or sets default Newtonsoft Json serializer settings
        /// </summary>
        public static SerializerSettings DefaultSettings
        {
            get => _settings;
            set => _settings = value ?? _settings;
        }

        /// <summary>
        /// Gets default SharpYaml serializer
        /// </summary>
        public static Serializer DefaultSerializer
        {
            get => _serializer;
            set => _serializer = value ?? _serializer;
        }

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

    public static Serializer GetDefaultSerializer()
    {
        return Man.DefaultSerializer;
    }

    public static void SetDefaultSerializer(Serializer serializer)
    {
        Man.DefaultSerializer = serializer;
    }

    public static SerializerSettings GetDefaultSettings()
    {
        return Man.DefaultSettings;
    }

    public static void SetDefaultSettings(SerializerSettings settings)
    {
        Man.DefaultSettings = settings;
    }

    private static Encoding ToEncoding(this Encoding encoding)
    {
        return encoding ??= Man.DefaultEncoding;
    }

    private static Task<T> Async<T>(Func<T> func, CancellationToken cancellationToken = default)
    {
        return Task.Run(func.Invoke, cancellationToken);
    }
}