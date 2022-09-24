namespace Cosmos.Serialization.SwifterJson;

public static partial class SwifterJsonHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue Deserialize<TValue>(TextReader reader, JsonFormatterOptions? options = null)
    {
        return reader is null
            ? default
            : JsonFormatter.DeserializeObject<TValue>(reader, options.ToDeserializeOptions());
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="reader"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object Deserialize(Type type, TextReader reader, JsonFormatterOptions? options = null)
    {
        return reader is null
            ? default
            : JsonFormatter.DeserializeObject(reader, type, options.ToDeserializeOptions());
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
    public static Task<TValue> DeserializeAsync<TValue>(TextReader reader, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#else
    public static ValueTask<TValue> DeserializeAsync<TValue>(TextReader reader, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#endif
    {
        if (reader is null)
#if NETFRAMEWORK
            return Task.FromResult<TValue>(default);
#elif NETCOREAPP3_1
            return new ValueTask<TValue>(default(TValue));
#else
            return ValueTask.FromResult(default(TValue));
#endif
        return JsonFormatter.DeserializeObjectAsync<TValue>(reader, options.ToDeserializeOptions());
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
    public static Task<object> DeserializeAsync(Type type, TextReader reader, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#else
    public static ValueTask<object> DeserializeAsync(Type type, TextReader reader, JsonFormatterOptions? options = null, CancellationToken cancellationToken = default)
#endif
    {
        if (reader is null)
#if NETFRAMEWORK
            return Task.FromResult<object>(default);
#elif NETCOREAPP3_1
            return new ValueTask<object>(default(object));
#else
            return ValueTask.FromResult(default(object));
#endif
        return JsonFormatter.DeserializeObjectAsync(reader, type, options.ToDeserializeOptions());
    }
}