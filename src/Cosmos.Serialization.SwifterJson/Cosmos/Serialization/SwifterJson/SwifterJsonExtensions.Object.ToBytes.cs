using System.Text;

namespace Cosmos.Serialization.SwifterJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToSwifterJsonBytes<TValue>(this TValue value, JsonFormatterOptions? options = null, Encoding encoding = null)
    {
        return SwifterJsonHelper.ToBytes(value, options, encoding);
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
    public static Task<byte[]> ToSwifterJsonBytesAsync<TValue>(this TValue value, JsonFormatterOptions? options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return SwifterJsonHelper.ToBytesAsync(value, options, encoding, cancellationToken);
    }
}