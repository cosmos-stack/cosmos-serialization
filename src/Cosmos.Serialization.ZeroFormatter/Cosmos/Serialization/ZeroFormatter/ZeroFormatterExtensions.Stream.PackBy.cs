namespace Cosmos.Serialization.ZeroFormatter;

public static partial class ZeroFormatterExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void ZeroFormatterPackBy<TValue>(this Stream stream, TValue value)
    {
        ZeroFormatterHelper.Pack(value, stream);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    public static void ZeroFormatterPackBy(this Type type, object value, Stream stream)
    {
        ZeroFormatterHelper.Pack(type, value, stream);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task ZeroFormatterPackByAsync<TValue>(this Stream stream, TValue value, CancellationToken cancellationToken = default)
    {
        return ZeroFormatterHelper.PackAsync(value, stream, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    public static Task ZeroFormatterPackByAsync(this Stream stream, Type type, object value, CancellationToken cancellationToken = default)
    {
        return ZeroFormatterHelper.PackAsync(type, value, stream, cancellationToken);
    }
}