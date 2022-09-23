using System.Text;

namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooExtensions
{
    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromKoobooBytes(this byte[] bytes, Type type, JsonDeserializeOption option = null, Encoding encoding = null)
    {
        return KoobooHelper.FromBytes(type, bytes, option, encoding);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromKoobooBytes(this byte[] bytes, Type type, Action<JsonDeserializeOption> optionAct, Encoding encoding = null)
    {
        return KoobooHelper.FromBytes(type, bytes, optionAct, encoding);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static TValue FromKoobooBytes<TValue>(this byte[] bytes, JsonDeserializeOption option = null, Encoding encoding = null)
    {
        return KoobooHelper.FromBytes<TValue>(bytes, option, encoding);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="optionAct"></param>
    /// <param name="bytes"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static TValue FromKoobooBytes<TValue>(this byte[] bytes, Action<JsonDeserializeOption> optionAct, Encoding encoding = null)
    {
        return KoobooHelper.FromBytes<TValue>(bytes, optionAct, encoding);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromKoobooBytesAsync(this byte[] bytes, Type type, JsonDeserializeOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.FromBytesAsync(type, bytes, option, encoding, cancellationToken);
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
    public static Task<object> FromKoobooBytesAsync(this byte[] bytes, Type type, Action<JsonDeserializeOption> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.FromBytesAsync(type, bytes, optionAct, encoding, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static Task<TValue> FromKoobooBytesAsync<TValue>(this byte[] bytes, JsonDeserializeOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.FromBytesAsync<TValue>(bytes, option, encoding, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="optionAct"></param>
    /// <param name="bytes"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static Task<TValue> FromKoobooBytesAsync<TValue>(this byte[] bytes, Action<JsonDeserializeOption> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return KoobooHelper.FromBytesAsync<TValue>(bytes, optionAct, encoding, cancellationToken);
    }
}