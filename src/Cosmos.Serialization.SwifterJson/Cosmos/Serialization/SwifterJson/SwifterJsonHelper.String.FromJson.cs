namespace Cosmos.Serialization.SwifterJson;

public static partial class SwifterJsonHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJson<TValue>(string json, JsonFormatterOptions? options = null)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonFormatter.DeserializeObject<TValue>(json, options.ToDeserializeOptions());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromJson(Type type, string json, JsonFormatterOptions? options = null)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonFormatter.DeserializeObject(json, type, options.ToDeserializeOptions());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromJsonAsync<TValue>(string json, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonFormatter.DeserializeObject<TValue>(json, options.ToDeserializeOptions()), cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromJsonAsync(Type type, string json, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonFormatter.DeserializeObject(json, type, options.ToDeserializeOptions()), cancellationToken);
    }
}