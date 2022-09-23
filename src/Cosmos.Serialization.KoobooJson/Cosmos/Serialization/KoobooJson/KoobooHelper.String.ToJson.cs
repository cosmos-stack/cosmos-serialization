namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="option"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToJson<TValue>(TValue value, JsonSerializerOption option = null)
    {
        return value is null
            ? string.Empty
            : JsonSerializer.ToJson(value, option.ToOptions());
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToJson<TValue>(TValue value, Action<JsonSerializerOption> optionAct)
    {
        return value is null
            ? string.Empty
            : JsonSerializer.ToJson(value, optionAct.GetOptions());
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="option"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync<TValue>(TValue value, JsonSerializerOption option = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JsonSerializer.ToJson(value, option.ToOptions()), cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync<TValue>(TValue value, Action<JsonSerializerOption> optionAct, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JsonSerializer.ToJson(value, optionAct.GetOptions()), cancellationToken);
    }
}