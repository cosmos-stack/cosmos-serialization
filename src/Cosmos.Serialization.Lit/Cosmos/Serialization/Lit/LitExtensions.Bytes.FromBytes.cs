using System.Text;

namespace Cosmos.Serialization.Lit;

public static partial class LitExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromLitBytes<TValue>(this byte[] bytes, Encoding encoding = null)
    {
        return LitHelper.FromBytes<TValue>(bytes, encoding);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromLitBytes(this byte[] bytes, Type type, Encoding encoding = null)
    {
        return LitHelper.FromBytes(type, bytes, encoding);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromLitBytesAsync<TValue>(this byte[] bytes, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return LitHelper.FromBytesAsync<TValue>(bytes, encoding, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromLitBytesAsync(this byte[] bytes, Type type, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return LitHelper.FromBytesAsync(type, bytes, encoding, cancellationToken);
    }
}