namespace Cosmos.Serialization.ZeroFormatter;

public static partial class ZeroFormatterExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToZeroFormatterStream<TValue>(this TValue value)
    {
        return ZeroFormatterHelper.ToStream(value);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Stream ToZeroFormatterStream(this object value, Type type)
    {
        return ZeroFormatterHelper.ToStream(type, value);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToZeroFormatterStreamAsync<TValue>(this TValue value, CancellationToken cancellationToken = default)
    {
        return ZeroFormatterHelper.ToStreamAsync(value, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<Stream> ToZeroFormatterStreamAsync(this object value, Type type, CancellationToken cancellationToken = default)
    {
        return ZeroFormatterHelper.ToStreamAsync(type, value, cancellationToken);
    }
}