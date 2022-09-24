using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.SwifterJson;

public static partial class SwifterJsonHelper
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value, JsonFormatterOptions? options = null, Encoding encoding = null)
    {
        return ToJson(value, options).ToBytes(encoding.GetEncoding());
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, JsonFormatterOptions? options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        var json = await ToJsonAsync(value, options, cancellationToken);
        return json.ToBytes(encoding.GetEncoding());
    }
}