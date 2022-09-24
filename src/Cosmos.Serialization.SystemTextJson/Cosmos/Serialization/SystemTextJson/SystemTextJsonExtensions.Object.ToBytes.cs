using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonExtensions
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static byte[] ToMsJsonBytes(this object value, JsonSerializerOptions options = null)
    {
        return SystemTextJsonHelper.ToBytes(value, options);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToMsJsonBytesAsync(this object value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return SystemTextJsonHelper.ToBytesAsync(value, options, cancellationToken);
    }
}