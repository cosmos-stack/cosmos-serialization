using System.Text.Json;
using Cosmos.IO;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream, JsonSerializerOptions options = null)
    {
        if (value is null || stream is null)
            return;
        var bytes = ToBytes(value, options);
        stream.Write(bytes, 0, bytes.Length);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        var bytes = await ToBytesAsync(value, options, cancellationToken);
        await stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}