using System.Text;

namespace Cosmos.Serialization.SwifterJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromSwifterJsonStream<TValue>(this Stream stream, JsonFormatterOptions? options = null, Encoding encoding = null)
    {
        return SwifterJsonHelper.FromStream<TValue>(stream, options, encoding);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromSwifterJsonStream(this Stream stream, Type type, JsonFormatterOptions? options = null, Encoding encoding = null)
    {
        return SwifterJsonHelper.FromStream(type, stream, options, encoding);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromSwifterJsonStreamAsync<TValue>(this Stream stream, JsonFormatterOptions? options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return SwifterJsonHelper.FromStreamAsync<TValue>(stream, options, encoding, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromSwifterJsonStreamAsync(this Stream stream, Type type, JsonFormatterOptions? options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return SwifterJsonHelper.FromStreamAsync(type, stream, options, encoding, cancellationToken);
    }
}