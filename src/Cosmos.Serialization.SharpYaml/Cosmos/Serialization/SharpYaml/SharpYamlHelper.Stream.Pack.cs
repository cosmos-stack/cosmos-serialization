using Cosmos.IO;

namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlHelper
{
    /// <summary>
    /// Serialize the value to yaml text and write it to the <see cref="System.IO.Stream"/>.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="serializer"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream, Serializer serializer = null)
    {
        if (stream is null) return;
        (serializer ?? Man.DefaultSerializer).Serialize(stream, value, typeof(TValue));
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Serialize the value to yaml text and write it to the <see cref="System.IO.Stream"/>.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    public static void Pack(Type type, object value, Stream stream, Serializer serializer = null)
    {
        if (stream is null) return;
        (serializer ?? Man.DefaultSerializer).Serialize(stream, value, type);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Serialize the value to yaml text and write it to the <see cref="System.IO.Stream"/>.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        if (stream is null) return;
        await Task.Run(() => (serializer ?? Man.DefaultSerializer).Serialize(stream, value, typeof(TValue)), cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Serialize the value to yaml text and write it to the <see cref="System.IO.Stream"/>.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    public static async Task PackAsync(Type type, object value, Stream stream, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        if (stream is null) return;
        await Task.Run(() => (serializer ?? Man.DefaultSerializer).Serialize(stream, value, type), cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}