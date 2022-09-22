using Swifter.MessagePack;

namespace Cosmos.Serialization.SwifterMsgPack;

public static partial class SwifterMsgPackExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromSwifterMsgPackBytes<TValue>(this byte[] bytes, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        return SwifterMsgPackHelper.FromBytes<TValue>(bytes, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromSwifterMsgPackBytes(this byte[] bytes, Type type, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        return SwifterMsgPackHelper.FromBytes(type, bytes, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromSwifterMsgPackBytesAsync<TValue>(this byte[] bytes, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        return SwifterMsgPackHelper.FromBytesAsync<TValue>(bytes, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromSwifterMsgPackBytesAsync(this byte[] bytes, Type type, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        return SwifterMsgPackHelper.FromBytesAsync(type, bytes, options, cancellationToken);
    }
}