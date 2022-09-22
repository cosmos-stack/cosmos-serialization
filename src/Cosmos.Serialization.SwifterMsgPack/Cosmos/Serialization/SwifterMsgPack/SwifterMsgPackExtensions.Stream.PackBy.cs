using Swifter.MessagePack;

namespace Cosmos.Serialization.SwifterMsgPack;

public static partial class SwifterMsgPackExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void SwifterMsgPackBy<TValue>(this Stream stream, TValue value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        SwifterMsgPackHelper.Pack(value, stream, options);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    public static void SwifterMsgPackBy(this Stream stream, Type type, object value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        SwifterMsgPackHelper.Pack(type, value, stream, options);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task SwifterMsgPackByAsync<TValue>(this Stream stream, TValue value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        return SwifterMsgPackHelper.PackAsync(value, stream, options, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    public static Task SwifterMsgPackByAsync(this Stream stream, Type type, object value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        return SwifterMsgPackHelper.PackAsync(type, value, stream, options, cancellationToken);
    }
}