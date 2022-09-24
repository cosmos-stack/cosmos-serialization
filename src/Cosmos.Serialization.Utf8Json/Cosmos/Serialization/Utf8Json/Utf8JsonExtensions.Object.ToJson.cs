namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToUtf8Json<TValue>(this TValue value, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.ToJson(value, resolver);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static string ToUtf8Json(this object value, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.ToJson(value, resolver);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static string ToUtf8Json(this object value, Type type, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.ToJson(type, value, resolver);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<string> ToUtf8JsonAsync<TValue>(this TValue value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return Utf8JsonHelper.ToJsonAsync(value, resolver, cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<string> ToUtf8JsonAsync(this object value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return Utf8JsonHelper.ToJsonAsync(value, resolver, cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<string> ToUtf8JsonAsync(this object value, Type type, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return Utf8JsonHelper.ToJsonAsync(type, value, resolver, cancellationToken);
    }
}