using SpanJson;

#if NETCOREAPP3_1
using Cosmos.Asynchronous;
#endif

namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJson<TValue>(string json)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.Generic.Utf16.Deserialize<TValue>(json);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="jsonChar"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJson<TValue>(in ReadOnlySpan<char> jsonChar)
    {
        return jsonChar.IsEmpty
            ? default
            : JsonSerializer.Generic.Utf16.Deserialize<TValue>(jsonChar);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <returns></returns>
    public static object FromJson(Type type, string json)
    {
        return string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.NonGeneric.Utf16.Deserialize(json, type);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="jsonChar"></param>
    /// <returns></returns>
    public static object FromJson(Type type, in ReadOnlySpan<char> jsonChar)
    {
        return jsonChar.IsEmpty
            ? default
            : JsonSerializer.NonGeneric.Utf16.Deserialize(jsonChar, type);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static ValueTask<TValue> FromJsonAsync<TValue>(string json, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(json))
#if NET5_0_OR_GREATER
            return ValueTask.FromResult(default(TValue));
#else
            return ValueTasks.Create(default(TValue));
#endif
        using var reader = new StringReader(json);
        return JsonSerializer.Generic.Utf16.DeserializeAsync<TValue>(reader, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="json"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static ValueTask<object> FromJsonAsync(Type type, string json, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(json))
#if NET5_0_OR_GREATER
            return ValueTask.FromResult(default(object));
#else
            return ValueTasks.Create(default(object));
#endif
        using var reader = new StringReader(json);
        return JsonSerializer.NonGeneric.Utf16.DeserializeAsync(reader, type, cancellationToken);
    }
}