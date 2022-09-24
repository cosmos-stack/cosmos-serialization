using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static byte[] ToBytes(object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : ToJson(value, settings, enableNodaTime).ToBytes(encoding.GetEncoding());
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : (await ToJsonAsync(value, settings, enableNodaTime, cancellationToken)).ToBytes(encoding.GetEncoding());
    }
}