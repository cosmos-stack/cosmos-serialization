namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void XmlPackBy<TValue>(this Stream stream, TValue value)
    {
        XmlHelper.Pack(value, stream);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    public static void XmlPackBy(this Stream stream, Type type, object value)
    {
        XmlHelper.Pack(type, value, stream);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task XmlPackByAsync<TValue>(this Stream stream, TValue value, CancellationToken cancellationToken = default)
    {
        return XmlHelper.PackAsync(value, stream, cancellationToken);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    public static Task XmlPackByAsync(this Stream stream, Type type, object value, CancellationToken cancellationToken = default)
    {
        return XmlHelper.PackAsync(type, value, stream, cancellationToken);
    }
}