using System.Text;

namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetExtensions
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static byte[] ToYamlDotNetBytes<TValue>(this TValue value, S serializer = null, Encoding encoding = default)
    {
        return YamlDotNetHelper.ToBytes(value, serializer, encoding);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToYamlDotNetBytesAsync<TValue>(this TValue value, S serializer = null, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        return YamlDotNetHelper.ToBytesAsync(value, serializer, encoding, cancellationToken);
    }
}