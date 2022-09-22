using Swifter.MessagePack;

namespace Cosmos.Serialization.SwifterMsgPack;

public static partial class SwifterMsgPackExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void SwifterMsgPackTo<TValue>(this TValue value, Stream stream, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        SwifterMsgPackHelper.Pack(value, stream, options);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    public static void SwifterMsgPackTo(this object value, Type type, Stream stream, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        SwifterMsgPackHelper.Pack(type, value, stream, options);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task SwifterMsgPackToAsync<TValue>(this TValue value, Stream stream, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        return SwifterMsgPackHelper.PackAsync(value, stream, options, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    public static Task SwifterMsgPackToAsync(this object value, Type type, Stream stream, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        return SwifterMsgPackHelper.PackAsync(type, value, stream, options, cancellationToken);
    }
}