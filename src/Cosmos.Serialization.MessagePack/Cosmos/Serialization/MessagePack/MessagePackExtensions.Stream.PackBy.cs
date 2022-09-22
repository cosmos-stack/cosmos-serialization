namespace Cosmos.Serialization.MessagePack;

public static partial class MessagePackExtensions
{
#if NET452
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void MessagePackBy<TValue>(this Stream stream, TValue value)
    {
        MessagePackHelper.Pack(value, stream);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    public static void MessagePackBy(this Stream stream, Type type, object value)
    {
        MessagePackHelper.Pack(type, value, stream);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task MessagePackByAsync<TValue>(this Stream stream, TValue value, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.PackAsync(value, stream, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    public static Task MessagePackByAsync(this Stream stream, Type type, object value, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.PackAsync(type, value, stream, cancellationToken);
    }
#else
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void MessagePackBy<TValue>(this Stream stream, TValue value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        MessagePackHelper.Pack(value, stream, options, cancellationToken);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    public static void MessagePackBy(this Stream stream, Type type, object value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        MessagePackHelper.Pack(type, value, stream, options, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task MessagePackByAsync<TValue>(this Stream stream, TValue value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.PackAsync(value, stream, options, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    public static Task MessagePackByAsync(this Stream stream, Type type, object value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.PackAsync(type, value, stream, options, cancellationToken);
    }
#endif
}