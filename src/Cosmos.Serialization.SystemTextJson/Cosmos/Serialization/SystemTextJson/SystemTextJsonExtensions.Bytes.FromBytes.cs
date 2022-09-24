using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromMsJsonBytes<TValue>(this byte[] bytes, JsonSerializerOptions options = null)
    {
        return SystemTextJsonHelper.FromBytes<TValue>(bytes, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromMsJsonBytes(this byte[] bytes, Type type, JsonSerializerOptions options = null)
    {
        return SystemTextJsonHelper.FromBytes(type, bytes, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromMsJsonBytesAsync<TValue>(this byte[] bytes, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return SystemTextJsonHelper.FromBytesAsync<TValue>(bytes, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromMsJsonBytesAsync(this byte[] bytes, Type type, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return SystemTextJsonHelper.FromBytesAsync(type, bytes, options, cancellationToken);
    }
}