using System.Text;

namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromFastJsonStream<TValue>(this Stream stream, JSONParameters parameters = null, Encoding encoding = null)
    {
        return FastJsonHelper.FromStream<TValue>(stream, parameters, encoding);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromFastJsonStream<TValue>(this Stream stream, Action<JSONParameters> paramAct, Encoding encoding = null)
    {
        return FastJsonHelper.FromStream<TValue>(stream, paramAct, encoding);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromFastJsonStream(this Stream stream, Type type, JSONParameters parameters = null, Encoding encoding = null)
    {
        return FastJsonHelper.FromStream(type, stream, parameters, encoding);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromFastJsonStream(this Stream stream, Type type, Action<JSONParameters> paramAct = null, Encoding encoding = null)
    {
        return FastJsonHelper.FromStream(type, stream, paramAct, encoding);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromFastJsonStreamAsync<TValue>(this Stream stream, JSONParameters parameters = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.FromStreamAsync<TValue>(stream, parameters, encoding, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromFastJsonStreamAsync<TValue>(this Stream stream, Action<JSONParameters> paramAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.FromStreamAsync<TValue>(stream, paramAct, encoding, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromFastJsonStreamAsync(this Stream stream, Type type, JSONParameters parameters = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.FromStreamAsync(type, stream, parameters, encoding, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromFastJsonStreamAsync(this Stream stream, Type type, Action<JSONParameters> paramAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.FromStreamAsync(type, stream, paramAct, encoding, cancellationToken);
    }
}