namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonExtensions
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToUtf8JsonBytes<TValue>(this TValue value, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.ToBytes(value, resolver);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static byte[] ToUtf8JsonBytes(this object value, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.ToBytes(value, resolver);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static byte[] ToUtf8JsonBytes(this object value, Type type, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.ToBytes(type, value, resolver);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToUtf8JsonBytesAsync<TValue>(this TValue value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return Utf8JsonHelper.ToBytesAsync(value, resolver, cancellationToken);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToUtf8JsonBytesAsync(this object value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return Utf8JsonHelper.ToBytesAsync(value, resolver, cancellationToken);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToUtf8JsonBytesAsync(this object value, Type type, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return Utf8JsonHelper.ToBytesAsync(type, value, resolver, cancellationToken);
    }
}