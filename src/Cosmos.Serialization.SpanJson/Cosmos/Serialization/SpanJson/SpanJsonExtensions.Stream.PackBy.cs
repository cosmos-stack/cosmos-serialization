namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void SpanJsonPackBy<TValue>(this Stream stream, TValue value)
    {
        SpanJsonHelper.Pack(value, stream);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static ValueTask SpanJsonPackByAsync<TValue>(this Stream stream, TValue value, CancellationToken cancellationToken = default)
    {
        return SpanJsonHelper.PackAsync(value, stream, cancellationToken);
    }
}