namespace Cosmos.Serialization.SwifterJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="output"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void SwifterJsonSerialize<TValue>(this TValue value, TextWriter output, JsonFormatterOptions? options = null)
    {
        SwifterJsonHelper.Serialize(value, output, options);
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
    public static Task SwifterJsonSerializeAsync<TValue>(this TValue value, TextWriter output, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#else
    public static ValueTask SerializeAsync<TValue>(this TValue value, TextWriter output, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#endif
    {
        return SwifterJsonHelper.SerializeAsync(value, output, options, cancellationToken);
    }
}