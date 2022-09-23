using System.Text;

namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value, JsonSerializerOption option = null, Encoding encoding = null)
    {
        var stream = new MemoryStream();
        Pack(value, stream, option, encoding);
        return stream;
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, JsonSerializerOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(value, stream, option, encoding, cancellationToken);
        return stream;
    }
}