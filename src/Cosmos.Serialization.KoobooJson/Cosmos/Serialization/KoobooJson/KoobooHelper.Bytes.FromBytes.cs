using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.KoobooJson;

public static partial class KoobooHelper
{
    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, JsonDeserializeOption option = null, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : FromJson(type, bytes.GetString(encoding.GetEncoding()), option);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, Action<JsonDeserializeOption> optionAct, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : FromJson(type, bytes.GetString(encoding.GetEncoding()), optionAct);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, JsonDeserializeOption option = null, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : FromJson<TValue>(bytes.GetString(encoding.GetEncoding()), option);
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="optionAct"></param>
    /// <param name="bytes"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, Action<JsonDeserializeOption> optionAct, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : FromJson<TValue>(bytes.GetString(encoding.GetEncoding()), optionAct);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, JsonDeserializeOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await FromJsonAsync(type, bytes.GetString(encoding.GetEncoding()), option, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <param name="bytes"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, Action<JsonDeserializeOption> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await FromJsonAsync(type, bytes.GetString(encoding.GetEncoding()), optionAct, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="option"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, JsonDeserializeOption option = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await FromJsonAsync<TValue>(bytes.GetString(encoding.GetEncoding()), option, cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="optionAct"></param>
    /// <param name="bytes"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, Action<JsonDeserializeOption> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await FromJsonAsync<TValue>(bytes.GetString(encoding.GetEncoding()), optionAct, cancellationToken);
    }
}