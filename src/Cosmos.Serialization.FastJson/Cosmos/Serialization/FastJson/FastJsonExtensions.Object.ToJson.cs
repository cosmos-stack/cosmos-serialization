namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="parameters"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToFastJson<TValue>(this TValue value, JSONParameters parameters = null)
    {
        return FastJsonHelper.ToJson(value, parameters);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToFastJson<TValue>(this TValue value, Action<JSONParameters> paramAct)
    {
        return FastJsonHelper.ToJson(value, paramAct);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="parameters"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<string> ToFastJsonAsync<TValue>(this TValue value, JSONParameters parameters = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.ToJsonAsync(value, parameters, cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<string> ToFastJsonAsync<TValue>(this TValue value, Action<JSONParameters> paramAct, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.ToJsonAsync(value, paramAct, cancellationToken);
    }
}