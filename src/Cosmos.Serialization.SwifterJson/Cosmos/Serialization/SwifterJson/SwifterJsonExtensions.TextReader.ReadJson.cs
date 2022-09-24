namespace Cosmos.Serialization.SwifterJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue ReadSwifterJson<TValue>(this TextReader reader, JsonFormatterOptions? options = null)
    {
        return SwifterJsonHelper.Deserialize<TValue>(reader, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="reader"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object ReadSwifterJson(this TextReader reader, Type type, JsonFormatterOptions? options = null)
    {
        return SwifterJsonHelper.Deserialize(type, reader, options);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
#if NETFRAMEWORK
    public static Task<TValue> ReadSwifterJsonAsync<TValue>(this TextReader reader, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#else
    public static ValueTask<TValue> ReadSwifterJsonAsync<TValue>(this TextReader reader, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#endif
    {
        return SwifterJsonHelper.DeserializeAsync<TValue>(reader, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="reader"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
#if NETFRAMEWORK
    public static Task<object> ReadSwifterJsonAsync(this TextReader reader, Type type, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#else
    public static ValueTask<object> ReadSwifterJsonAsync(this TextReader reader, Type type, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#endif
    {
        return SwifterJsonHelper.DeserializeAsync(type, reader, options, cancellationToken);
    }
}