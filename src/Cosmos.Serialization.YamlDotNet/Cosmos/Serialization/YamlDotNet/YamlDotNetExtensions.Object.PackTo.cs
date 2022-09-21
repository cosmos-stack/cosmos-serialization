using System.Text;

namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="serializer"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void YamlDotNetPackTo<TValue>(this TValue value, Stream stream, S serializer = null, Encoding encoding = default)
    {
        YamlDotNetHelper.Pack(value, stream, serializer, encoding);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="serializer"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task YamlDotNetPackToAsync<TValue>(this TValue value, Stream stream, S serializer = null, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        return YamlDotNetHelper.PackAsync(value, stream, serializer, encoding, cancellationToken);
    }
}