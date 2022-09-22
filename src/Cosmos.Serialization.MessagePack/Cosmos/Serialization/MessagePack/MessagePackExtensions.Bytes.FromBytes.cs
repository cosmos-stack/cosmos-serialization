namespace Cosmos.Serialization.MessagePack;

public static partial class MessagePackExtensions
{
#if NET452
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromMessagePackBytes<TValue>(this byte[] bytes)
    {
        return MessagePackHelper.FromBytes<TValue>(bytes);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromMessagePackBytes(this byte[] bytes, Type type)
    {
        return MessagePackHelper.FromBytes(type, bytes);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromMessagePackBytesAsync<TValue>(this byte[] bytes, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromBytesAsync<TValue>(bytes, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromMessagePackBytesAsync(this byte[] bytes, Type type, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromBytesAsync(type, bytes, cancellationToken);
    }
#else
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromMessagePackBytes<TValue>(this ReadOnlyMemory<byte> bytes, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromBytes<TValue>(bytes, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static object FromMessagePackBytes(this ReadOnlyMemory<byte> bytes, Type type, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromBytes(type, bytes, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromMessagePackBytes<TValue>(this byte[] bytes, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromBytes<TValue>(bytes, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static object FromMessagePackBytes(this byte[] bytes, Type type, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromBytes(type, bytes, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromMessagePackBytesAsync<TValue>(this byte[] bytes, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromBytesAsync<TValue>(bytes, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromMessagePackBytesAsync(this byte[] bytes, Type type, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return MessagePackHelper.FromBytesAsync(type, bytes, options, cancellationToken);
    }
#endif
}