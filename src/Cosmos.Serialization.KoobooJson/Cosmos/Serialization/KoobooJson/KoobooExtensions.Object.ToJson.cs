namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="option"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToKoobooJson<TValue>(this TValue value, JsonSerializerOption option = null)
    {
        return KoobooHelper.ToJson(value, option);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToKoobooJson<TValue>(this TValue value, Action<JsonSerializerOption> optionAct)
    {
        return KoobooHelper.ToJson(value, optionAct);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="option"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<string> ToKoobooJsonAsync<TValue>(this TValue value, JsonSerializerOption option = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.ToJsonAsync(value, option, cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<string> ToKoobooJsonAsync<TValue>(this TValue value, Action<JsonSerializerOption> optionAct, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.ToJsonAsync(value, optionAct, cancellationToken);
    }
}