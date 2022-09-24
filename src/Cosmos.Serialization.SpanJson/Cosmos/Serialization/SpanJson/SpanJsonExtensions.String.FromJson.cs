namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromSpanJson<TValue>(this string json)
    {
        return SpanJsonHelper.FromJson<TValue>(json);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="jsonChar"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromSpanJson<TValue>(this ReadOnlySpan<char> jsonChar)
    {
        return SpanJsonHelper.FromJson<TValue>(jsonChar);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromSpanJson(this string json, Type type)
    {
        return SpanJsonHelper.FromJson(type, json);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="jsonChar"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromSpanJson(this ReadOnlySpan<char> jsonChar, Type type)
    {
        return SpanJsonHelper.FromJson(type, jsonChar);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static ValueTask<TValue> FromSpanJsonAsync<TValue>(this string json, CancellationToken cancellationToken = default)
    {
        return SpanJsonHelper.FromJsonAsync<TValue>(json, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static ValueTask<object> FromSpanJsonAsync(this string json, Type type, CancellationToken cancellationToken = default)
    {
        return SpanJsonHelper.FromJsonAsync(type, json, cancellationToken);
    }
}