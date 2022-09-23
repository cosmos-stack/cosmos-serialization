namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="parameters"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToJson<TValue>(TValue value, JSONParameters parameters = null)
    {
        return value is null
            ? string.Empty
            : JSON.ToJSON(value, parameters.ToParams());
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToJson<TValue>(TValue value, Action<JSONParameters> paramAct)
    {
        return value is null
            ? string.Empty
            : JSON.ToJSON(value, paramAct.GetParams());
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="parameters"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync<TValue>(TValue value, JSONParameters parameters = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JSON.ToJSON(value, parameters.ToParams()), cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync<TValue>(TValue value, Action<JSONParameters> paramAct, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JSON.ToJSON(value, paramAct.GetParams()), cancellationToken);
    }
}