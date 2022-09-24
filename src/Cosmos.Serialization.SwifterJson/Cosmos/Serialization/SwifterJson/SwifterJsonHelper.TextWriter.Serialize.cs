namespace Cosmos.Serialization.SwifterJson;

public static partial class SwifterJsonHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="output"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Serialize<TValue>(TValue value, TextWriter output, JsonFormatterOptions? options = null)
    {
        JsonFormatter.SerializeObject(value, output, options.ToSerializeOptions());
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="output"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
#if NETFRAMEWORK
    public static Task SerializeAsync<TValue>(TValue value, TextWriter output, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#else
    public static ValueTask SerializeAsync<TValue>(TValue value, TextWriter output, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#endif
    {
        return JsonFormatter.SerializeObjectAsync(value, output, options.ToSerializeOptions());
    }
}