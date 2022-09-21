using Cosmos.IO;

namespace Cosmos.Serialization.Xml;

public static partial class XmlHelper
{
    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream)
    {
        if (stream is null) return;
        Pack(typeof(TValue), value, stream);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    public static void Pack(Type type, object value, Stream stream)
    {
        if (value is null) return;
        Man.GetSerializer(type).Serialize(stream, value);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, CancellationToken cancellationToken = default)
    {
        if (stream is null) return;
        await PackAsync(typeof(TValue), value, stream, cancellationToken);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    public static async Task PackAsync(Type type, object value, Stream stream, CancellationToken cancellationToken = default)
    {
        if (value is null) return;
        var task = Task.Run(() => Man.GetSerializer(type).Serialize(stream, value), cancellationToken);
        await task;
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}