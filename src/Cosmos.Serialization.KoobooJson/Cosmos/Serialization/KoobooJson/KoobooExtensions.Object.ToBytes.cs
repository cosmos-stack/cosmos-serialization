using System.Text;

namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooExtensions
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToKoobooBytes<TValue>(this TValue value, JsonSerializerOption option = null, Encoding encoding = null)
    {
        return KoobooHelper.ToBytes(value, option, encoding);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToKoobooBytes<TValue>(this TValue value, Action<JsonSerializerOption> optionAct, Encoding encoding = null)
    {
        return KoobooHelper.ToBytes(value, optionAct, encoding);
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
    public static Task<byte[]> ToKoobooBytesAsync<TValue>(this TValue value, JsonSerializerOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.ToBytesAsync(value, option, encoding, cancellationToken);
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
    public static Task<byte[]> ToKoobooBytesAsync<TValue>(this TValue value, Action<JsonSerializerOption> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.ToBytesAsync(value, optionAct, encoding, cancellationToken);
    }
}