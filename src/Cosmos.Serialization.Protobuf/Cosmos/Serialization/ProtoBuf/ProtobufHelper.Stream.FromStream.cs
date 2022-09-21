using Cosmos.IO;

namespace Cosmos.Serialization.ProtoBuf;

/// <summary>
/// Google protobuf helper
/// </summary>
public static partial class ProtobufHelper
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromStream<TValue>(Stream stream)
    {
        if (stream is null || stream.Length == 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = (TValue)Man.TypeModel.Deserialize(stream, null, typeof(TValue));
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <returns></returns>
    public static object FromStream(Type type, Stream stream)
    {
        if (stream is null || stream.Length == 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = Man.TypeModel.Deserialize(stream, null, type);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromStreamAsync<TValue>(Stream stream, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.Length == 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = await Async(() => (TValue)Man.TypeModel.Deserialize(stream, null, typeof(TValue)), cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromStreamAsync(Type type, Stream stream, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.Length == 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = await Async(() => Man.TypeModel.Deserialize(stream, null, type), cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }
}