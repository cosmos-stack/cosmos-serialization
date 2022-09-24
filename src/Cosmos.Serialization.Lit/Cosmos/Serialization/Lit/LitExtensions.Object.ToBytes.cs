using System.Text;

namespace Cosmos.Serialization.Lit;

public static partial class LitExtensions
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static byte[] ToLitBytes(this object value, Encoding encoding = null)
    {
        return LitHelper.ToBytes(value, encoding);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToLitBytesAsync(this object value, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return LitHelper.ToBytesAsync(value, encoding, cancellationToken);
    }
}