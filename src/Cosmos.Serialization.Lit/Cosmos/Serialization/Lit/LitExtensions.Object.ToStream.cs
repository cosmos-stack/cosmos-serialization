using System.Text;

namespace Cosmos.Serialization.Lit;

public static partial class LitExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToLitStream<TValue>(this TValue value, Encoding encoding = null)
    {
        return LitHelper.ToStream(value, encoding);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToLitStreamAsync<TValue>(this TValue value, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return LitHelper.ToStreamAsync(value, encoding, cancellationToken);
    }
}