namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="option"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJson<TValue>(string json, JsonDeserializeOption option = null)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.ToObject<TValue>(json, option.ToOptions());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJson<TValue>(string json, Action<JsonDeserializeOption> optionAct)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.ToObject<TValue>(json, optionAct.GetOptions());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="option"></param>
    /// <returns></returns>
    public static object FromJson(Type type, string json, JsonDeserializeOption option = null)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.ToObject(json, type, option.ToOptions());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static object FromJson(Type type, string json, Action<JsonDeserializeOption> optionAct)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.ToObject(json, type, optionAct.GetOptions());
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="option"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromJsonAsync<TValue>(string json, JsonDeserializeOption option = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonSerializer.ToObject<TValue>(json, option.ToOptions()), cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromJsonAsync<TValue>(string json, Action<JsonDeserializeOption> optionAct, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonSerializer.ToObject<TValue>(json, optionAct.GetOptions()), cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="option"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromJsonAsync(Type type, string json, JsonDeserializeOption option = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonSerializer.ToObject(json, type, option.ToOptions()), cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromJsonAsync(Type type, string json, Action<JsonDeserializeOption> optionAct, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JsonSerializer.ToObject(json, type, optionAct.GetOptions()), cancellationToken);
    }
}