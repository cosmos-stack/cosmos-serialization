using System.Text;

namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToYamlDotNetStream<TValue>(this TValue value, S serializer = null, Encoding encoding = default)
    {
        return YamlDotNetHelper.ToStream(value, serializer, encoding);
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
    public static Task<Stream> ToYamlDotNetStreamAsync<TValue>(this TValue value, S serializer = null, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        return YamlDotNetHelper.ToStreamAsync(value, serializer, encoding, cancellationToken);
    }
}