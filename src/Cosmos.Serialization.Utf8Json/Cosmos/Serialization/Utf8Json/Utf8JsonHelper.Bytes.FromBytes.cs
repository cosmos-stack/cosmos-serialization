namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, IJsonFormatterResolver resolver = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JsonSerializer.Deserialize<TValue>(bytes, resolver);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, IJsonFormatterResolver resolver = null)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
        var reader = new JsonReader(bytes, 0);
        return JsonSerializer.NonGeneric.Deserialize(type, ref reader, resolver);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JsonSerializer.Deserialize<TValue>(bytes, resolver), cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="resolver"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, IJsonFormatterResolver resolver = null, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
        var reader = new JsonReader(bytes, 0);
        return await Task.Run(() => JsonSerializer.NonGeneric.Deserialize(type, ref reader, resolver), cancellationToken);
    }
}