namespace Cosmos.Serialization.MessagePack;

public static partial class MessagePackHelper
{
#if NET452
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value)
    {
        var stream = new MemoryStream();
        Pack(value, stream);
        return stream;
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Stream ToStream(Type type, object value)
    {
        var stream = new MemoryStream();
        Pack(type, value, stream);
        return stream;
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(value, stream, cancellationToken);
        return stream;
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync(Type type, object value, CancellationToken cancellationToken = default)
    {
        var ms = new MemoryStream();
        await PackAsync(type, value, ms, cancellationToken);
        return ms;
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
    public static Stream ToStream<TValue>(TValue value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        Pack(value, stream, options, cancellationToken);
        return stream;
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Stream ToStream(Type type, object value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        Pack(type, value, stream, options, cancellationToken);
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
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
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
    public static async Task<Stream> ToStreamAsync(Type type, object value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(type, value, stream, options, cancellationToken);
        return stream;
    }
#endif
}