using System.Text;

namespace Cosmos.Serialization.Lit;

public static partial class LitExtensions
{
    /// <summary>
    /// PackTo
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void LitPackTo<TValue>(this TValue value, Stream stream, Encoding encoding = null)
    {
        LitHelper.Pack(value, stream, encoding);
    }


    /// <summary>
    /// PackTo async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task LitPackToAsync<TValue>(this TValue value, Stream stream, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return LitHelper.PackAsync(value, stream, encoding, cancellationToken);
    }
}