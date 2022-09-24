namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Utf8JsonPackBy<TValue>(this Stream stream, TValue value, IJsonFormatterResolver resolver = null)
    {
        Utf8JsonHelper.Pack(value, stream, resolver);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task Utf8JsonPackByAsync<TValue>(this Stream stream, TValue value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return Utf8JsonHelper.PackAsync(value, stream, resolver, cancellationToken);
    }
}