using System.Text;
using Cosmos.Conversions;
using Cosmos.IO;

namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetHelper
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromStream<TValue>(Stream stream, D deserializer = null, Encoding encoding = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var ret = FromBytes<TValue>(stream.ReadAllBytes(), deserializer, encoding);
        stream.TrySeek(0, SeekOrigin.Begin);
        return ret;
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromStream(Type type, Stream stream, D deserializer = null, Encoding encoding = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var ret = FromBytes(type, stream.ReadAllBytes(), deserializer, encoding);
        stream.TrySeek(0, SeekOrigin.Begin);
        return ret;
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromStreamAsync<TValue>(Stream stream, D deserializer = null, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var ret = await FromBytesAsync<TValue>(stream.ReadAllBytes(), deserializer, encoding, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
        return ret;
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromStreamAsync(Type type, Stream stream, D deserializer = null, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var ret = await FromBytesAsync(type, stream.ReadAllBytes(), deserializer, encoding, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
        return ret;
    }
}