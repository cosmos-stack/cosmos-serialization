namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void SpanJsonPackTo<TValue>(this TValue value, Stream stream)
    {
        SpanJsonHelper.Pack(value, stream);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static ValueTask SpanJsonPackToAsync<TValue>(this TValue value, Stream stream, CancellationToken cancellationToken = default)
    {
        return SpanJsonHelper.PackAsync(value, stream, cancellationToken);
    }
}