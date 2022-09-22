namespace Cosmos.Serialization.MessagePack;

public static partial class MessagePackExtensions
{
#if NET452
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromMessagePackStream<TValue>(this Stream stream)
    {
        return MessagePackHelper.FromStream<TValue>(stream);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromMessagePackStream(this Stream stream, Type type)
    {
        return MessagePackHelper.FromStream(type, stream);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromMessagePackStreamAsync<TValue>(this Stream stream, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromStreamAsync<TValue>(stream, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromMessagePackStreamAsync(this Stream stream, Type type, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromStreamAsync(type, stream, cancellationToken);
    }
#else
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromMessagePackStream<TValue>(this Stream stream, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromStream<TValue>(stream, options, cancellationToken);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static object FromMessagePackStream(this Stream stream, Type type, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromStream(type, stream, options, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromMessagePackStreamAsync<TValue>(this Stream stream, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromStreamAsync<TValue>(stream, options, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromMessagePackStreamAsync(this Stream stream, Type type, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromStreamAsync(type, stream, options, cancellationToken);
    }
#endif
}