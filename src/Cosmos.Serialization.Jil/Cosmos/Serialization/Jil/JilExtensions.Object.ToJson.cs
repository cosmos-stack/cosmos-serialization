namespace Cosmos.Serialization.Jil;

public static partial class JilExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToJilJson<TValue>(this TValue value, Options options = null)
    {
        return JilHelper.ToJson(value, options);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToJilJson<TValue>(this TValue value, Action<Options> optionAct)
    {
        return JilHelper.ToJson(value, optionAct);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static string ToJilJson(this object value, Options options = null)
    {
        return JilHelper.ToJson(value, options);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static string ToJilJson(this object value, Action<Options> optionAct)
    {
        return JilHelper.ToJson(value, optionAct);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static  Task<string> ToJilJsonAsync<TValue>(this TValue value, Options options = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.ToJsonAsync(value, options, cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static  Task<string> ToJilJsonAsync<TValue>(this TValue value, Action<Options> optionAct, CancellationToken cancellationToken = default)
    {
        return JilHelper.ToJsonAsync(value, optionAct, cancellationToken);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static  Task<string> ToJilJsonAsync(this object value, Options options = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.ToJsonAsync(value, options, cancellationToken);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static  Task<string> ToJilJsonAsync(this object value, Action<Options> optionAct, CancellationToken cancellationToken = default)
    {
        return JilHelper.ToJsonAsync(value, optionAct, cancellationToken);
    }
}