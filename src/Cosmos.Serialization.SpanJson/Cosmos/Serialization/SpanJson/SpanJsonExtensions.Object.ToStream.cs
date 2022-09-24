namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToSpanJsonStream<TValue>(this TValue value)
    {
        return SpanJsonHelper.ToStream(value);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static ValueTask<Stream> ToSpanJsonStreamAsync<TValue>(this TValue value, CancellationToken cancellationToken = default)
    {
        return SpanJsonHelper.ToStreamAsync(value, cancellationToken);
    }
}