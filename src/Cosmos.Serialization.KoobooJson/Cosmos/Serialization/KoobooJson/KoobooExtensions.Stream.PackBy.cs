using System.Text;

namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void KoobooPackBy<TValue>(this Stream stream, TValue value, JsonSerializerOption option = null, Encoding encoding = null)
    {
        KoobooHelper.Pack(value, stream, option, encoding);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task KoobooPackByAsync<TValue>(this Stream stream, TValue value, JsonSerializerOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.PackAsync(value, stream, option, encoding, cancellationToken);
    }
}