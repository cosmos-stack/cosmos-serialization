using System.Text;

namespace Cosmos.Serialization.Lit;

public static partial class LitExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromLitStream<TValue>(this Stream stream, Encoding encoding = null)
    {
        return LitHelper.FromStream<TValue>(stream, encoding);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromLitStream(this Stream stream, Type type, Encoding encoding = null)
    {
        return LitHelper.FromStream(type, stream, encoding);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromLitStreamAsync<TValue>(this Stream stream, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return LitHelper.FromStreamAsync<TValue>(stream, encoding, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromLitStreamAsync(this Stream stream, Type type, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return LitHelper.FromStreamAsync(type, stream, encoding, cancellationToken);
    }
}