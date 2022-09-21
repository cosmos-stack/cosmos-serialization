namespace Cosmos.Serialization.ZeroFormatter;

public static partial class ZeroFormatterExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromZeroFormatterStream<TValue>(this Stream stream)
    {
        return ZeroFormatterHelper.FromStream<TValue>(stream);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromZeroFormatterStream(this Stream stream, Type type)
    {
        return ZeroFormatterHelper.FromStream(type, stream);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromZeroFormatterStreamAsync<TValue>(this Stream stream, CancellationToken cancellationToken = default)
    {
        return ZeroFormatterHelper.FromStreamAsync<TValue>(stream, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromZeroFormatterStreamAsync(this Stream stream, Type type, CancellationToken cancellationToken = default)
    {
        return ZeroFormatterHelper.FromStreamAsync(type, stream, cancellationToken);
    }
}