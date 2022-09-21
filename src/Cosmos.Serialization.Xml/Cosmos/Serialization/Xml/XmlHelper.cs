using System.Collections.Concurrent;
using System.Text;
using System.Xml.Serialization;

namespace Cosmos.Serialization.Xml;

public static partial class XmlHelper
{
    /// <summary>
    /// Xml manager
    /// </summary>
    private class Man
    {
        private static Encoding _encoding = Encoding.UTF8;
        private static readonly ConcurrentDictionary<Type, XmlSerializer> _serializerCache = new();

        /// <summary>
        /// Gets or sets default encoding
        /// </summary>
        public static Encoding DefaultEncoding
        {
            get => _encoding;
            set => _encoding = value ?? _encoding;
        }

        public static XmlSerializer GetSerializer(Type type)
        {
            return _serializerCache.GetOrAdd(type, new XmlSerializer(type));
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

    private static Encoding ToEncoding(this Encoding encoding)
    {
        return encoding ??= Man.DefaultEncoding;
    }

    private static Task<T> Async<T>(Func<T> func, CancellationToken cancellationToken = default)
    {
        return Task.Run(func.Invoke, cancellationToken);
    }
}