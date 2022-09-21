namespace Cosmos.Serialization.ZeroFormatter;

public static partial class ZeroFormatterHelper
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromStream<TValue>(Stream stream)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return ZeroFormatterSerializer.Deserialize<TValue>(stream);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromStream(Type type, Stream stream)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return ZeroFormatterSerializer.NonGeneric.Deserialize(type, stream);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromStreamAsync<TValue>(Stream stream, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return await Task.Run(() => ZeroFormatterSerializer.Deserialize<TValue>(stream), cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromStreamAsync(Type type, Stream stream, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return await Task.Run(() => ZeroFormatterSerializer.NonGeneric.Deserialize(type, stream), cancellationToken);
    }
}