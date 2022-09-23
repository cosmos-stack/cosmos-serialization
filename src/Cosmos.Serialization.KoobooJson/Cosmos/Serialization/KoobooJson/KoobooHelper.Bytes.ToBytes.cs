using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooHelper
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value, JsonSerializerOption option = null, Encoding encoding = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : ToJson(value, option).ToBytes(encoding.GetEncoding());
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value, Action<JsonSerializerOption> optionAct, Encoding encoding = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : ToJson(value, optionAct).ToBytes(encoding.GetEncoding());
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, JsonSerializerOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : (await ToJsonAsync(value, option, cancellationToken)).ToBytes(encoding.GetEncoding());
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
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, Action<JsonSerializerOption> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : (await ToJsonAsync(value, optionAct, cancellationToken)).ToBytes(encoding.GetEncoding());
    }
}