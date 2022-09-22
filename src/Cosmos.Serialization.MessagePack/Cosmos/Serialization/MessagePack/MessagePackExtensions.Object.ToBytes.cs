namespace Cosmos.Serialization.MessagePack;

public static partial class MessagePackExtensions
{
#if NET452
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToMessagePackBytes<TValue>(this TValue value)
    {
        return MessagePackHelper.ToBytes(value);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static byte[] ToMessagePackBytes(this object value, Type type)
    {
        return MessagePackHelper.ToBytes(type, value);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToMessagePackBytesAsync<TValue>(this TValue value, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.ToBytesAsync(value, cancellationToken);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToMessagePackBytesAsync(this object value, Type type, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.ToBytesAsync(type, value, cancellationToken);
    }
#else
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToMessagePackBytes<TValue>(this TValue value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.ToBytes(value, options, cancellationToken);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static byte[] ToMessagePackBytes(this object value, Type type, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.ToBytes(type, value, options, cancellationToken);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToMessagePackBytesAsync<TValue>(this TValue value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.ToBytesAsync(value, options, cancellationToken);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToMessagePackBytesAsync(this object value, Type type, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.ToBytesAsync(type, value, options, cancellationToken);
    }
#endif
}