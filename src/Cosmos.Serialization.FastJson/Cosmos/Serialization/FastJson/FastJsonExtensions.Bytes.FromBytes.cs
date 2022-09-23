using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonExtensions
{
    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromFastJsonBytes<TValue>(this byte[] bytes, JSONParameters parameters = null, Encoding encoding = null)
    {
        return FastJsonHelper.FromBytes<TValue>(bytes, parameters, encoding);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromFastJsonBytes<TValue>(this byte[] bytes, Action<JSONParameters> paramAct, Encoding encoding = null)
    {
        return FastJsonHelper.FromBytes<TValue>(bytes, paramAct, encoding);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromFastJsonBytes(this byte[] bytes, Type type, JSONParameters parameters = null, Encoding encoding = null)
    {
        return FastJsonHelper.FromBytes(type, bytes, parameters, encoding);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromFastJsonBytes(this byte[] bytes, Type type, Action<JSONParameters> paramAct, Encoding encoding = null)
    {
        return FastJsonHelper.FromBytes(type, bytes, paramAct, encoding);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromFastJsonBytesAsync<TValue>(this byte[] bytes, JSONParameters parameters = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.FromBytesAsync<TValue>(bytes, parameters, encoding, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromFastJsonBytesAsync<TValue>(this byte[] bytes, Action<JSONParameters> paramAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.FromBytesAsync<TValue>(bytes, paramAct, encoding, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromFastJsonBytesAsync(this byte[] bytes, Type type, JSONParameters parameters = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.FromBytesAsync(type, bytes, parameters, encoding, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromFastJsonBytesAsync(this byte[] bytes, Type type, Action<JSONParameters> paramAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.FromBytesAsync(type, bytes, paramAct, encoding, cancellationToken);
    }
}