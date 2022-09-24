using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, JsonSerializerOptions options = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JsonSerializer.Deserialize<TValue>(bytes, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, JsonSerializerOptions options = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JsonSerializer.Deserialize(bytes, type, options);
    }

    /// <summary>
    /// Parse the UTF-8 encoded text representing a single JSON value into a <typeparamref name="TValue"/>.
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(ReadOnlySpan<byte> bytes, JsonSerializerOptions options = null)
    {
        return bytes.Length is 0
            ? default
            : JsonSerializer.Deserialize<TValue>(bytes, options);
    }

    /// <summary>
    /// Parse the UTF-8 encoded text representing a single JSON value into a <paramref name="type"/>.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, ReadOnlySpan<byte> bytes, JsonSerializerOptions options = null)
    {
        return bytes.Length is 0
            ? default
            : JsonSerializer.Deserialize(bytes, type, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JsonSerializer.Deserialize<TValue>(bytes, options.ToOptions()), cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JsonSerializer.Deserialize(bytes, type, options.ToOptions()), cancellationToken);
    }
}