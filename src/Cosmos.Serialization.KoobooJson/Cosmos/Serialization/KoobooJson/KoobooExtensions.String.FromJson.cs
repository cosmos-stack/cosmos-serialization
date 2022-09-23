namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="option"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromKoobooJson<TValue>(this string json, JsonDeserializeOption option = null)
    {
        return KoobooHelper.FromJson<TValue>(json, option);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromKoobooJson<TValue>(this string json, Action<JsonDeserializeOption> optionAct)
    {
        return KoobooHelper.FromJson<TValue>(json, optionAct);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="option"></param>
    /// <returns></returns>
    public static object FromKoobooJson(this string json, Type type, JsonDeserializeOption option = null)
    {
        return KoobooHelper.FromJson(type, json, option);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static object FromKoobooJson(this string json, Type type, Action<JsonDeserializeOption> optionAct)
    {
        return KoobooHelper.FromJson(type, json, optionAct);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="option"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromKoobooJsonAsync<TValue>(this string json, JsonDeserializeOption option = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.FromJsonAsync<TValue>(json, option, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromKoobooJsonAsync<TValue>(this string json, Action<JsonDeserializeOption> optionAct, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.FromJsonAsync<TValue>(json, optionAct, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="option"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromKoobooJsonAsync(this string json, Type type, JsonDeserializeOption option = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.FromJsonAsync(type, json, option, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromKoobooJsonAsync(this string json, Type type, Action<JsonDeserializeOption> optionAct, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.FromJsonAsync(type, json, optionAct, cancellationToken);
    }
}