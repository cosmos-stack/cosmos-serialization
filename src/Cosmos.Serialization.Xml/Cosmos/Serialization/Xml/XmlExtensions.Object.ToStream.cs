namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using a memory stream.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToXmlStream<TValue>(this TValue value)
    {
        return XmlHelper.ToStream(value);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using a memory stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Stream ToXmlStream(this object value, Type type)
    {
        return XmlHelper.ToStream(type, value);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using a memory stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToXmlStreamAsync<TValue>(this TValue value, CancellationToken cancellationToken = default)
    {
        return XmlHelper.ToStreamAsync(value, cancellationToken);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using a memory stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<Stream> ToXmlStreamAsync(this object value, Type type, CancellationToken cancellationToken = default)
    {
        return XmlHelper.ToStreamAsync(type, value, cancellationToken);
    }
}