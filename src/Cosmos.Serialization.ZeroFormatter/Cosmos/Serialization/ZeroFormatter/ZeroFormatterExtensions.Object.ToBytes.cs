namespace Cosmos.Serialization.ZeroFormatter;

public static partial class ZeroFormatterExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToZeroFormatterBytes<TValue>(this TValue value)
    {
        return ZeroFormatterHelper.ToBytes(value);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static byte[] ToZeroFormatterBytes(this object value, Type type)
    {
        return ZeroFormatterHelper.ToBytes(type, value);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToZeroFormatterBytesAsync<TValue>(this TValue value, CancellationToken cancellationToken = default)
    {
        return ZeroFormatterHelper.ToBytesAsync(value, cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToZeroFormatterBytesAsync(this object value, Type type, CancellationToken cancellationToken = default)
    {
        return ZeroFormatterHelper.ToBytesAsync(value, cancellationToken);
    }
}