using System.Text;

namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToKoobooStream<TValue>(this TValue value, JsonSerializerOption option = null, Encoding encoding = null)
    {
        return KoobooHelper.ToStream(value, option, encoding);
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
    public static Task<Stream> ToKoobooStreamAsync<TValue>(this TValue value, JsonSerializerOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.ToStreamAsync(value, option, encoding, cancellationToken);
    }
}