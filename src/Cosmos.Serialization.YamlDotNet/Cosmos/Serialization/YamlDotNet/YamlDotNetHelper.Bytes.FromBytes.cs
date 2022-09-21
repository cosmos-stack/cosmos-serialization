using System.Text;

namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, D deserializer = null, Encoding encoding = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : FromYaml<TValue>(encoding.ToEncoding().GetString(bytes), deserializer);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="deserializer"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, D deserializer = null, Encoding encoding = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : FromYaml(type, encoding.ToEncoding().GetString(bytes), deserializer);
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
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, D deserializer = null, Encoding encoding = default,CancellationToken cancellationToken=default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await FromYamlAsync<TValue>(encoding.ToEncoding().GetString(bytes), deserializer, cancellationToken);
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
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, D deserializer = null, Encoding encoding = default,CancellationToken cancellationToken=default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await FromYamlAsync(type, encoding.ToEncoding().GetString(bytes), deserializer, cancellationToken);
    }
}