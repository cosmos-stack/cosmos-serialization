using System.Text;

namespace Cosmos.Serialization.SwifterJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void SwifterJsonPackBy<TValue>(this Stream stream, TValue value, JsonFormatterOptions? options = null, Encoding encoding = null)
    {
        SwifterJsonHelper.Pack(value, stream, options, encoding);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task SwifterJsonPackByAsync<TValue>(this Stream stream, TValue value, JsonFormatterOptions? options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return SwifterJsonHelper.PackAsync(value, stream, options, encoding, cancellationToken);
    }
}