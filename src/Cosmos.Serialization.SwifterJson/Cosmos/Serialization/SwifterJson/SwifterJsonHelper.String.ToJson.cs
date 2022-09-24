namespace Cosmos.Serialization.SwifterJson;

public static partial class SwifterJsonHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToJson<TValue>(TValue value, JsonFormatterOptions? options = null)
    {
        return value is null
            ? string.Empty
            : JsonFormatter.SerializeObject(value, options.ToSerializeOptions());
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync<TValue>(TValue value, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JsonFormatter.SerializeObject(value, options.ToSerializeOptions()), cancellationToken);
    }
}