namespace Cosmos.Serialization.Lit;

public static partial class LitExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromLitJson<TValue>(this string json)
    {
        return LitHelper.FromJson<TValue>(json);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromLitJson(this string json, Type type)
    {
        return LitHelper.FromJson(type, json);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromLitJsonAsync<TValue>(this string json, CancellationToken cancellationToken = default)
    {
        return LitHelper.FromJsonAsync<TValue>(json, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromLitJsonAsync(this string json, Type type, CancellationToken cancellationToken = default)
    {
        return LitHelper.FromJsonAsync(type, json, cancellationToken);
    }
}