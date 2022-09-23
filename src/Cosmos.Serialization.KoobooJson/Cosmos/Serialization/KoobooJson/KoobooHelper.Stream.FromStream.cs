using System.Text;
using Cosmos.Conversions;
using Cosmos.IO;

namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooHelper
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromStream<TValue>(Stream stream, JsonDeserializeOption option = null, Encoding encoding = null)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = FromBytes<TValue>(stream.CastToBytes(), option, encoding);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromStream(Type type, Stream stream, JsonDeserializeOption option = null, Encoding encoding = null)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = FromBytes(type, stream.CastToBytes(), option, encoding);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromStreamAsync<TValue>(Stream stream, JsonDeserializeOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = await FromBytesAsync<TValue>(await stream.CastToBytesAsync(), option, encoding, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromStreamAsync(Type type, Stream stream, JsonDeserializeOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = await FromBytesAsync(type, await stream.CastToBytesAsync(), option, encoding, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }
}