namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonHelper
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value, IJsonFormatterResolver resolver = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : JsonSerializer.Serialize(value, resolver);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static byte[] ToBytes(object value, IJsonFormatterResolver resolver = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : JsonSerializer.NonGeneric.Serialize(value, resolver);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static byte[] ToBytes(Type type, object value, IJsonFormatterResolver resolver = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : JsonSerializer.NonGeneric.Serialize(type, value, resolver);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : await Task.Run(() => JsonSerializer.Serialize(value, resolver), cancellationToken);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(object value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : await Task.Run(() => JsonSerializer.NonGeneric.Serialize(value, resolver), cancellationToken);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(Type type, object value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : await Task.Run(() => JsonSerializer.NonGeneric.Serialize(type, value, resolver), cancellationToken);
    }
}