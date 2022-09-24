using SpanJson;

namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToJson<TValue>(TValue value)
    {
        return value is null
            ? string.Empty
            : JsonSerializer.Generic.Utf16.Serialize(value);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string ToJson(object value)
    {
        return value is null
            ? string.Empty
            : JsonSerializer.NonGeneric.Utf16.Serialize(value);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async ValueTask<string> ToJsonAsync<TValue>(TValue value, CancellationToken cancellationToken = default)
    {
        if (value is null)
            return string.Empty;
        await using TextWriter writer = new StringWriter();
        await JsonSerializer.Generic.Utf16.SerializeAsync(value, writer, cancellationToken);
        return writer.ToString();
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async ValueTask<string> ToJsonAsync(object value, CancellationToken cancellationToken = default)
    {
        if (value is null)
            return string.Empty;
        await using TextWriter writer = new StringWriter();
        await JsonSerializer.NonGeneric.Utf16.SerializeAsync(value, writer, cancellationToken);
        return writer.ToString();
    }
}