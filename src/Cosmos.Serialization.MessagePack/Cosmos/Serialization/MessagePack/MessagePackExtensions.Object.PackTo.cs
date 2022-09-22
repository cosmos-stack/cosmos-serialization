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
    public static void MessagePackTo<TValue>(this TValue value, Stream stream)
    {
        MessagePackHelper.Pack(value, stream);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    public static void MessagePackTo(this object value, Type type, Stream stream)
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
    public static Task MessagePackToAsync<TValue>(this TValue value, Stream stream, CancellationToken cancellationToken = default)
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
    public static Task MessagePackToAsync(this object value, Type type, Stream stream, CancellationToken cancellationToken = default)
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
    public static void MessagePackTo<TValue>(this TValue value, Stream stream, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
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
    public static void MessagePackTo(this object value, Type type, Stream stream, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
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
    public static Task MessagePackToAsync<TValue>(this TValue value, Stream stream, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
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
    public static Task MessagePackToAsync(this object value, Type type, Stream stream, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.PackAsync(type, value, stream, options, cancellationToken);
    }
#endif
}