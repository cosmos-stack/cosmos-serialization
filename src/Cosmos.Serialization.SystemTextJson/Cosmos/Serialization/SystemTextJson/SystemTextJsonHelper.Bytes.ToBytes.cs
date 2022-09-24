using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static byte[] ToBytes(object value, JsonSerializerOptions options = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : JsonSerializer.SerializeToUtf8Bytes(value, options.ToOptions());
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(object value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : await Task.Run(() => JsonSerializer.SerializeToUtf8Bytes(value, options.ToOptions()), cancellationToken);
    }
}