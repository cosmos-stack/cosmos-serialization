using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJson<TValue>(string json, JsonSerializerOptions options = null)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.Deserialize<TValue>(json, options.ToOptions());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromJson(Type type, string json, JsonSerializerOptions options = null)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.Deserialize(json, type, options.ToOptions());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromJsonAsync<TValue>(string json, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonSerializer.Deserialize<TValue>(json, options.ToOptions()), cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromJsonAsync(Type type, string json, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonSerializer.Deserialize(json, type, options.ToOptions()), cancellationToken);
    }
}