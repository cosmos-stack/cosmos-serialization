namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromNewtonsoftJson<TValue>(this string json, JsonSerializerSettings settings = null, bool enableNodaTime = false)
    {
        return NewtonsoftJsonHelper.FromJson<TValue>(json, settings, enableNodaTime);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="targetObject"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromNewtonsoftJson<TValue>(this string json, TValue targetObject, JsonSerializerSettings settings = null, bool enableNodaTime = false)
    {
        return NewtonsoftJsonHelper.FromJson(json, targetObject, settings, enableNodaTime);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <returns></returns>
    public static object FromNewtonsoftJson(this string json, Type type, JsonSerializerSettings settings = null, bool enableNodaTime = false)
    {
        return NewtonsoftJsonHelper.FromJson(type, json, settings, enableNodaTime);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromNewtonsoftJsonAsync<TValue>(this string json, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default)
    {
        return NewtonsoftJsonHelper.FromJsonAsync<TValue>(json, settings, enableNodaTime, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="targetObject"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromNewtonsoftJsonAsync<TValue>(this string json, TValue targetObject, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default)
    {
        return NewtonsoftJsonHelper.FromJsonAsync(json, targetObject, settings, enableNodaTime, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromNewtonsoftJsonAsync(this string json, Type type, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default)
    {
        return NewtonsoftJsonHelper.FromJsonAsync(type, json, settings, enableNodaTime, cancellationToken);
    }
}