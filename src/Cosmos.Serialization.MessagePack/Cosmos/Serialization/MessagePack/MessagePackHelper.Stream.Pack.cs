using Cosmos.IO;

namespace Cosmos.Serialization.MessagePack;

public static partial class MessagePackHelper
{
#if NET452
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream)
    {
        if (value is null || stream is null)
            return;
        MessagePackSerializer.Serialize(stream, value);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    public static void Pack(Type type, object value, Stream stream)
    {
        if (value is null || stream is null)
            return;
        MessagePackSerializer.NonGeneric.Serialize(type, stream, value);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        await MessagePackSerializer.SerializeAsync(stream, value);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    public static async Task PackAsync(Type type, object value, Stream stream, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        await Task.Run(() => MessagePackSerializer.NonGeneric.Serialize(type, stream, value), cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
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
    public static void Pack<TValue>(TValue value, Stream stream, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        MessagePackSerializer.Serialize(stream, value, options, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="stream"></param>
    public static void Pack(Type type, object value, Stream stream, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        MessagePackSerializer.Serialize(type, stream, value, options, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        await MessagePackSerializer.SerializeAsync(stream, value, options, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    public static async Task PackAsync(Type type, object value, Stream stream, MessagePackSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        await MessagePackSerializer.SerializeAsync(type, stream, value, options, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
#endif
}