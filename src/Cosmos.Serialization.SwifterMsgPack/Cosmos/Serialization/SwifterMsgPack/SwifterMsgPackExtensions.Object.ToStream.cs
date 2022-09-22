using Swifter.MessagePack;

namespace Cosmos.Serialization.SwifterMsgPack;

public static partial class SwifterMsgPackExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToSwifterMsgPackStream<TValue>(this TValue value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        return SwifterMsgPackHelper.ToStream(value, options);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Stream ToSwifterMsgPackStream(this object value, Type type, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        return SwifterMsgPackHelper.ToStream(type, value, options);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToSwifterMsgPackStreamAsync<TValue>(this TValue value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        return SwifterMsgPackHelper.ToStreamAsync(value, options, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<Stream> ToSwifterMsgPackStreamAsync(this object value, Type type, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        return SwifterMsgPackHelper.ToStreamAsync(type, value, options, cancellationToken);
    }
}