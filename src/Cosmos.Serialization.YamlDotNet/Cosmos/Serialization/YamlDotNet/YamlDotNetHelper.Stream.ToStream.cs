using System.Text;

namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value, S serializer = null, Encoding encoding = default)
    {
        return ToBytes(value, serializer, encoding).ToMemoryStream();
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, S serializer = null, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        var bytes = await ToBytesAsync(value, serializer, encoding, cancellationToken);
        return bytes.ToMemoryStream();
    }
}