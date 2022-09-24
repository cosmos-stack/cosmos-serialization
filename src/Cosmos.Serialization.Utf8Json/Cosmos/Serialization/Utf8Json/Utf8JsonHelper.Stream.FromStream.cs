using Cosmos.Conversions;
using Cosmos.IO;

namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonHelper
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromStream<TValue>(Stream stream, IJsonFormatterResolver resolver = null)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = FromBytes<TValue>(stream.CastToBytes(), resolver);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static object FromStream(Type type, Stream stream, IJsonFormatterResolver resolver = null)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = FromBytes(type, stream.CastToBytes(), resolver);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromStreamAsync<TValue>(Stream stream, IJsonFormatterResolver resolver = null)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = await FromBytesAsync<TValue>(await stream.CastToBytesAsync(), resolver);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static async Task<object> FromStreamAsync(Type type, Stream stream, IJsonFormatterResolver resolver = null)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = await FromBytesAsync(type, await stream.CastToBytesAsync(), resolver);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }
}