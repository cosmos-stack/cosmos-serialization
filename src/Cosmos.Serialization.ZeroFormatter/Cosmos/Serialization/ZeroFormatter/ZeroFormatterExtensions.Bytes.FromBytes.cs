namespace Cosmos.Serialization.ZeroFormatter;

public static partial class ZeroFormatterExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromZeroFormatterBytes<TValue>(this byte[] bytes)
    {
        return ZeroFormatterHelper.FromBytes<TValue>(bytes);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromZeroFormatterBytes(this byte[] bytes, Type type)
    {
        return ZeroFormatterHelper.FromBytes(type, bytes);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromZeroFormatterBytesAsync<TValue>(this byte[] bytes, CancellationToken cancellationToken = default)
    {
        return ZeroFormatterHelper.FromBytesAsync<TValue>(bytes, cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromZeroFormatterBytesAsync(this byte[] bytes, Type type, CancellationToken cancellationToken = default)
    {
        return ZeroFormatterHelper.FromBytesAsync(type, bytes, cancellationToken);
    }
}