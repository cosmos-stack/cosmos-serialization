namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToSpanJsonBytes<TValue>(this TValue value)
    {
        return SpanJsonHelper.ToBytes(value);
    }

    public static ValueTask<byte[]> ToSpanJsonBytesAsync<TValue>(this TValue value, CancellationToken cancellationToken = default)
    {
        return SpanJsonHelper.ToBytesAsync(value, cancellationToken);
    }
}