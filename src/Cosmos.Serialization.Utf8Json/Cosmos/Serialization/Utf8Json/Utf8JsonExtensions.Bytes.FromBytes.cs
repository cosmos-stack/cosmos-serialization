namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromUtf8JsonBytes<TValue>(this byte[] bytes, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.FromBytes<TValue>(bytes, resolver);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static object FromUtf8JsonBytes(this byte[] bytes, Type type, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.FromBytes(type, bytes, resolver);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromUtf8JsonBytesAsync<TValue>(this byte[] bytes, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return Utf8JsonHelper.FromBytesAsync<TValue>(bytes, resolver, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromUtf8JsonBytesAsync(this byte[] bytes, Type type, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return Utf8JsonHelper.FromBytesAsync(type, bytes, resolver, cancellationToken);
    }
}