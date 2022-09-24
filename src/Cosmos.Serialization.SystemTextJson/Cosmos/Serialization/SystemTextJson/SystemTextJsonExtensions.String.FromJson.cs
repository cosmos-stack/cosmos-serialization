using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromMsJson<TValue>(this string json, JsonSerializerOptions options = null)
    {
        return SystemTextJsonHelper.FromJson<TValue>(json, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromMsJson(this string json, Type type, JsonSerializerOptions options = null)
    {
        return SystemTextJsonHelper.FromJson(type, json, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromMsJsonAsync<TValue>(this string json, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return SystemTextJsonHelper.FromJsonAsync<TValue>(json, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromMsJsonAsync(this string json, Type type, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return SystemTextJsonHelper.FromJsonAsync(type, json, options, cancellationToken);
    }
}