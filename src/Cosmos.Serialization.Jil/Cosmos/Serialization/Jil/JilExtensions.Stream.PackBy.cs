using System.Text;

namespace Cosmos.Serialization.Jil;

public static partial class JilExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void JilPackBy<TValue>(this Stream stream, TValue value, Options options = null, Encoding encoding = null)
    {
        JilHelper.Pack(value, stream, options, encoding);
    }

    /// <summary>
    /// PackBy
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void JilPackBy<TValue>(this Stream stream, TValue value, Action<Options> optionAct, Encoding encoding = null)
    {
        JilHelper.Pack(value, stream, optionAct, encoding);
    }

    /// <summary>
    /// PackBy async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task JilPackByAsync<TValue>(this Stream stream, TValue value, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.PackAsync(value, stream, options, encoding, cancellationToken);
    }

    /// <summary>
    /// PackBy async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task JilPackByAsync<TValue>(this Stream stream, TValue value, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.PackAsync(value, stream, optionAct, encoding, cancellationToken);
    }
}