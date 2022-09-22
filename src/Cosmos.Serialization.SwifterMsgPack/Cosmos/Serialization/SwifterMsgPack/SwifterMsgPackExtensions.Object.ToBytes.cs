using Swifter.MessagePack;

namespace Cosmos.Serialization.SwifterMsgPack;

public static partial class SwifterMsgPackExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToSwifterMsgPackBytes<TValue>(this TValue value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        return SwifterMsgPackHelper.ToBytes(value, options);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static byte[] ToSwifterMsgPackBytes(this object value, Type type, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        return SwifterMsgPackHelper.ToBytes(type, value, options);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToSwifterMsgPackBytesAsync<TValue>(this TValue value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        return SwifterMsgPackHelper.ToBytesAsync(value, options, cancellationToken);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToSwifterMsgPackBytesAsync(this object value, Type type, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        return SwifterMsgPackHelper.ToBytesAsync(type, value, options, cancellationToken);
    }
}