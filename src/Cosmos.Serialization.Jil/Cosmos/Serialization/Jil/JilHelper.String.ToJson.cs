namespace Cosmos.Serialization.Jil;

public static partial class JilHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToJson<TValue>(TValue value, Options options = null)
    {
        return value is null
            ? string.Empty
            : JSON.Serialize(value, options.ToOptions());
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToJson<TValue>(TValue value, Action<Options> optionAct)
    {
        return value is null
            ? string.Empty
            : JSON.Serialize(value, optionAct.GetOptions());
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static string ToJson(object value, Options options = null)
    {
        return value is null
            ? string.Empty
            : JSON.SerializeDynamic(value, options.ToOptions());
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static string ToJson(object value, Action<Options> optionAct)
    {
        return value is null
            ? string.Empty
            : JSON.SerializeDynamic(value, optionAct.GetOptions());
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync<TValue>(TValue value, Options options = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JSON.Serialize(value, options.ToOptions()), cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync<TValue>(TValue value, Action<Options> optionAct, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JSON.Serialize(value, optionAct.GetOptions()), cancellationToken);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync(object value, Options options = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JSON.SerializeDynamic(value, options.ToOptions()), cancellationToken);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync(object value, Action<Options> optionAct, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JSON.SerializeDynamic(value, optionAct.GetOptions()), cancellationToken);
    }
}