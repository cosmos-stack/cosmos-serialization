using Swifter.MessagePack;

namespace Cosmos.Serialization.SwifterMsgPack;

public static partial class SwifterMsgPackHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
        using var stream = new MemoryStream(bytes);
        return FromStream<TValue>(stream, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        if (bytes is null || bytes.Length is 0)
            return null;
        using var stream = new MemoryStream(bytes);
        return FromStream(type, stream, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
#if NETFRAMEWORK
        using var stream = new MemoryStream(bytes);
#else
        await using var stream = new MemoryStream(bytes);
#endif
        return await FromStreamAsync<TValue>(stream, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length is 0)
            return null;
#if NETFRAMEWORK
        using var stream = new MemoryStream(bytes);
#else
        await using var stream = new MemoryStream(bytes);
#endif
        return await FromStreamAsync(type, stream, options, cancellationToken);
    }
}