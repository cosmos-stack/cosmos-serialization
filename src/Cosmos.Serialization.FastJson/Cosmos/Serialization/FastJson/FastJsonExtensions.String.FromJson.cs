namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="parameters"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromFastJson<TValue>(this string json, JSONParameters parameters = null)
    {
        return FastJsonHelper.FromJson<TValue>(json, parameters);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="paramAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromFastJson<TValue>(this string json, Action<JSONParameters> paramAct)
    {
        return FastJsonHelper.FromJson<TValue>(json, paramAct);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public static object FromFastJson(this string json, Type type, JSONParameters parameters = null)
    {
        return FastJsonHelper.FromJson(type, json, parameters);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="paramAct"></param>
    /// <returns></returns>
    public static object FromFastJson(this string json, Type type, Action<JSONParameters> paramAct)
    {
        return FastJsonHelper.FromJson(type, json, paramAct);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="parameters"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromFastJsonAsync<TValue>(this string json, JSONParameters parameters = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.FromJsonAsync<TValue>(json, parameters, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="paramAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromFastJsonAsync<TValue>(this string json, Action<JSONParameters> paramAct, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.FromJsonAsync<TValue>(json, paramAct, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="parameters"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromFastJsonAsync(this string json, Type type, JSONParameters parameters = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.FromJsonAsync(type, json, parameters, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="paramAct"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromFastJsonAsync(this string json, Type type, Action<JSONParameters> paramAct, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.FromJsonAsync(type, json, paramAct, cancellationToken);
    }
}