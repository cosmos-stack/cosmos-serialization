using System.Text;
using Cosmos.IO;

namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="serializer"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream, S serializer = null, Encoding encoding = default)
    {
        if (stream is null) return;
#if NETCOREAPP
        stream.Write(ToBytes(value, serializer, encoding));
#else
        var bytes = ToBytes(value, serializer, encoding);
        stream.Write(bytes, 0, bytes.Length);
#endif
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="serializer"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, S serializer = null, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        if (stream is null) return;
#if NETCOREAPP
        var bytes = await ToBytesAsync(value, serializer, encoding, cancellationToken);
        stream.Write(bytes);
#else
        var bytes = await ToBytesAsync(value, serializer, encoding, cancellationToken);
        await stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken);
#endif
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}