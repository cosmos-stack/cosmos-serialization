using Cosmos.Conversions;

namespace Cosmos.Serialization.MessagePack;

public static partial class MessagePackHelper
{
#if NET452
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : MessagePackSerializer.Serialize(value);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static byte[] ToBytes(Type type, object value)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : MessagePackSerializer.NonGeneric.Serialize(type, value);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, CancellationToken cancellationToken = default)
    {
        if (value is null)
            return Arrays.Empty<byte>();
        using var stream = new MemoryStream();
        await MessagePackSerializer.SerializeAsync(stream, value);
        return await stream.CastToBytesAsync();
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(Type type, object value, CancellationToken cancellationToken = default)
    {
        if (value is null)
            return Arrays.Empty<byte>();
        using var stream = new MemoryStream();
        await Task.Run(() => MessagePackSerializer.NonGeneric.Serialize(type, stream, value), cancellationToken);
        return await stream.CastToBytesAsync();
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
    public static byte[] ToBytes<TValue>(TValue value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : MessagePackSerializer.Serialize(value, options, cancellationToken);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static byte[] ToBytes(Type type, object value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : MessagePackSerializer.Serialize(type, value, options, cancellationToken);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (value is null)
            return Arrays.Empty<byte>();
        using var stream = new MemoryStream();
        await MessagePackSerializer.SerializeAsync(stream, value, options, cancellationToken);
        return await stream.CastToBytesAsync();
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(Type type, object value, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (value is null)
            return Arrays.Empty<byte>();
        using var stream = new MemoryStream();
        await MessagePackSerializer.SerializeAsync(type, stream, value, options, cancellationToken);
        return await stream.CastToBytesAsync();
    }
#endif
}