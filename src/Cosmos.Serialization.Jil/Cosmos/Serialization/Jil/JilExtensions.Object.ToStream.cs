using System.Text;

namespace Cosmos.Serialization.Jil;

public static partial class JilExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToJilStream<TValue>(this TValue value, Options options = null, Encoding encoding = null)
    {
        return JilHelper.ToStream(value, options, encoding);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToJilStream<TValue>(this TValue value, Action<Options> optionAct, Encoding encoding = null)
    {
        return JilHelper.ToStream(value, optionAct, encoding);
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
    public static Task<Stream> ToJilStreamAsync<TValue>(this TValue value, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.ToStreamAsync(value, options, encoding, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToJilStreamAsync<TValue>(this TValue value, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.ToStreamAsync(value, optionAct, encoding, cancellationToken);
    }
}