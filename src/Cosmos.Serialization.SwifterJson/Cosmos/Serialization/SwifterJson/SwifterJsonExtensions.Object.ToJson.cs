namespace Cosmos.Serialization.SwifterJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToSwifterJson<TValue>(this TValue value, JsonFormatterOptions? options = null)
    {
        return SwifterJsonHelper.ToJson(value, options);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<string> ToSwifterJsonAsync<TValue>(this TValue value, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
    {
        return SwifterJsonHelper.ToJsonAsync(value, options, cancellationToken);
    }
}