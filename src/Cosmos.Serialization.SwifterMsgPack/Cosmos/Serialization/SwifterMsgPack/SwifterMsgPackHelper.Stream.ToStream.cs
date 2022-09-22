using Swifter.MessagePack;

namespace Cosmos.Serialization.SwifterMsgPack;

public static partial class SwifterMsgPackHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        var stream = new MemoryStream();
        Pack(value, stream, options);
        return stream;
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Stream ToStream(Type type, object value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        var stream = new MemoryStream();
        Pack(type, value, stream, options);
        return stream;
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(value, stream, options, cancellationToken);
        return stream;
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync(Type type, object value, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(type, value, stream, options, cancellationToken);
        return stream;
    }
}