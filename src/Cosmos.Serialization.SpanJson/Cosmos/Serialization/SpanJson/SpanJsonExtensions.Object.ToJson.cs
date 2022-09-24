namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToSpanJson<TValue>(this TValue value)
    {
        return SpanJsonHelper.ToJson(value);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string ToSpanJson(this object value)
    {
        return SpanJsonHelper.ToJson(value);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static ValueTask<string> ToSpanJsonAsync<TValue>(this TValue value, CancellationToken cancellationToken = default)
    {
        return SpanJsonHelper.ToJsonAsync(value, cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static ValueTask<string> ToSpanJsonAsync(this object value, CancellationToken cancellationToken = default)
    {
        return SpanJsonHelper.ToJsonAsync(value, cancellationToken);
    }
}