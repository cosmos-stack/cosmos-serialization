using Cosmos.Conversions;

namespace Cosmos.Serialization.MessagePack;

public static partial class MessagePackHelper
{
#if NET452
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
        return MessagePackSerializer.Deserialize<TValue>(bytes);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
        return MessagePackSerializer.NonGeneric.Deserialize(type, bytes);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
        using var stream = new MemoryStream(bytes);
        return await MessagePackSerializer.DeserializeAsync<TValue>(stream);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
        using var stream = new MemoryStream(bytes);
        await Task.Run(() => MessagePackSerializer.NonGeneric.Deserialize(type, stream), cancellationToken);
        return await stream.CastToBytesAsync();
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
    public static TValue FromBytes<TValue>(ReadOnlyMemory<byte> bytes, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return bytes.Length is 0
            ? default
            : MessagePackSerializer.Deserialize<TValue>(bytes, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, ReadOnlyMemory<byte> bytes, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return bytes.Length is 0
            ? default
            : MessagePackSerializer.Deserialize(type, bytes, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
        using var stream = new MemoryStream(bytes);
        return await MessagePackSerializer.DeserializeAsync<TValue>(stream, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
        using var stream = new MemoryStream(bytes);
        return await MessagePackSerializer.DeserializeAsync(type, stream, options, cancellationToken);
    }
#endif
}