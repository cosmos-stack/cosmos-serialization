using System.Text;

namespace Cosmos.Serialization.SwifterJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToSwifterJsonStream<TValue>(this TValue value, JsonFormatterOptions? options = null, Encoding encoding = null)
    {
        return SwifterJsonHelper.ToStream(value, options, encoding);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToSwifterJsonStreamAsync<TValue>(this TValue value, JsonFormatterOptions? options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return SwifterJsonHelper.ToStreamAsync(value, options, encoding, cancellationToken);
    }
}