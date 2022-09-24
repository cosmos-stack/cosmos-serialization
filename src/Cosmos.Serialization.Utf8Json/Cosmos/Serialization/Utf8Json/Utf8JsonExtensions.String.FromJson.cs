namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromUtf8Json<TValue>(this string json, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.FromJson<TValue>(json, resolver);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static object FromUtf8Json(this string json, Type type, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.FromJson(type, json, resolver);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromUtf8JsonAsync<TValue>(this string json, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return Utf8JsonHelper.FromJsonAsync<TValue>(json, resolver, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromUtf8JsonAsync(this string json, Type type, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return Utf8JsonHelper.FromJsonAsync(type, json, resolver, cancellationToken);
    }
}