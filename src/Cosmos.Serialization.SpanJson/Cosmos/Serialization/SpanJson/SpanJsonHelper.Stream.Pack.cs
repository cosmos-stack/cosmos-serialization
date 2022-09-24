using Cosmos.IO;
using SpanJson;

namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream)
    {
        if (value is null || stream is null)
            return;
        var bytes = JsonSerializer.Generic.Utf8.Serialize(value);
        stream.Write(bytes, 0, bytes.Length);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async ValueTask PackAsync<TValue>(TValue value, Stream stream, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        await JsonSerializer.Generic.Utf8.SerializeAsync(value, stream, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}