using Cosmos.Conversions;
using Swifter.MessagePack;

namespace Cosmos.Serialization.SwifterMsgPack;

public static partial class SwifterMsgPackHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        using var stream = ToStream(value, options);
        return stream.CastToBytes();
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static byte[] ToBytes(Type type, object value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        using var stream = ToStream(type, value, options);
        return stream.CastToBytes();
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
#if NETFRAMEWORK
        using var stream = await ToStreamAsync(value, options, cancellationToken);
#else
        await using var stream = await ToStreamAsync(value, options, cancellationToken);
#endif
        return await stream.CastToBytesAsync();
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(Type type, object value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
#if NETFRAMEWORK
        using var stream = await ToStreamAsync(type, value, options, cancellationToken);
#else
        await using var stream = await ToStreamAsync(type, value, options, cancellationToken);
#endif
        return await stream.CastToBytesAsync();
    }
}