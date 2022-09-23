using System.Text;

namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonExtensions
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToFastJsonBytes<TValue>(this TValue value, JSONParameters parameters = null, Encoding encoding = null)
    {
        return FastJsonHelper.ToBytes(value, parameters, encoding);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToFastJsonBytes<TValue>(this TValue value, Action<JSONParameters> paramAct, Encoding encoding = null)
    {
        return FastJsonHelper.ToBytes(value, paramAct, encoding);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToFastJsonBytesAsync<TValue>(this TValue value, JSONParameters parameters = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.ToBytesAsync(value, parameters, encoding, cancellationToken);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToFastJsonBytesAsync<TValue>(this TValue value, Action<JSONParameters> paramAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.ToBytesAsync(value, paramAct, encoding, cancellationToken);
    }
}