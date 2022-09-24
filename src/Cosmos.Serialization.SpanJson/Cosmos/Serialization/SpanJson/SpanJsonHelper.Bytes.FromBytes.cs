using Cosmos.Asynchronous;
using SpanJson;

namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonHelper
{
    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JsonSerializer.NonGeneric.Utf8.Deserialize(bytes, type);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, in ReadOnlySpan<byte> bytes)
    {
        return bytes.IsEmpty
            ? default
            : JsonSerializer.NonGeneric.Utf8.Deserialize(bytes, type);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JsonSerializer.Generic.Utf8.Deserialize<TValue>(bytes);
    }


    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(in ReadOnlySpan<byte> data)
    {
        return data.IsEmpty
            ? default
            : JsonSerializer.Generic.Utf8.Deserialize<TValue>(data);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static ValueTask<object> FromBytesAsync(Type type, byte[] bytes, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length == 0)
#if NET5_0_OR_GREATER
            return ValueTask.FromResult(default(object));
#else
            return ValueTasks.Create(default(object));
#endif
        using var stream = new MemoryStream(bytes);
        return JsonSerializer.NonGeneric.Utf8.DeserializeAsync(stream, type, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static ValueTask<T> FromBytesAsync<T>(byte[] bytes, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length == 0)
#if NET5_0_OR_GREATER
            return ValueTask.FromResult(default(T));
#else
            return ValueTasks.Create(default(T));
#endif
        using var stream = new MemoryStream(bytes);
        return JsonSerializer.Generic.Utf8.DeserializeAsync<T>(stream, cancellationToken);
    }
}