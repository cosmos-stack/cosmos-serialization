using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
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
    public static TValue FromNewtonsoftJsonBytes<TValue>(this byte[] bytes, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        return NewtonsoftJsonHelper.FromBytes<TValue>(bytes, settings, enableNodaTime, encoding);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromNewtonsoftJsonBytes(this byte[] bytes, Type type, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        return NewtonsoftJsonHelper.FromBytes(type, bytes, settings, enableNodaTime, encoding);
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
    public static Task<TValue> FromNewtonsoftJsonBytesAsync<TValue>(this byte[] bytes, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return NewtonsoftJsonHelper.FromBytesAsync<TValue>(bytes, settings, enableNodaTime, encoding, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromNewtonsoftJsonBytesAsync(this byte[] bytes, Type type, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return NewtonsoftJsonHelper.FromBytesAsync(type, bytes, settings, enableNodaTime, encoding, cancellationToken);
    }
}