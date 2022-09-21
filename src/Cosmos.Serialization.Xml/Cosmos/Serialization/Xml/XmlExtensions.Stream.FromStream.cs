namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    /// <summary>
    /// Deserializes the XML document contained by the specified stream.
    /// </summary>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromXmlStream<TValue>(this Stream stream)
    {
        return XmlHelper.FromStream<TValue>(stream);
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <returns></returns>
    public static object FromXmlStream(this Stream stream, Type type)
    {
        return XmlHelper.FromStream(type, stream);
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified stream.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromXmlStreamAsync<TValue>(this Stream stream, CancellationToken cancellationToken = default)
    {
        return XmlHelper.FromStreamAsync<TValue>(stream, cancellationToken);
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromXmlStreamAsync(this Stream stream, Type type, CancellationToken cancellationToken = default)
    {
        return XmlHelper.FromStreamAsync(type, stream, cancellationToken);
    }
}