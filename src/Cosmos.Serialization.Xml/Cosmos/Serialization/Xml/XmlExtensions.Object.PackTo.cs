namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void XmlPackTo<TValue>(this TValue value, Stream stream)
    {
        XmlHelper.Pack(value, stream);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    public static void XmlPackTo(this object value, Type type, Stream stream)
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
    public static Task XmlPackToAsync<TValue>(this TValue value, Stream stream, CancellationToken cancellationToken = default)
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
    public static Task XmlPackToAsync(this object value, Type type, Stream stream, CancellationToken cancellationToken = default)
    {
        return XmlHelper.PackAsync(type, value, stream, cancellationToken);
    }
}