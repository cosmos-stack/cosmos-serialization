namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJson<TValue>(string json, IJsonFormatterResolver resolver = null)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.Deserialize<TValue>(json, resolver);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static object FromJson(Type type, string json, IJsonFormatterResolver resolver = null)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.NonGeneric.Deserialize(type, json, resolver);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromJsonAsync<TValue>(string json, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonSerializer.Deserialize<TValue>(json, resolver), cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromJsonAsync(Type type, string json, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonSerializer.NonGeneric.Deserialize(type, json, resolver), cancellationToken);
    }
}