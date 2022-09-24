using System.Text;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static byte[] ToNewtonsoftBytes(this object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        return NewtonsoftJsonHelper.ToBytes(value, settings, enableNodaTime, encoding);
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
    public static Task<byte[]> ToNewtonsoftBytesAsync(this object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return NewtonsoftJsonHelper.ToBytesAsync(value, settings, enableNodaTime, encoding, cancellationToken);
    }
}