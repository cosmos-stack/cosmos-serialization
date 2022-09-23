namespace Cosmos.Serialization.Jil;

public static partial class JilHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJson<TValue>(string json, Options options = null)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JSON.Deserialize<TValue>(json, options.ToOptions());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJson<TValue>(string json, Action<Options> optionAct)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JSON.Deserialize<TValue>(json, optionAct.GetOptions());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromJson(Type type, string json, Options options = null)
    {
        if (string.IsNullOrWhiteSpace(json))
            return null;
        using var reader = new StringReader(json);
        return JSON.Deserialize(reader, type, options.ToOptions());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static object FromJson(Type type, string json, Action<Options> optionAct)
    {
        if (string.IsNullOrWhiteSpace(json))
            return null;
        using var reader = new StringReader(json);
        return JSON.Deserialize(reader, type, optionAct.GetOptions());
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromJsonAsync<TValue>(string json, Options options = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JSON.Deserialize<TValue>(json, options.ToOptions()), cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromJsonAsync<TValue>(string json, Action<Options> optionAct, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : await Task.Run(() => JSON.Deserialize<TValue>(json, optionAct.GetOptions()), cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromJsonAsync(Type type, string json, Options options = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(json))
            return default;
        return await Task.Run(() =>
        {
            using var reader = new StringReader(json);
            return JSON.Deserialize(reader, type, options.ToOptions());
        }, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromJsonAsync(Type type, string json, Action<Options> optionAct, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(json))
            return default;
        return await Task.Run(() =>
        {
            using var reader = new StringReader(json);
            return JSON.Deserialize(reader, type, optionAct.GetOptions());
        }, cancellationToken);
    }
}