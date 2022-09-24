using System.Text;

namespace Cosmos.Serialization.SwifterJson;

public static partial class SpanJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void SwifterJsonPackTo<TValue>(this TValue value, Stream stream, JsonFormatterOptions? options = null, Encoding encoding = null)
    {
        SwifterJsonHelper.Pack(value, stream, options, encoding);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task SwifterJsonPackToAsync<TValue>(this TValue value, Stream stream, JsonFormatterOptions? options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return SwifterJsonHelper.PackAsync(value, stream, options, encoding, cancellationToken);
    }
}