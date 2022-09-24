namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJson<TValue>(string json, JsonSerializerSettings settings = null, bool enableNodaTime = false)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonConvert.DeserializeObject<TValue>(json, settings.ToSettings(enableNodaTime));
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
    public static TValue FromJson<TValue>(string json, TValue targetObject, JsonSerializerSettings settings = null, bool enableNodaTime = false)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonConvert.DeserializeAnonymousType(json, targetObject, settings.ToSettings(enableNodaTime));
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <returns></returns>
    public static object FromJson(Type type, string json, JsonSerializerSettings settings = null, bool enableNodaTime = false)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonConvert.DeserializeObject(json, type, settings.ToSettings(enableNodaTime));
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
    public static async Task<TValue> FromJsonAsync<TValue>(string json, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonConvert.DeserializeObject<TValue>(json, settings.ToSettings(enableNodaTime)), cancellationToken);
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
    public static async Task<TValue> FromJsonAsync<TValue>(string json, TValue targetObject, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonConvert.DeserializeAnonymousType(json, targetObject, settings.ToSettings(enableNodaTime)), cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromJsonAsync(Type type, string json, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonConvert.DeserializeObject(json, type, settings.ToSettings(enableNodaTime)), cancellationToken);
    }
}