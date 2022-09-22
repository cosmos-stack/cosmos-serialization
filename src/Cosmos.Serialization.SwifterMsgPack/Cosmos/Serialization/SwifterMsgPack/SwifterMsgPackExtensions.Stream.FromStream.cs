using Swifter.MessagePack;

namespace Cosmos.Serialization.SwifterMsgPack;

public static partial class SwifterMsgPackExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromSwifterMsgPackStream<TValue>(this Stream stream, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        return SwifterMsgPackHelper.FromStream<TValue>(stream, options);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromSwifterMsgPackStream(this Stream stream, Type type, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        return SwifterMsgPackHelper.FromStream(type, stream, options);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromSwifterMsgPackStreamAsync<TValue>(this Stream stream, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        return SwifterMsgPackHelper.FromStreamAsync<TValue>(stream, options, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromSwifterMsgPackStreamAsync(this Stream stream, Type type, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        return SwifterMsgPackHelper.FromStreamAsync(type, stream, options, cancellationToken);
    }
}