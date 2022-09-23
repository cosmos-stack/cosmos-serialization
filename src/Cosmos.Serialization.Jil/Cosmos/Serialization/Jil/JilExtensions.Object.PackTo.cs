using System.Text;

namespace Cosmos.Serialization.Jil;

public static partial class JilExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void JilPackTo<TValue>(this TValue value, Stream stream, Options options = null, Encoding encoding = null)
    {
        JilHelper.Pack(value, stream, options, encoding);
    }

    /// <summary>
    /// PackTo
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void JilPackTo<TValue>(this TValue value, Stream stream, Action<Options> optionAct, Encoding encoding = null)
    {
        JilHelper.Pack(value, stream, optionAct, encoding);
    }

    /// <summary>
    /// PackTo async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task JilPackToAsync<TValue>(this TValue value, Stream stream, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.PackAsync(value, stream, options, encoding, cancellationToken);
    }

    /// <summary>
    /// PackTo async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task JilPackToAsync<TValue>(this TValue value, Stream stream, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.PackAsync(value, stream, optionAct, encoding, cancellationToken);
    }
}