using System.Text;

namespace Cosmos.Serialization.Lit;

public static partial class LitExtensions
{
    /// <summary>
    /// PackBy
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void LitPackBy<TValue>(this Stream stream, TValue value, Encoding encoding = null)
    {
        LitHelper.Pack(value, stream, encoding);
    }


    /// <summary>
    /// PackBy async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task LitPackByAsync<TValue>(this Stream stream, TValue value, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return LitHelper.PackAsync(value, stream, encoding, cancellationToken);
    }
}