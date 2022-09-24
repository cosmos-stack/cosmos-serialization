namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value, IJsonFormatterResolver resolver = null)
    {
        var stream = new MemoryStream();
        Pack(value, stream, resolver);
        return stream;
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(value, stream, resolver, cancellationToken);
        return stream;
    }
}