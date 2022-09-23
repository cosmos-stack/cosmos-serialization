using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.Jil;

public static partial class JilHelper
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value, Options options = null, Encoding encoding = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : ToJson(value, options).ToBytes(encoding.GetEncoding());
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value, Action<Options> optionAct, Encoding encoding = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : ToJson(value, optionAct).ToBytes(encoding.GetEncoding());
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static byte[] ToBytes(object value, Options options = null, Encoding encoding = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : ToJson(value, options).ToBytes(encoding.GetEncoding());
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static byte[] ToBytes(object value, Action<Options> optionAct, Encoding encoding = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : ToJson(value, optionAct).ToBytes(encoding.GetEncoding());
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
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : (await ToJsonAsync(value, options, cancellationToken)).ToBytes(encoding.GetEncoding());
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
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : (await ToJsonAsync(value, optionAct, cancellationToken)).ToBytes(encoding.GetEncoding());
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(object value, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : (await ToJsonAsync(value, options, cancellationToken)).ToBytes(encoding.GetEncoding());
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(object value, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : (await ToJsonAsync(value, optionAct, cancellationToken)).ToBytes(encoding.GetEncoding());
    }
}