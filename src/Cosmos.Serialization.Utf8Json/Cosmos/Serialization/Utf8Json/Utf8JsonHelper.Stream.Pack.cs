using Cosmos.IO;

namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream, IJsonFormatterResolver resolver = null)
    {
        if (value is null || stream is null)
            return;
        var bytes = ToBytes(value, resolver);
        stream.Write(bytes, 0, bytes.Length);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        var bytes = await ToBytesAsync(value, resolver, cancellationToken);
        await stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}