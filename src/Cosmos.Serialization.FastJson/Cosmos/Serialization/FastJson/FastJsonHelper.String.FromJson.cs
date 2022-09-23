namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="parameters"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJson<TValue>(string json, JSONParameters parameters = null)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JSON.ToObject<TValue>(json, parameters.ToParams());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="paramAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJson<TValue>(string json, Action<JSONParameters> paramAct)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JSON.ToObject<TValue>(json, paramAct.GetParams());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public static object FromJson(Type type, string json, JSONParameters parameters = null)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JSON.ToObject(json, type, parameters.ToParams());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="paramAct"></param>
    /// <returns></returns>
    public static object FromJson(Type type, string json, Action<JSONParameters> paramAct)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JSON.ToObject(json, type, paramAct.GetParams());
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="parameters"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromJsonAsync<TValue>(string json, JSONParameters parameters = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JSON.ToObject<TValue>(json, parameters.ToParams()), cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="paramAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromJsonAsync<TValue>(string json, Action<JSONParameters> paramAct, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JSON.ToObject<TValue>(json, paramAct.GetParams()), cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="parameters"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromJsonAsync(Type type, string json, JSONParameters parameters = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JSON.ToObject(json, type, parameters.ToParams()), cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="paramAct"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromJsonAsync(Type type, string json, Action<JSONParameters> paramAct, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JSON.ToObject(json, type, paramAct.GetParams()), cancellationToken);
    }
}