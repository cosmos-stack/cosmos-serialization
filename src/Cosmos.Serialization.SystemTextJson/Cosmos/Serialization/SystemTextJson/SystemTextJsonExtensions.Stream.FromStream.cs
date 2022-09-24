using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromMsJsonStream<TValue>(this Stream stream, JsonSerializerOptions options = null)
    {
        return SystemTextJsonHelper.FromStream<TValue>(stream, options);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromMsJsonStream(this Stream stream, Type type, JsonSerializerOptions options = null)
    {
        return SystemTextJsonHelper.FromStream(type, stream, options);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromMsJsonStreamAsync<TValue>(this Stream stream, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return SystemTextJsonHelper.FromStreamAsync<TValue>(stream, options, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromMsJsonStreamAsync(this Stream stream, Type type, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return SystemTextJsonHelper.FromStreamAsync(type, stream, options, cancellationToken);
    }
}