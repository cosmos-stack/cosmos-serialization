using System.Text;
using Cosmos.Conversions;
using Cosmos.IO;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromStream<TValue>(Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = FromBytes<TValue>(stream.CastToBytes(), settings, enableNodaTime, encoding);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromStream(Type type, Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = FromBytes(type, stream.CastToBytes(), settings, enableNodaTime, encoding);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromStreamAsync<TValue>(Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = await FromBytesAsync<TValue>(await stream.CastToBytesAsync(), settings, enableNodaTime, encoding, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromStreamAsync(Type type, Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = await FromBytesAsync(type, await stream.CastToBytesAsync(), settings, enableNodaTime, encoding, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }
}