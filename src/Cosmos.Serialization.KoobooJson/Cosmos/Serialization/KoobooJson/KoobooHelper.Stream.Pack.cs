using System.Text;
using Cosmos.IO;

namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream, JsonSerializerOption option = null, Encoding encoding = null)
    {
        if (value is null || stream is null)
            return;
        var bytes = ToBytes(value, option, encoding);
        stream.Write(bytes, 0, bytes.Length);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, JsonSerializerOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        var bytes = await ToBytesAsync(value, option, encoding, cancellationToken);
        await stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}