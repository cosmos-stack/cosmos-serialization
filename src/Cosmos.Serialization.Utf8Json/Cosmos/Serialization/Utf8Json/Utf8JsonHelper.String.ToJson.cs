namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToJson<TValue>(TValue value, IJsonFormatterResolver resolver = null)
    {
        return value is null
            ? string.Empty
            : JsonSerializer.ToJsonString(value, resolver);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static string ToJson(object value, IJsonFormatterResolver resolver = null)
    {
        return value is null
            ? string.Empty
            : JsonSerializer.NonGeneric.ToJsonString(value, resolver);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static string ToJson(Type type, object value, IJsonFormatterResolver resolver = null)
    {
        return value is null
            ? string.Empty
            : JsonSerializer.NonGeneric.ToJsonString(type, value, resolver);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync<TValue>(TValue value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JsonSerializer.ToJsonString(value, resolver), cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync(object value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JsonSerializer.NonGeneric.ToJsonString(value, resolver), cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync(Type type, object value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JsonSerializer.NonGeneric.ToJsonString(type, value, resolver), cancellationToken);
    }
}