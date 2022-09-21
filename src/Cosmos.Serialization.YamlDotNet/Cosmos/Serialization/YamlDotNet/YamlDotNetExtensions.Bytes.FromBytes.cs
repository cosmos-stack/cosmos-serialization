using System.Text;

namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromYamlDotNetBytes<TValue>(this byte[] bytes, D deserializer = null, Encoding encoding = default)
    {
        return YamlDotNetHelper.FromBytes<TValue>(bytes, deserializer, encoding);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromYamlDotNetBytes(this byte[] bytes, Type type, D deserializer = null, Encoding encoding = default)
    {
        return YamlDotNetHelper.FromBytes(type, bytes, deserializer, encoding);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromYamlDotNetBytesAsync<TValue>(this byte[] bytes, D deserializer = null, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        return YamlDotNetHelper.FromBytesAsync<TValue>(bytes, deserializer, encoding, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromYamlDotNetBytesAsync(this byte[] bytes, Type type, D deserializer = null, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        return YamlDotNetHelper.FromBytesAsync(type, bytes, deserializer, encoding, cancellationToken);
    }
}