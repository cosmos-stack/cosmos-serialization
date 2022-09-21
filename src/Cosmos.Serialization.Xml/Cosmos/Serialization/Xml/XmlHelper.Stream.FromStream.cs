using Cosmos.IO;

namespace Cosmos.Serialization.Xml;

public static partial class XmlHelper
{
    /// <summary>
    /// Deserializes the XML document contained by the specified stream.
    /// </summary>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromStream<TValue>(Stream stream)
    {
        return (TValue)FromStream(typeof(TValue), stream);
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <returns></returns>
    public static object FromStream(Type type, Stream stream)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var ret = Man.GetSerializer(type).Deserialize(stream);
        stream.TrySeek(0, SeekOrigin.Begin);
        return ret;
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified stream.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromStreamAsync<TValue>(Stream stream, CancellationToken cancellationToken = default)
    {
        var value = await FromStreamAsync(typeof(TValue), stream, cancellationToken);
        return (TValue)value;
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromStreamAsync(Type type, Stream stream, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var ret = await Async(() => Man.GetSerializer(type).Deserialize(stream), cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
        return ret;
    }
}