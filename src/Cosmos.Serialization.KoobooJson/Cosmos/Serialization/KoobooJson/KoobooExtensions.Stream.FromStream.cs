using System.Text;

namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromKoobooStream<TValue>(this Stream stream, JsonDeserializeOption option = null, Encoding encoding = null)
    {
        return KoobooHelper.FromStream<TValue>(stream, option, encoding);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromKoobooStream(this Stream stream, Type type, JsonDeserializeOption option = null, Encoding encoding = null)
    {
        return KoobooHelper.FromStream(type, stream, option, encoding);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromStreamAsync<TValue>(this Stream stream, JsonDeserializeOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.FromStreamAsync<TValue>(stream, option, encoding, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromStreamAsync(this Stream stream, Type type, JsonDeserializeOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.FromStreamAsync(type, stream, option, encoding, cancellationToken);
    }
}