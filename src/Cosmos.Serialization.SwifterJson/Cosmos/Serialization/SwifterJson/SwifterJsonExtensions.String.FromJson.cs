namespace Cosmos.Serialization.SwifterJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromSwifterJson<TValue>(this string json, JsonFormatterOptions? options = null)
    {
        return SwifterJsonHelper.FromJson<TValue>(json, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromSwifterJson(this string json, Type type, JsonFormatterOptions? options = null)
    {
        return SwifterJsonHelper.FromJson(type, json, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromSwifterJsonAsync<TValue>(this string json, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
    {
        return SwifterJsonHelper.FromJsonAsync<TValue>(json, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromSwifterJsonAsync(this string json, Type type, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
    {
        return SwifterJsonHelper.FromJsonAsync(type, json, options, cancellationToken);
    }
}