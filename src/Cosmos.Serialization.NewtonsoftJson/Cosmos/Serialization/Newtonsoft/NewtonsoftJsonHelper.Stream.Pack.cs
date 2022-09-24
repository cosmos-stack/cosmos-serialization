using System.Text;
using Cosmos.IO;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    public static void Pack(object value, Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        if (value is null || stream is null)
            return;
        var bytes = ToBytes(value, settings, enableNodaTime, encoding);
        stream.Write(bytes, 0, bytes.Length);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    public static async Task PackAsync(object value, Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        var bytes = await ToBytesAsync(value, settings, enableNodaTime, encoding, cancellationToken);
        await stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}