using System.Text;
using Cosmos.IO;

namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream, JSONParameters parameters = null, Encoding encoding = null)
    {
        if (value is null || stream is null)
            return;
        var bytes = ToBytes(value, parameters, encoding);
        stream.Write(bytes, 0, bytes.Length);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream, Action<JSONParameters> paramAct, Encoding encoding = null)
    {
        if (value is null || stream is null)
            return;
        var bytes = ToBytes(value, paramAct, encoding);
        stream.Write(bytes, 0, bytes.Length);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, JSONParameters parameters = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        var bytes = await ToBytesAsync(value, parameters, encoding, cancellationToken);
        await stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, Action<JSONParameters> paramAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        var bytes = await ToBytesAsync(value, paramAct, encoding, cancellationToken);
        await stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}