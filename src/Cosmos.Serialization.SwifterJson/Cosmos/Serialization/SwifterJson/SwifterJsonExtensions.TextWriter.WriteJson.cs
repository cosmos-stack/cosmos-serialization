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
    public static void WriteSwifterJson<TValue>(this TextWriter output, TValue value, JsonFormatterOptions? options = null)
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
    public static Task WriteSwifterJsonAsync<TValue>(this TextWriter output, TValue value, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#else
    public static ValueTask WriteSwifterJsonAsync<TValue>(this TextWriter output, TValue value, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#endif
    {
        return SwifterJsonHelper.SerializeAsync(value, output, options, cancellationToken);
    }
}