using System.Text;

namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToFastJsonStream<TValue>(this TValue value, JSONParameters parameters = null, Encoding encoding = null)
    {
        return FastJsonHelper.ToStream(value, parameters, encoding);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToFastJsonStream<TValue>(this TValue value, Action<JSONParameters> paramAct, Encoding encoding = null)
    {
        return FastJsonHelper.ToStream(value, paramAct, encoding);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToFastJsonStreamAsync<TValue>(this TValue value, JSONParameters parameters = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.ToStreamAsync(value, parameters, encoding, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToFastJsonStreamAsync<TValue>(this TValue value, Action<JSONParameters> paramAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.ToStreamAsync(value, paramAct, encoding, cancellationToken);
    }
}