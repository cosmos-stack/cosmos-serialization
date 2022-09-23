namespace Cosmos.Serialization.Jil;

public static partial class JilExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJilJson<TValue>(this string json, Options options = null)
    {
        return JilHelper.FromJson<TValue>(json, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJilJson<TValue>(this string json, Action<Options> optionAct)
    {
        return JilHelper.FromJson<TValue>(json, optionAct);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromJilJson(this string json, Type type, Options options = null)
    {
        return JilHelper.FromJson(type, json, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static object FromJilJson(this string json, Type type, Action<Options> optionAct)
    {
        return JilHelper.FromJson(type, json, optionAct);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromJilJsonAsync<TValue>(this string json, Options options = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.FromJsonAsync<TValue>(json, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromJilJsonAsync<TValue>(this string json, Action<Options> optionAct, CancellationToken cancellationToken = default)
    {
        return JilHelper.FromJsonAsync<TValue>(json, optionAct, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromJilJsonAsync(this string json, Type type, Options options = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.FromJsonAsync(type, json, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromJilJsonAsync(this string json, Type type, Action<Options> optionAct, CancellationToken cancellationToken = default)
    {
        return JilHelper.FromJsonAsync(type, json, optionAct, cancellationToken);
    }
}