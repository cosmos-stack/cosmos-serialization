namespace Cosmos.Serialization.ZeroFormatter;

public static partial class ZeroFormatterExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void ZeroFormatterPackTo<TValue>(this TValue value, Stream stream)
    {
        ZeroFormatterHelper.Pack(value, stream);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    public static void ZeroFormatterPackTo(this object value, Type type, Stream stream)
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
    public static Task ZeroFormatterPackToAsync<TValue>(this TValue value, Stream stream, CancellationToken cancellationToken = default)
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
    public static Task ZeroFormatterPackToAsync(this object value, Type type, Stream stream, CancellationToken cancellationToken = default)
    {
        return ZeroFormatterHelper.PackAsync(type, value, stream, cancellationToken);
    }
}