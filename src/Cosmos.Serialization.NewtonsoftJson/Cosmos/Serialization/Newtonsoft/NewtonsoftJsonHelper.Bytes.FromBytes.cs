using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : FromJson<TValue>(bytes.GetString(encoding.GetEncoding()), settings, enableNodaTime);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : FromJson(type, bytes.GetString(encoding.GetEncoding()), settings, enableNodaTime);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await FromJsonAsync<TValue>(bytes.GetString(encoding.GetEncoding()), settings, enableNodaTime, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await FromJsonAsync(type, bytes.GetString(encoding.GetEncoding()), settings, enableNodaTime, cancellationToken);
    }
}