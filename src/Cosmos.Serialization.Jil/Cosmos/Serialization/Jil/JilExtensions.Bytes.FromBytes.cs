using System.Text;

namespace Cosmos.Serialization.Jil;

public static partial class JilExtensions
{
    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJilBytes<TValue>(this byte[] bytes, Options options = null, Encoding encoding = null)
    {
        return JilHelper.FromBytes<TValue>(bytes, options, encoding);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromJilBytes<TValue>(this byte[] bytes, Action<Options> optionAct, Encoding encoding = null)
    {
        return JilHelper.FromBytes<TValue>(bytes, optionAct, encoding);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromJilBytes(this byte[] bytes, Type type, Options options = null, Encoding encoding = null)
    {
        return JilHelper.FromBytes(type, bytes, options, encoding);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromJilBytes(this byte[] bytes, Type type, Action<Options> optionAct, Encoding encoding = null)
    {
        return JilHelper.FromBytes(type, bytes, optionAct, encoding);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromJilBytesAsync<TValue>(this byte[] bytes, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.FromBytesAsync<TValue>(bytes, options, encoding, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromJilBytesAsync<TValue>(this byte[] bytes, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.FromBytesAsync<TValue>(bytes, optionAct, encoding, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromJilBytesAsync(this byte[] bytes, Type type, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.FromBytesAsync(type, bytes, options, encoding, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromJilBytesAsync(this byte[] bytes, Type type, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return JilHelper.FromBytesAsync(type, bytes, optionAct, encoding, cancellationToken);
    }
}