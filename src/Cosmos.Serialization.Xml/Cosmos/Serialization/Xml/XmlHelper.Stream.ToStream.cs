namespace Cosmos.Serialization.Xml;

public static partial class XmlHelper
{
    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using a memory stream.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value)
    {
        return ToStream(typeof(TValue), value);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using a memory stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Stream ToStream(Type type, object value)
    {
        var stream = new MemoryStream();
        Pack(type, value, stream);
        return stream;
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using a memory stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToStreamAsync<TValue>(TValue value, CancellationToken cancellationToken = default)
    {
        return ToStreamAsync(typeof(TValue), value, cancellationToken);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using a memory stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync(Type type, object value, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(type, value, stream, cancellationToken);
        return stream;
    }
}