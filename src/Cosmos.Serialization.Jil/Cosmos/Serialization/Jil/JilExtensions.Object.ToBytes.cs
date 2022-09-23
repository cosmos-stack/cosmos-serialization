using System.Text;

namespace Cosmos.Serialization.Jil;

public static partial class JilExtensions
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToJilBytes<TValue>(this TValue value, Options options = null, Encoding encoding = null)
    {
        return JilHelper.ToBytes(value, options, encoding);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToJilBytes<TValue>(this TValue value, Action<Options> optionAct, Encoding encoding = null)
    {
        return JilHelper.ToBytes(value, optionAct, encoding);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static byte[] ToJilBytes(this object value, Options options = null, Encoding encoding = null)
    {
        return JilHelper.ToBytes(value, options, encoding);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static byte[] ToJilBytes(this object value, Action<Options> optionAct, Encoding encoding = null)
    {
        return JilHelper.ToBytes(value, optionAct, encoding);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToJilBytesAsync<TValue>(this TValue value, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.ToBytesAsync(value, options, encoding, cancellationToken);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToJilBytesAsync<TValue>(this TValue value, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.ToBytesAsync(value, optionAct, encoding, cancellationToken);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToJilBytesAsync(this object value, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.ToBytesAsync(value, options, encoding, cancellationToken);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToJilBytesAsync(this object value, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.ToBytesAsync(value, optionAct, encoding, cancellationToken);
    }
}