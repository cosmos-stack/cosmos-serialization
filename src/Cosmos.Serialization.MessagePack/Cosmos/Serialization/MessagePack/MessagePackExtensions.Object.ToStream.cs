namespace Cosmos.Serialization.MessagePack;

public static partial class MessagePackExtensions
{
#if NET452
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToMessagePackStream<TValue>(this TValue value)
    {
        return MessagePackHelper.ToStream(value);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static Stream ToMessagePackStream(this object value, Type type)
    {
        return MessagePackHelper.ToStream(type, value);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToMessagePackStreamAsync<TValue>(this TValue value, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.ToStreamAsync(value, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<Stream> ToMessagePackStreamAsync(this object value, Type type, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.ToStreamAsync(type, value, cancellationToken);
    }
#else
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToMessagePackStream<TValue>(this TValue value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.ToStream(value, options, cancellationToken);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Stream ToMessagePackStream(this object value, Type type, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.ToStream(type, value, options, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToMessagePackStreamAsync<TValue>(this TValue value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.ToStreamAsync(value, options, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<Stream> ToMessagePackStreamAsync(this object value, Type type, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.ToStreamAsync(type, value, options, cancellationToken);
    }
#endif
}