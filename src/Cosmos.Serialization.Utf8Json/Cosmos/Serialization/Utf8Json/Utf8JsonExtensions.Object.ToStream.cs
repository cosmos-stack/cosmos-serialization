namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToUtf8JsonStream<TValue>(this TValue value, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.ToStream(value, resolver);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToUtf8JsonStreamAsync<TValue>(this TValue value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return Utf8JsonHelper.ToStreamAsync(value, resolver, cancellationToken);
    }
}