namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromSpanJsonBytes(this byte[] bytes, Type type)
    {
        return SpanJsonHelper.FromBytes(type, bytes);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromSpanJsonBytes(this ReadOnlySpan<byte> bytes, Type type)
    {
        return SpanJsonHelper.FromBytes(type, bytes);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <returns></returns>
    public static TValue FromSpanJsonBytes<TValue>(this byte[] bytes)
    {
        return SpanJsonHelper.FromBytes<TValue>(bytes);
    }


    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public static TValue FromSpanJsonBytes<TValue>(this ReadOnlySpan<byte> data)
    {
        return SpanJsonHelper.FromBytes<TValue>(data);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static ValueTask<object> FromSpanJsonBytesAsync(this byte[] bytes, Type type, CancellationToken cancellationToken = default)
    {
        return SpanJsonHelper.FromBytesAsync(type, bytes, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static ValueTask<T> FromSpanJsonBytesAsync<T>(this byte[] bytes, CancellationToken cancellationToken = default)
    {
        return SpanJsonHelper.FromBytesAsync<T>(bytes, cancellationToken);
    }
}