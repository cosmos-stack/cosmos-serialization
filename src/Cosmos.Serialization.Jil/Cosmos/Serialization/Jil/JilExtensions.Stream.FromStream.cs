using System.Text;

namespace Cosmos.Serialization.Jil;

public static partial class JilExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJilStream<TValue>(this Stream stream, Options options = null, Encoding encoding = null)
    {
        return JilHelper.FromStream<TValue>(stream, options, encoding);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJilStream<TValue>(this Stream stream, Action<Options> optionAct, Encoding encoding = null)
    {
        return JilHelper.FromStream<TValue>(stream, optionAct, encoding);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromJilStream(this Stream stream, Type type, Options options = null, Encoding encoding = null)
    {
        return JilHelper.FromStream(type, stream, options, encoding);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromJilStream(this Stream stream, Type type, Action<Options> optionAct, Encoding encoding = null)
    {
        return JilHelper.FromStream(type, stream, optionAct, encoding);
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
    public static Task<TValue> FromJilStreamAsync<TValue>(this Stream stream, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.FromStreamAsync<TValue>(stream, options, encoding, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromJilStreamAsync<TValue>(this Stream stream, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.FromStreamAsync<TValue>(stream, optionAct, encoding, cancellationToken);
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
    public static Task<object> FromJilStreamAsync(this Stream stream, Type type, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.FromStreamAsync(type, stream, options, encoding, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromJilStreamAsync(this Stream stream, Type type, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.FromStreamAsync(type, stream, optionAct, encoding, cancellationToken);
    }
}