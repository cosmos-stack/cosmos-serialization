using System.Text;

namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromYamlDotNetStream<TValue>(this Stream stream, D deserializer = null, Encoding encoding = default)
    {
        return YamlDotNetHelper.FromStream<TValue>(stream, deserializer, encoding);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromYamlDotNetStream(this Stream stream, Type type, D deserializer = null, Encoding encoding = default)
    {
        return YamlDotNetHelper.FromStream(type, stream, deserializer, encoding);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromYamlDotNetStreamAsync<TValue>(this Stream stream, D deserializer = null, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        return YamlDotNetHelper.FromStreamAsync<TValue>(stream, deserializer, encoding, cancellationToken);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromYamlDotNetStreamAsync(this Stream stream, Type type, D deserializer = null, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        return YamlDotNetHelper.FromStreamAsync(type, stream, deserializer, encoding, cancellationToken);
    }
}