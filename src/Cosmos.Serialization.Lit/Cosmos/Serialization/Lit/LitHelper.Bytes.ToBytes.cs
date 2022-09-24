using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.Lit;

public static partial class LitHelper
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static byte[] ToBytes(object value, Encoding encoding = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : ToJson(value).ToBytes(encoding.GetEncoding());
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(object value, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : (await ToJsonAsync(value, cancellationToken)).ToBytes(encoding.GetEncoding());
    }
}